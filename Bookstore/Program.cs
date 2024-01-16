// class Program
// {
//     static void Main()
//     {
//         BookDB bookDB = new BookDB();

//         AddExampleBooks(bookDB);

//         Console.WriteLine($"Total amount of books: {bookDB.TotalAmountOfBooks}");

//         Console.WriteLine("Book Titles:");
//         bookDB.ProcessBooks(PrintBookTitle);

//         PriceTotaller totaller = new PriceTotaller();

//         bookDB.ProcessBooks(totaller.AddBookToTotal);

//         Console.WriteLine("Average Book Price: ${0:#.##}", totaller.AveragePrice());

//         BookFilter bookPageFilter = new BookFilter(200);
//         bookDB.ProcessBooks(bookPageFilter.FilterBookByPages);

//         Console.WriteLine("Books with more than 200 pages:");
//         bookPageFilter.FilteredBooks.ForEach(PrintBookTitle);

//         BookFilter bookFilter = new BookFilter(200);
//         bookDB.ProcessBooks(b => bookFilter.FilterBook(b, b => b.Paperback));
//     }

//     static void PrintBookTitle(Book b)
//     {
//         Console.WriteLine($"   {b.Title}");
//     }

//     static void AddExampleBooks(BookDB bookDB)
//     {
//         bookDB.AddBook("The C Programming Language", "Brian W. Kernighan and Dennis M. Ritchie", 100, 19.95m, true);
//         bookDB.AddBook("The Unicode Standard 2.0", "The Unicode Consortium", 145, 39.95m, true);
//         bookDB.AddBook("The MS-DOS Encyclopedia", "Ray Duncan", 237, 129.95m, false);
//         bookDB.AddBook("Dogbert's Clues for the Clueless", "Scott Adams", 698, 12.00m, true);
//     }
// }

class Program
{
    static void Main()
    {
        Action simpleAction = () => Console.WriteLine("Hej!");
        Action<int> printInt = i => Console.WriteLine("Din int. " + i);
        Action<int, int> multiplyInts = (i, j) => Console.WriteLine("Resultat: " + i * j);

        simpleAction();
        printInt(5);
        multiplyInts(5, 5);

        Predicate<string> checkLength = s => s.Length > 10;
        bool isLongString = checkLength("blablablabla");
        Console.WriteLine("String is longer that 10:" + isLongString);

        Func<string, string> reverseString = b =>
        {
            char[] charArray = b.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        };
        Console.WriteLine("Reversed string: " + reverseString("Hejsan!"));

        var queue = new Queue<string>();

        // Add an item to the queue
        queue.Enqueue("transaction1");

        // Check to see if the queue contains a given item 
        var contains = queue.Contains("transaction1");

        // Remove and return the item on the front of the queue
        var front = queue.Dequeue();

        // Return the item on the front without removing it 
        var top = queue.Peek();

        // Remove all items from queue 
        queue.Clear();

        // Get the number of items in the queue
        var count = queue.Count;







    }
}

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}