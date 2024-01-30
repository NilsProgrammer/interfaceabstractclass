public enum Priority
{
    LOW,
    MEDIUM,
    HIGH
}

public static class PriorityExtension {
    public static Priority getHigher(Priority priority)
    {
        List<Priority> priorities = Enum.GetValues(typeof(Priority)).Cast<Priority>().ToList();
        int priorityIndex = priorities.IndexOf(priority);
        if (priorityIndex >= priorities.Count - 1) {
            return priority;
        }

        return priorities[priorityIndex + 1];
    }
}