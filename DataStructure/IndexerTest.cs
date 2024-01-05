
public class MyCollection
{
    private int[] data = new int[10];
 
    // Indexer with multiple parameters
    public int this[int index, bool square]
    {
        get
        {
            if (square)
                return data[index] * data[index];
            else
                return data[index];
        }
        set
        {
            if (square)
                data[index] = (int)Math.Sqrt(value);
            else
                data[index] = value;
        }
    }
 
    // Overloaded indexer with string parameter
    public int this[string name]
    {
        get
        {
            switch (name.ToLower())
            {
                case "first":
                    return data[0];
                case "last":
                    return data[data.Length - 1];
                default:
                    throw new ArgumentException("Invalid index parameter.");
            }
        }
    }
 
    // Read-only indexer
    public int this[int index]
    {
        get { return data[index]; }
    }
}