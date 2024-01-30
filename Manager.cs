public class Manager<T>
{
    private readonly List<T> data = new List<T>();

    public Manager() {}

    public Manager(List<T> list) {
        data.AddRange(list);
    }
    public List<T> get() {
        return data;
    }
    public void add(T obj) {
        data.Add(obj);
    }

    public void addAll(List<T> objs) {
        data.AddRange(objs);
    }
}