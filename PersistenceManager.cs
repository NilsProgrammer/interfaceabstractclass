using System.Text;
using System.Text.Json;

public abstract class PersistenceManager<T> where T : IPerson, new()
{
    private static readonly string defaultPath = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "People";
    private const char csvDivider = ';';
    public static void ExportToCSV(List<T> people, string? path) => File.WriteAllLines(
            path ?? (defaultPath + ".csv"),
            people.Select<T, string>(
                person => new StringBuilder()
                .Append(typeof(Person).ToString())
                .Append(csvDivider)
                .Append(person.Name)
                .Append(csvDivider)
                .Append(person.Age)
                .ToString()
            )
        );

    public static List<IPerson> ImportFromCSV(string? path) => File
        .ReadAllLines(path ?? (defaultPath + ".csv"))
        .Where(line => line.Split(csvDivider)[0] != typeof(T).ToString())
        .Select<string, IPerson>(line =>
        {
            string[] values = line.Split(csvDivider);

            T obj = new T();
            obj.Name = values[1];
            obj.Age = Convert.ToByte(values[2]);
            obj.Weight = (float)Convert.ToSingle(values[3]);

            return obj;
        })
        .ToList();

    public static void ExportToJSON(List<T> people, string? path) => File.WriteAllText(path ?? (defaultPath + ".json"), JsonSerializer.Serialize(people));

    public static List<T> ImportFromJSON(string? path) => JsonSerializer
            .Deserialize<List<T>>(File.ReadAllText(path ?? (defaultPath + ".json")))
            ?? new List<T>();
}