using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    public class BlogConfiguration : EntityTypeConfiguration<Blog>
    {
        public BlogConfiguration()
        {
            this.ToTable("Blog");
            this.HasKey(c => c.blogID).Property(c => c.blogID).IsRequired();
            this.Property(c => c.tieuDe).HasMaxLength(500).IsOptional();
            this.Property(c => c.ngayTao).HasColumnType("datetime").IsOptional();
            this.Property(c => c.imageBlog).HasMaxLength(200).IsOptional();
            this.Property(c => c.imagePathBlog).HasMaxLength(300).IsOptional();
            this.Property(c => c.Tag).HasMaxLength(200).IsOptional();
            this.Property(c => c.noiDungBlog).IsOptional();
            this.HasRequired<DanhMucBlog>(c => c.DanhMucBlogs).WithMany(c => c.Blogs).HasForeignKey(c => c.DMBlogID);
            this.HasMany<ImageBlog>(c => c.ImageBlogs).WithRequired(c => c.Blogs).HasForeignKey(c => c.blogID);
        }
    }
}
