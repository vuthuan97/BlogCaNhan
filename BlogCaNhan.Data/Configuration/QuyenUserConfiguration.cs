using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    class QuyenUserConfiguration:EntityTypeConfiguration<QuyenUser>
    {
        public QuyenUserConfiguration()
        {
            this.ToTable("QuyenUser");
            this.HasKey(c => c.MaQuyen).Property(c=>c.MaQuyen).IsRequired();
            this.Property(c => c.TenQuyen).HasMaxLength(100).IsOptional();
        }
    }
}
