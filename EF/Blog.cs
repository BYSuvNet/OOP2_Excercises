namespace SuvnetPress;

class Blog
{
    List<BlogPost> blogPosts = new();

    //Lägga till en nu BlogPost
    public void AddBlogPost(BlogPost blogPost)
    {
        blogPosts.Add(blogPost);
    }

    //Hämta en lista på alla blogposts
    public List<BlogPost> GetAllPosts()
    {
        return blogPosts;
    }

    public BlogPost GetBlogPost(int id)
    {
        //FIXME! Gör en sökalgoritm här som hittar och skickar 
        //tillbaka en BlogPost med specifikt Id
        return null;
    }

    //Ta bort en BlogPost

    //Redigera BlogPost

    //Söka efter blogginlägg
}