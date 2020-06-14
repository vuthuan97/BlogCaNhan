using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
   public class ThanhVien
    {
        public int thanhvienID { get; set; }
        public string loaiThanhVien { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<PhanQuyenUser> PhanQuyenUsers { get; set; }
    }
}
