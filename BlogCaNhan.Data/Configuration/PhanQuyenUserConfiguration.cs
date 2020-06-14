using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    class PhanQuyenUserConfiguration:EntityTypeConfiguration<PhanQuyenUser>
    {
        public PhanQuyenUserConfiguration()
        {
            this.ToTable("PhanQuyenThanhVien");
            this.HasKey(c => new { c.MaQuyen, c.thanhvienID });
            this.Property(c => c.ghiChu).HasMaxLength(200).IsOptional();
            this.HasRequired(c => c.QuyenUsers).WithMany(c => c.PhanQuyenUsers).HasForeignKey(c => c.MaQuyen);
            this.HasRequired(c => c.ThanhViens).WithMany(c => c.PhanQuyenUsers).HasForeignKey(c => c.thanhvienID);
        }
    }
}
