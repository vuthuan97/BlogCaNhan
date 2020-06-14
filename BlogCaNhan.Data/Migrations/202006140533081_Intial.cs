namespace BlogCaNhan.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaiViet",
                c => new
                    {
                        baivietID = c.Int(nullable: false, identity: true),
                        tieuDe = c.String(maxLength: 300),
                        userID = c.Int(nullable: false),
                        ngayTaobv = c.DateTime(),
                        noiDungBaiViet = c.String(),
                        imageBaiViet = c.String(maxLength: 200),
                        imagePathBV = c.String(maxLength: 300),
                        DMBVID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.baivietID)
                .ForeignKey("dbo.DanhMucBaiViet", t => t.DMBVID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID)
                .Index(t => t.DMBVID);
            
            CreateTable(
                "dbo.BinhLuan",
                c => new
                    {
                        binhLuanID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        blogID = c.Int(nullable: false),
                        BaiVietID = c.Int(nullable: false),
                        thoigianBL = c.DateTime(),
                        noidungBL = c.String(maxLength: 800),
                    })
                .PrimaryKey(t => t.binhLuanID)
                .ForeignKey("dbo.Blog", t => t.blogID, cascadeDelete: false)
                .ForeignKey("dbo.User", t => t.userID, cascadeDelete: true)
                .ForeignKey("dbo.BaiViet", t => t.BaiVietID, cascadeDelete: false)
                .Index(t => t.userID)
                .Index(t => t.blogID)
                .Index(t => t.BaiVietID);
            
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        blogID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        tieuDe = c.String(maxLength: 500),
                        ngayTao = c.DateTime(),
                        imageBlog = c.String(maxLength: 200),
                        imagePathBlog = c.String(maxLength: 300),
                        Tag = c.String(maxLength: 200),
                        DMBlogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.blogID)
                .ForeignKey("dbo.DanhmucBlog", t => t.DMBlogID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID)
                .Index(t => t.DMBlogID);
            
            CreateTable(
                "dbo.DanhmucBlog",
                c => new
                    {
                        DMBlogID = c.Int(nullable: false, identity: true),
                        tenDMBlog = c.String(maxLength: 200),
                        TagDMBlog = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DMBlogID);
            
            CreateTable(
                "dbo.ImageBlog",
                c => new
                    {
                        imageID = c.Int(nullable: false, identity: true),
                        blogID = c.Int(nullable: false),
                        imageName = c.String(maxLength: 200),
                        imagePath = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.imageID)
                .ForeignKey("dbo.Blog", t => t.blogID, cascadeDelete: true)
                .Index(t => t.blogID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        userID = c.Int(nullable: false, identity: true),
                        userName = c.String(maxLength: 100),
                        password = c.String(maxLength: 100),
                        nickName = c.String(maxLength: 100),
                        hoTen = c.String(maxLength: 200),
                        ngaySinh = c.DateTime(),
                        diaChi = c.String(maxLength: 300),
                        thanhVienID = c.Int(nullable: false),
                        imageName = c.String(maxLength: 200),
                        imagePath = c.String(maxLength: 200),
                        ngayDangKy = c.DateTime(),
                    })
                .PrimaryKey(t => t.userID)
                .ForeignKey("dbo.ThanhVien", t => t.thanhVienID, cascadeDelete: true)
                .Index(t => t.thanhVienID);
            
            CreateTable(
                "dbo.ThanhVien",
                c => new
                    {
                        thanhvienID = c.Int(nullable: false, identity: true),
                        loaiThanhVien = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.thanhvienID);
            
            CreateTable(
                "dbo.PhanQuyenThanhVien",
                c => new
                    {
                        MaQuyen = c.String(nullable: false, maxLength: 128),
                        thanhvienID = c.Int(nullable: false),
                        ghiChu = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => new { t.MaQuyen, t.thanhvienID })
                .ForeignKey("dbo.QuyenUser", t => t.MaQuyen, cascadeDelete: true)
                .ForeignKey("dbo.ThanhVien", t => t.thanhvienID, cascadeDelete: true)
                .Index(t => t.MaQuyen)
                .Index(t => t.thanhvienID);
            
            CreateTable(
                "dbo.QuyenUser",
                c => new
                    {
                        MaQuyen = c.String(nullable: false, maxLength: 128),
                        TenQuyen = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MaQuyen);
            
            CreateTable(
                "dbo.DanhMucBaiViet",
                c => new
                    {
                        DMBVID = c.Int(nullable: false, identity: true),
                        TenDMBV = c.String(maxLength: 200),
                        TAGDMBV = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.DMBVID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaiViet", "userID", "dbo.User");
            DropForeignKey("dbo.BaiViet", "DMBVID", "dbo.DanhMucBaiViet");
            DropForeignKey("dbo.BinhLuan", "BaiVietID", "dbo.BaiViet");
            DropForeignKey("dbo.BinhLuan", "userID", "dbo.User");
            DropForeignKey("dbo.BinhLuan", "blogID", "dbo.Blog");
            DropForeignKey("dbo.User", "thanhVienID", "dbo.ThanhVien");
            DropForeignKey("dbo.PhanQuyenThanhVien", "thanhvienID", "dbo.ThanhVien");
            DropForeignKey("dbo.PhanQuyenThanhVien", "MaQuyen", "dbo.QuyenUser");
            DropForeignKey("dbo.Blog", "userID", "dbo.User");
            DropForeignKey("dbo.ImageBlog", "blogID", "dbo.Blog");
            DropForeignKey("dbo.Blog", "DMBlogID", "dbo.DanhmucBlog");
            DropIndex("dbo.PhanQuyenThanhVien", new[] { "thanhvienID" });
            DropIndex("dbo.PhanQuyenThanhVien", new[] { "MaQuyen" });
            DropIndex("dbo.User", new[] { "thanhVienID" });
            DropIndex("dbo.ImageBlog", new[] { "blogID" });
            DropIndex("dbo.Blog", new[] { "DMBlogID" });
            DropIndex("dbo.Blog", new[] { "userID" });
            DropIndex("dbo.BinhLuan", new[] { "BaiVietID" });
            DropIndex("dbo.BinhLuan", new[] { "blogID" });
            DropIndex("dbo.BinhLuan", new[] { "userID" });
            DropIndex("dbo.BaiViet", new[] { "DMBVID" });
            DropIndex("dbo.BaiViet", new[] { "userID" });
            DropTable("dbo.DanhMucBaiViet");
            DropTable("dbo.QuyenUser");
            DropTable("dbo.PhanQuyenThanhVien");
            DropTable("dbo.ThanhVien");
            DropTable("dbo.User");
            DropTable("dbo.ImageBlog");
            DropTable("dbo.DanhmucBlog");
            DropTable("dbo.Blog");
            DropTable("dbo.BinhLuan");
            DropTable("dbo.BaiViet");
        }
    }
}
