public interface IAnalyzer<T> where T : IMeasurement
{
    public abstract IWarning Analyze(T measurement);
}