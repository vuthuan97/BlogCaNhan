using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    class DanhmucBlogConfiguration : EntityTypeConfiguration<DanhMucBlog>

    {
        public DanhmucBlogConfiguration()
        {
            this.ToTable("DanhmucBlog");
            this.HasKey(c => c.DMBlogID).Property(c=>c.DMBlogID).IsRequired();
            this.Property(c => c.tenDMBlog).HasMaxLength(200).IsOptional();
            this.Property(c => c.TagDMBlog).HasMaxLength(200).IsOptional();

            

        }
    }
}
