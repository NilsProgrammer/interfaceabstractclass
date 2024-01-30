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

        Manager<Employee> employeeManager = new Manager<Employee>(manager.get().OfType<Employee>().ToList());
        Manager<Patient> patientManager = new Manager<Patient>(manager.get().OfType<Patient>().ToList());

        PersistenceManager<Employee>.ExportToCSV(employeeManager.get(), null, true);
        PersistenceManager<Patient>.ExportToCSV(patientManager.get(), null);
        
        Console.ReadLine();
    }
}