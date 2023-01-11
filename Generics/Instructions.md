# Generics 

The goal of this exercise is to understand why "Generics" can be useful and how to it them when creating classes.

We start by recreating the Stack class in a non-generic version, and then we make a generic version out of it.

**Step 1:** Create a class called "Stack" that can hold a stack of items of a certain type, int string or whatever. The stack should have the following methods:

Push(item): Add an item to the top of the stack
Pop(): Remove and return the item at the top of the stack
Peek(): Return the item at the top of the stack without removing it
Count: Return the number of items in the stack

Example usage with a stack that holds strings:

```cs
var stack = new Stack();
stack.Push("Hej");
stack.Push("på");
stack.Push("dej!");
Console.WriteLine(stack.Peek()); // Output: dej!
Console.WriteLine(stack.Pop()); // Output: dej!
Console.WriteLine(stack.Peek()); // Output: på
Console.WriteLine(stack.Count); // Output: 2
```

**Step 2:** Convert the class to a Generic class that can hold any type of item, not just the one that was hard coded in the first example 

**Step 3:** Add a method "public bool CompareToFirst(T input)" that will return true or false depending on if the submitted value "input" is more or less than the first element of the array. Try this with several different types of T. What happends? How do we fix possible problems?