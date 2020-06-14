use DbBlogCaNhan
go

insert into ThanhVien(loaiThanhVien) values(N'Admin')
insert into UserWeb(userName,password,nickName,thanhVienID) values(N'admin',N'admin','Admin','1')


insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Căn Bản',N'c-#-can-ban')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Nâng cao',N'c-#-nang-cao')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# & OPP',N'c-#-&-oop')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Với WINFORM',N'c-#-winform')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Với WPF',N'c-#-voi-wpf')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Với ASP.NET',N'c-#-voi-asp.net')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Với ASP.NET MVC',N'c-#-voi-asp.net-mvc')
insert into DanhMucBaiViet(TenDMBV,TAGDMBV) values(N'C# Với ASP.NET CORE MVC',N'c-#-voi-core-mvc')
go

insert into DanhMucBlog(TenDMBlog,TagDMBlog) values(N'Trải Nghiệm Cuộc Sống',N'trai-nghiem-cuoc-song')
insert into DanhMucBlog(TenDMBlog,TagDMBlog) values(N'Tôi Đi Tìm Việc',N'toi-di-tim-viec')
insert into DanhMucBlog(TenDMBlog,TagDMBlog) values(N'Du Lịch Và Tôi',N'du-lich-va-toi')
insert into DanhMucBlog(TenDMBlog,TagDMBlog) values(N'Khám Phá Kỹ Năng',N'kham-pha-ky-nang')
insert into DanhMucBlog(TenDMBlog,TagDMBlog) values(N'Kỹ Năng Lập Trình',N'Kỹ Năng Lập Trình')
go
select * from DanhmucBlog

select * from Blog