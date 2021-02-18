using System.Drawing;

namespace Entities.Friends
{
    // Model class
    public class Friend
    {
        //[Key]
        public string Name { get; set; }

        //[Required]
        public Point Location { get; set; }
    }
}
