using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
    public class BinhLuan
    {
        public int binhLuanID { get; set; }
        public int userID { get; set; }
        public int blogID { get; set; }
        public int BaiVietID { get; set; }
        public DateTime thoigianBL { get; set; }
        public string noidungBL { get; set; }

        public virtual User Users { get; set; }
        public virtual Blog Blogs { get; set; }
        public virtual BaiViet BaiViets { get; set; }

    }
}
