using System.Collections.Generic;

namespace Entities.PostBlog
{
    public class Blog
    {
        public int Id;
        public string Name;
        public ICollection<Post> Posts;
    }
}
