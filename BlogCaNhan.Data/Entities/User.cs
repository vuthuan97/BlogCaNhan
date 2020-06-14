using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Entities
{
    public class User
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string nickName { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public int thanhVienID { get; set; }
        public string imageName { get; set; }
        public string imagePath { get; set; }
        public DateTime ngayDangKy { get; set; }



        public virtual ThanhVien ThanhViens { get; set; }
        public virtual List<BinhLuan> BinhLuans { get; set; }
        public virtual List<Blog> Blogs { get; set; }
        public virtual List<BaiViet> BaiViets{get;set;} 
             




    }
}
