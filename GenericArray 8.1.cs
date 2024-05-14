class GenericArray<T>
{
    private T[] array;

    public GenericArray(int size)
    {
        array = new T[size];
    }

    public void AddItem(int index, T item)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = item;
        }
        else
        {
            Console.WriteLine("Индекс находится за пределами массива");
        }
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            array[index] = default(T);
        }
        else
        {
            Console.WriteLine("Индекс находится за пределами массива");
        }
    }

    public T GetItem(int index)
    {
        if (index >= 0 && index < array.Length)
        {
            return array[index];
        }
        else
        {
            Console.WriteLine("Индекс находится за пределами массива");
            return default(T);
        }
    }

    public int GetLength()
    {
        return array.Length;
    }
}