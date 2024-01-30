public class Warning : IWarning
{
    public string Advice {get; private set;} = "Okay";

    public Priority Priority {get; private set;} = Priority.LOW;

    public Warning(string advice, Priority priority) {
        Advice = advice;
        Priority = priority;
    }
}
