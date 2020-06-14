using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
    public class ImageBlog
    {                     
    public int imageID { get; set; }
    public int blogID { get; set; }
    public string imageName { get; set; }
    public string imagePath { get; set; }

    public virtual Blog Blogs { get; set; }
}
}
