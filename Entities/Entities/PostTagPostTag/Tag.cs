using System.Collections.Generic;

namespace Entities.PostTagPostTag
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
