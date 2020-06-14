using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
    public class Blog
    {
        public int blogID { get; set; }
        public int userID { get; set; }
        public string tieuDe { get; set; }
        public DateTime ngayTao { get; set; }
        public string noiDungBlog { get; set; }
        public string imageBlog { get; set; }
        public string imagePathBlog { get; set; }
        public string Tag { get; set; }
        public int DMBlogID { get; set; }
        public virtual User Users { get; set; }
        public virtual List<BinhLuan> BinhLuans { get; set; }
        public virtual List<ImageBlog> ImageBlogs { get; set; }
        public virtual DanhMucBlog DanhMucBlogs { get; set; }


    }
}
