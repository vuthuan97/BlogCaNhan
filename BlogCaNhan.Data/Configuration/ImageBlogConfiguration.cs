using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    class ImageBlogConfiguration:EntityTypeConfiguration<ImageBlog>
    {
        public ImageBlogConfiguration()
        {
            this.ToTable("ImageBlog");
            this.HasKey(c => c.imageID).Property(c=>c.imageID).IsRequired();
            this.Property(c => c.imageName).HasMaxLength(200).IsOptional();
            this.Property(c => c.imagePath).HasMaxLength(200).IsOptional();
        }
    }
}
