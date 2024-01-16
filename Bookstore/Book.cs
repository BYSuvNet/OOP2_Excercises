//DO NOT MODIFY THIS CLASS!
public struct Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public int Pages { get; set; }
    public bool Paperback { get; set; } // Is it paperback book or not?

    public Book(string title, string author, int pages, decimal price, bool paperBack)
    {
        Title = title;
        Author = author;
        Price = price;
        Pages = pages;
        Paperback = paperBack;
    }
}