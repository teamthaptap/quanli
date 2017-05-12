using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;



namespace WebBanSach.Controllers
{
    public class HomeController : Controller
    {
        QLBS125 db = new QLBS125();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
       [ChildActionOnly]
        public ActionResult TopMenuPartial()
        {
            return PartialView(db.Menus.Where(x=> x.ParentId=="Menu00").ToList());
        }

        public ActionResult Wishlish()
        {
            return View(db.Books.Where(x=>x.GroupBook_Id=="GB0001").Take(3).ToList());
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection f)
        {
            string sTaikhoan = f["Taikhoan"].ToString();
            string sMatkhau = f["Password"].ToString();
            User us = db.Users.SingleOrDefault(x => x.UserName == sTaikhoan && x.PassWord == sMatkhau);
            if(us != null)
            {
                ViewBag.Thongbao = "Đăng nhập thành công!";
                Session["Taikhoan"] = us;
                return View();
            }
            ViewBag.Thongbao = "Tài khoản hoặc Mật khẩu không đúng !";
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User us)
        {
            //Chèn dữ liệu vào bảng
            db.Users.Add(us);
            //Lưu
            db.SaveChanges();
            ViewBag.Thongbao = "Đăng ký thành công!!";
            return View();
        }
         public ActionResult Shipping()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

    }
}