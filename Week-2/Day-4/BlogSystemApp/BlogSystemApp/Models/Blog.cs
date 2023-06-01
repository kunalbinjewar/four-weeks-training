using System.Xml.Linq;

namespace BlogSystemApp.Models
{

    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public byte[] ConcurrencyToken { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
