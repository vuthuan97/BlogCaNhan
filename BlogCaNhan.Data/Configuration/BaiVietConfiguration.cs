using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    public class BaiVietConfiguration:EntityTypeConfiguration<BaiViet>
    {
        public BaiVietConfiguration()
        {
            this.ToTable("BaiViet");
            this.HasKey(c => c.baivietID).Property(c=>c.baivietID).IsRequired();
            this.Property(c => c.tieuDe).HasMaxLength(300).IsOptional();
            this.Property(c => c.ngayTaobv).HasColumnType("datetime").IsOptional();

            this.Property(c => c.imageBaiViet).HasMaxLength(200).IsOptional();
            this.Property(c => c.imagePathBV).HasMaxLength(300).IsOptional();

            this.HasRequired(c => c.Users).WithMany(c => c.BaiViets).HasForeignKey(c => c.userID);
            this.HasMany<BinhLuan>(c => c.BinhLuans).WithRequired(c => c.BaiViets).HasForeignKey(c => c.BaiVietID);


        }
    }
}
