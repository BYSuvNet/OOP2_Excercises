public class BookFilter
{
    public List<Book> FilteredBooks { get; set; } = new();
    int _pagesLimit;

    public BookFilter(int pagesLimit)
    {
        _pagesLimit = pagesLimit;
    }

    public void FilterBookByPages(Book b)
    {
        if (b.Pages > _pagesLimit)
        {
            FilteredBooks.Add(b);
        }
    }

    public void FilterBook(Book b, Predicate<Book> filter)
    {
        if (filter(b))
        {
            FilteredBooks.Add(b);
        }
    }
}