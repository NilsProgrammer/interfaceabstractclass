using System.Diagnostics;
using System.Text;

public class PersonFactory<T> where T : IPerson, new()
{
    private const string chars = "abcdefghijklmnopqrstuvwxyz";
    private readonly Random random = new Random();
    private readonly T created = new T();

    public PersonFactory<T> WithName(string name) {
        created.Name = name;

        return this;
    }

    public PersonFactory<T> WithRandomName(int length = 10) {
        Debug.Assert(length >= 0, "length must be >= 0");

        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < length; i++) {
            builder.Append(chars[random.Next(0, chars.Length)]);
        }

        return WithName(builder.ToString());
    }

    public PersonFactory<T> WithAge(byte age) {
        created.Age = age;

        return this;
    }

    public PersonFactory<T> WithRandomAge(byte start = 0, byte stop = 150) {
        return WithAge((byte)random.Next(start, stop + 1));
    }

    public PersonFactory<T> WithWeight(float weight) {
        created.Weight = weight;

        return this;
    }

    public PersonFactory<T> WithRandomWeight(float start = 0, float stop = 500) {
        float decim = random.Next((int)start, (int)stop + 1);
        float floa = ((float)random.Next(0, 10)) / 10;

        return WithWeight(Math.Clamp(decim + floa, start, stop));
    }

    public T Create() {
        return created;
    }
}