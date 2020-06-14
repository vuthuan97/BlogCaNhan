using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
    public class BaiViet
    {
        public int baivietID { get; set; }
        public string tieuDe { get; set; }
        public int userID { get; set; }
        public DateTime ngayTaobv { get; set; }
        public string noiDungBaiViet { get; set; }
        public string imageBaiViet { get; set; }
        public string imagePathBV { get; set; }
        public int DMBVID { get; set; }


        public virtual List<BinhLuan> BinhLuans { get; set; }
        public virtual User Users { get; set; }
        public virtual DanhMucBaiViet DanhMucBais { get; set; }


    }
}
