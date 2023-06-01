using Microsoft.EntityFrameworkCore;

namespace BlogSystemApp.Models
{
    public class Comment
    {

        public int Id { get; set; }
        public string Content { get; set; }

        var blog = dbContext.Blogs.Find(BlogId);
        var comments =Comment.Blog; // Lazy loading will fetch the comments from the database if not already loaded.

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

        //public int BlogId { get; set; }
        //public Blog Blog { get; set; }
    }
}
