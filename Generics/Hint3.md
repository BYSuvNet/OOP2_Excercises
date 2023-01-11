# Hint 3 - Methods

## Push()
```cs
public void Push(string item)
{
    if (count == items.Length)
    {
        ResizeArray(items.Length * 2);
    }
    items[count] = item;
    count++;
}
```

## Pop()
```cs
public T Pop()
{
    if (count == 0)
        throw new InvalidOperationException("The stack is empty.");

    count--;
    var result = items[count];
    items[count] = default(string); //What does this default mean?

    if (count > 0 && count == items.Length / 4)
    {
        ResizeArray(items.Length / 2);
    }
    return result;
}
```

## ResizeArray()
```cs
private void ResizeArray(int newSize)
{
    var newArray = new T[newSize];
    Array.Copy(items, newArray, count);
    items = newArray;
}
```