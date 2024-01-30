using System.Text;

public abstract class Person : IPerson
{
    public string Name {get; set;} = "Name";
    public int Age {get; set;} = 0;
    public float Weight {get; set;} = 0;

    protected Person() {}

    protected Person(string name, int age, float weight) : base() {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public override string ToString()
    {
        return new StringBuilder().Append(Name).Append(", ").Append(Age).Append(", ").Append(Weight).ToString();
    }
}