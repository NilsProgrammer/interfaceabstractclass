public class BloodPressure
{
    public int High {get => High; private set => Math.Clamp(value, 0, 200);}
    public int Low {get => Low; private set => Math.Clamp(value, 0, 200);}

    public override string ToString() {
        return High + "/" + Low;
    }
}
