using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCaNhan.Data.EF;
using BlogCaNhan.Data.Entities;

namespace BlogCaNhan.Controllers
{
    public class BlogController : Controller
    {
        BlogCaNhanDB db = new BlogCaNhanDB();
        public ActionResult Index()
        {
            var listDMBV = db.DanhMucBaiViets.ToList();
            ViewBag.lstmenu = listDMBV;
            var listDMBlog = db.DanhMucBlogs.ToList();
            ViewBag.listDMBlog = listDMBlog;
            var listBlog = db.Blogs.ToList();
            return View(listBlog);
        }
       [ValidateInput(false)]
       public JsonResult VietBlog(Blog blog,HttpPostedFileBase HinhAnh)
        {
           
            string result = "";
            try
            {
                //    List<string> ttuser = Session["User"] as List<string>;
                //    if (ttuser!= null || ttuser.Count > 0)
                //    {
                //        blog.userID = int.Parse(ttuser[0].ToString());
                //    }
                blog.userID = 1;
                blog.ngayTao = DateTime.Now;
                if (HinhAnh != null)
                {
                    if (HinhAnh.ContentLength > 0)
                    {
                        if (HinhAnh.ContentType != "image/jpeg" && HinhAnh.ContentType != "image/png" && HinhAnh.ContentType != "image/jpg")
                        {
                            result = "f,định dạng hình ảnh chưa hợp lệ (định dạng hợp lệ :jpeg/png/jpg)";
                        }
                        else
                        {
                            var fileName = HinhAnh.FileName;
                            var path = Path.Combine(Server.MapPath("~/Images/ImageBlog/"), fileName);
                            if (System.IO.File.Exists(path))
                            {
                                result = "t,Hình ảnh với tên như trên đã tồn tại!!";
                            }
                            else
                            {
                                HinhAnh.SaveAs(path);
                                
                            }
                            blog.imageBlog = fileName;
                            blog.imagePathBlog = "~/Images/ImageBlog/";
                        }

                    }
                }

                db.Blogs.Add(blog);

                if (db.SaveChanges() > 0)
                {
                    result = "t,Thêm blog mới thành công";
                }
                else result = "f,Đã có vấn đề xảy ra khi thêm mới";
            }
            catch(Exception ex)
            {
                result = "f,đã có lỗi xảy ra \n"+ex.Message;
            }
            
            return Json(result, JsonRequestBehavior.AllowGet);
        }

       
    }
}