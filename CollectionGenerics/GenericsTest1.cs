namespace Learning1.CollectionGenerics;
public class GenericsTest1<T>
{
    private T? data;

    public T Value {
        get {
            return this.data;
        }

        set {
            this.data = value;
        }
    }
}