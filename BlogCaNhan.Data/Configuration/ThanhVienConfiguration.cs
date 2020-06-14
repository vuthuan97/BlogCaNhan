using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    class ThanhVienConfiguration:EntityTypeConfiguration<ThanhVien>
    {
        public ThanhVienConfiguration()
        {
            this.ToTable("ThanhVien");
            this.HasKey(c => c.thanhvienID).Property(c=>c.thanhvienID).IsRequired();
            this.Property(c => c.loaiThanhVien).HasMaxLength(200).IsOptional();
        }
    }
}
