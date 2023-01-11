# Hint 1

Exempel på hur klassen kan struktureras:

```cs
class Stack
{
    private string[] items;
    private int count;
    public int Count { get => count }

    public Stack()
    {
        items = new()[10];
        count = 0;
    }

    public void Push(string item)
    {
        // Add the item to the top of the stack
    }

    public string Pop()
    {
        // Remove and return the item at the top of the stack
    }

    public string Peek()
    {
        // Return the item at the top of the stack without removing it
    }
}
```