using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
    public class DanhMucBaiViet
    {
        public int DMBVID { get; set; }
        public string TenDMBV { get; set; }
        public string TAGDMBV { get; set; }
        public virtual List<BaiViet> BaiViets { get; set; }

    }
}
