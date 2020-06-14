using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
  public class DanhMucBaiVietConfiguration:EntityTypeConfiguration<DanhMucBaiViet>
    {
        public DanhMucBaiVietConfiguration()
        {
            this.ToTable("DanhMucBaiViet");
            this.HasKey(c => c.DMBVID).Property(c=>c.DMBVID).IsRequired();
            this.Property(c => c.TenDMBV).HasMaxLength(200).IsOptional();
            this.Property(c => c.TAGDMBV).HasMaxLength(300).IsOptional();
            this.HasMany<BaiViet>(c => c.BaiViets).WithRequired(c => c.DanhMucBais).HasForeignKey(c => c.DMBVID);
        }
    }
}
