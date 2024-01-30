public class Measurement : IMeasurement
{
    public static readonly List<Measurement> measurements = new List<Measurement>();
    public IPerson Person {get; private set;}
    public BloodPressure Pulse {get; private set;}
    public float Temperature {get; private set;}
    public DateTime DateOfMeasurement {get; private set;}

    public Measurement(IPerson person, BloodPressure pulse, float temperature, DateTime? dateOfMeasurement) {
        Person = person;
        Pulse = pulse;
        Temperature = temperature;
        DateOfMeasurement = dateOfMeasurement ?? DateTime.Now;

        measurements.Add(this);
    }
}