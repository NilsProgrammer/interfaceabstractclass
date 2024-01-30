namespace interfaceabstractclass;
class Program
{
    static void Main(string[] args)
    {
        Manager<IPerson> manager = new Manager<IPerson>();
        
        manager.addAll(new List<IPerson> {
            new PersonFactory<Patient>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Patient>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Patient>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Patient>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Patient>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),

            new PersonFactory<Employee>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Employee>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Employee>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Employee>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
            new PersonFactory<Employee>().WithRandomName().WithRandomAge().WithRandomWeight().Create(),
        });

        manager.get().ForEach(person => Console.WriteLine(person.ToString()));
        
        Console.ReadLine();
    }
}