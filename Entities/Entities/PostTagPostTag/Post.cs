using System.Collections.Generic;

namespace Entities.PostTagPostTag
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
    //public class Post
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Category { get; set; }
    //    public int BlogId { get; set; }
    //    public Blog Blog { get; set; }
    //}
}
