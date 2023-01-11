class Stack<T>
{
    private T[] items;
    private int count;
    public int Count { get => count; }

    public Stack()
    {
        items = new T[10];
        count = 0;
    }

    public void Push(T item)
    {
        if (count == items.Length)
        {
            ResizeArray(items.Length * 2);
        }
        items[count] = item;
        count++;
    }

    public T Pop()
    {
        if (count == 0)
            throw new InvalidOperationException("The stack is empty.");

        count--;
        var result = items[count];
        items[count] = default(T); //What does this default mean?

        if (count > 0 && count == items.Length / 4)
        {
            ResizeArray(items.Length / 2);
        }
        return result;
    }

    public T Peek()
    {
        return items[count - 1];
    }

    private void ResizeArray(int newSize)
    {
        var newArray = new T[newSize];
        Array.Copy(items, newArray, count);
        items = newArray;
    }
}