namespace SuvnetPress;

internal class Program
{
    private static void Main(string[] args)
    {
        Author newAuthor = new("Gustav", "namn@epost.se");
        Blog blog = new();

        BlogPost post1 = new(newAuthor);
        post1.Title = "Lucia 2022";
        post1.Content = "Vi åt pepparkakor.";
        post1.IsPublished = true;

        BlogPost post2 = new(newAuthor);
        post2.Title = "Cykelresan";
        post2.Content = "Vi cyklade 500 mil på två dagar.";
        post2.IsPublished = true;

        blog.AddBlogPost(post1);
        blog.AddBlogPost(post2);

        foreach (BlogPost post in blog.GetAllPosts())
        {
            Console.WriteLine($"{post.Title} av {post.Author.Name}");
        }
    }
}