/*
DynamicIntArray numbers = new DynamicIntArray();
DynamicDoubleArray number = new DynamicDoubleArray();

numbers.Add(101);
numbers.Add(202);

number.Add(2.22);
number.Add(3.33);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers.Get(i));
}

for (int i = 0; i < number.Count; i++)
{
    Console.WriteLine(number.Get(i));
}
public class DynamicIntArray
{
    private int[] data = new int[10];
    int count = 0;
    public void Add(int n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            Array.Resize(ref data, data.Length * 2);
        }
    }

    public int Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }

}

public class DynamicDoubleArray
{
    private double[] data = new double[10];
    int count = 0;
    public void Add(double n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            Array.Resize(ref data, data.Length * 2);
        }
    }

    public double Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }

} */

DynamicArray<int> da = new DynamicArray<int>();
da.Add(1);
da.Add(2);
da.Add(3);

for (int i = 0; i < da.Count; i++)
{
    Console.WriteLine(da.Get(i));
}
public class DynamicArray<datatype>
{
    private datatype[] data = new datatype[10];
    int count = 0;
    public void Add(datatype n)
    {
        if (count < data.Length) // its empty
        {
            data[count++] = n;
        }
        else // its full
        {
            Array.Resize(ref data, data.Length * 2);
        }
    }

    public datatype Get(int i)
    {
        return data[i];
    }

    public int Count
    {
        get { return count; }

    }
}