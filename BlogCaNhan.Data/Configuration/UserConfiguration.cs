using BlogCaNhan.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCaNhan.Data.Configuration
{
    class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.ToTable("UserWeb");
            this.HasKey(c => c.userID).Property(c=>c.userID).IsRequired();
            this.Property(c => c.userName).HasMaxLength(100).IsOptional();
            this.Property(c => c.password).HasMaxLength(100).IsOptional();
            this.Property(c => c.nickName).HasMaxLength(100).IsOptional();
            this.Property(c => c.hoTen).HasMaxLength(200).IsOptional();
            this.Property(c => c.ngayDangKy).HasColumnType("datetime").IsOptional();
            this.Property(c => c.diaChi).HasMaxLength(300).IsOptional();
            this.Property(c => c.imagePath).HasMaxLength(200).IsOptional();
            this.Property(c => c.imageName).HasMaxLength(200).IsOptional();
            this.Property(c => c.ngayDangKy).HasColumnType("datetime").IsOptional();


            this.HasRequired(c => c.ThanhViens).WithMany(c => c.Users).HasForeignKey(c => c.thanhVienID);
            this.HasMany<Blog>(c => c.Blogs).WithRequired(c => c.Users).HasForeignKey(c => c.userID);

        }
    }
}
