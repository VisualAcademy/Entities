﻿using System.Collections.Generic;

namespace Entities.BlogPost._2._2
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
