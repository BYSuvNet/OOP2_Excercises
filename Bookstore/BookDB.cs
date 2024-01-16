//DO NOT MODIFY THIS CLASS!
public class BookDB
{
    List<Book> list = new();
    public int TotalAmountOfBooks { get { return list.Count; } }

    public void AddBook(string title, string author, int pages, decimal price, bool paperBack)
    {
        list.Add(new Book(title, author, pages, price, paperBack));
    }

    public void ProcessBooks(Action<Book> processBook)
    {
        foreach (Book b in list)
        {
            processBook(b);
        }
    }
}