using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    public class BinhLuanConfiguration:EntityTypeConfiguration<BinhLuan>
    {
        public BinhLuanConfiguration()
        {
            this.ToTable("BinhLuan");
            this.HasKey(c => c.binhLuanID).Property(c=>c.binhLuanID).IsRequired();
            this.Property(c => c.thoigianBL).HasColumnType("datetime").IsOptional();
            this.Property(c => c.noidungBL).HasMaxLength(800).IsOptional();


            this.HasRequired(c => c.Users).WithMany(c => c.BinhLuans).HasForeignKey(c => c.userID);
            this.HasRequired(c => c.Blogs).WithMany(c => c.BinhLuans).HasForeignKey(c => c.blogID);
           
        }
    }
}
