using System.Text;

public class Analyzer<T> : IAnalyzer<T> where T : IMeasurement
{
    public IWarning Analyze(T measurement) {
        StringBuilder advice = new StringBuilder();
        Priority priority = Priority.LOW;

        if (measurement.Pulse.High <= 120 && measurement.Pulse.Low <= 80) {
            advice.Append("Blood Pressure: Okay");
            priority = Priority.LOW;
        }
        else {
            advice.Append("Blood Pressure: High");
            priority = PriorityExtension.getHigher(priority);
        }

        if (measurement.Temperature >= 38) {
            advice.Append(" / High body temperature");

            priority = priority = PriorityExtension.getHigher(priority);
        }

        return new Warning(advice.ToString(), priority);
    }

}