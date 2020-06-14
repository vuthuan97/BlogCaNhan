using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
   public class DanhMucBlog
    {
        public int DMBlogID { get; set; }
        public string tenDMBlog { get; set; }
        public string TagDMBlog { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
