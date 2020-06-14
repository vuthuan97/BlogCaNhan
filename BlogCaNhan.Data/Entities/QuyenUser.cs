using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
   public class QuyenUser
    {
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public virtual List<PhanQuyenUser> PhanQuyenUsers { get; set; }
    }
}
