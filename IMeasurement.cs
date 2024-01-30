public interface IMeasurement
{
    internal IPerson Person {get;}
    internal BloodPressure Pulse {get;}

    internal float Temperature {get;}

    internal DateTime DateOfMeasurement {get;}
}