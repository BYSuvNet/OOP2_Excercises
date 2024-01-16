// Class to total and average prices of books:
class PriceTotaller
{
    int countBooks = 0;
    decimal priceBooks = 0.0m;

    internal void AddBookToTotal(Book book)
    {
        countBooks += 1;
        priceBooks += book.Price;
    }

    internal decimal AveragePrice()
    {
        return priceBooks / countBooks;
    }
}