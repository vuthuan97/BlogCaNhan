using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
   public  class PhanQuyenUser
    {
        public string MaQuyen { get; set; }
        public int thanhvienID { get; set; }
        public string ghiChu { get; set; }

        public virtual QuyenUser QuyenUsers { get; set; }
        public virtual ThanhVien ThanhViens { get; set; }
    }
}
