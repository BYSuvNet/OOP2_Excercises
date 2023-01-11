internal class Program
{
    private static void Main(string[] args)
    {
        var stack = new Stack<string>();
        stack.Push("Hej");
        stack.Push("på");
        stack.Push("dej!");
        Console.WriteLine(stack.Peek()); // Output: dej!
        Console.WriteLine(stack.Pop()); // Output: dej!
        Console.WriteLine(stack.Peek()); // Output: på
        Console.WriteLine(stack.Count); // Output: 2
    }
}