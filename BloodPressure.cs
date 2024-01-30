public class BloodPressure
{
    private static Random random = new Random();
    public int High {get; private set;}
    public int Low {get; private set;}

    public BloodPressure() { }

    public BloodPressure(int high, int low) : this() { High = high; Low = low; }

    public override string ToString() {
        return High + "/" + Low;
    }
}
