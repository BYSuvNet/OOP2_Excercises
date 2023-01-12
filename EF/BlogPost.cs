namespace SuvnetPress;

class BlogPost
{

    public int Id { get; private set; }
    public Author Author { get; private set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public bool IsPublished { get; set; }

    private DateTime _createdAt;
    public DateTime CreatedAt { get { return _createdAt; } }

    private DateTime _modifiedAt;

    public BlogPost(Author author)
    {
        Id = new Random().Next();
        Author = author;
        _createdAt = DateTime.Now;
    }
}