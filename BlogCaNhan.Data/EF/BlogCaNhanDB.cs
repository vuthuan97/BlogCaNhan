using BlogCaNhan.Data.Configuration;
using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.EF
{
    public class BlogCaNhanDB:DbContext
    {
        public BlogCaNhanDB():base("name=EFcodefirst")
        {

        }
        public DbSet<BaiViet> BaiViets { get; set; }
        public DbSet<BinhLuan> BinhLuans { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<DanhMucBaiViet> DanhMucBaiViets { get; set; }
        public DbSet<DanhMucBlog> DanhMucBlogs { get; set; }
        public DbSet<ImageBlog> ImageBlogs { get; set; }
        public DbSet<ThanhVien> ThanhViens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<QuyenUser> QuyenUsers { get; set; }
        public DbSet<PhanQuyenUser> PhanQuyenUsers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BaiVietConfiguration());
            modelBuilder.Configurations.Add(new BinhLuanConfiguration());
            modelBuilder.Configurations.Add(new BlogConfiguration());
            modelBuilder.Configurations.Add(new DanhmucBlogConfiguration());
            modelBuilder.Configurations.Add(new DanhMucBaiVietConfiguration());
            modelBuilder.Configurations.Add(new ImageBlogConfiguration());
            modelBuilder.Configurations.Add(new ThanhVienConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new QuyenUserConfiguration());
            modelBuilder.Configurations.Add(new PhanQuyenUserConfiguration());

        }
    }
}
