namespace SuvnetPress;

class Comment
{
    public string Content { get; set; }
    public DateTime CreatedAt { get; private set; }

    public Comment(string content)
    {
        Content = content;
        CreatedAt = DateTime.Now;
    }
}