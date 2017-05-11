using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class SanPhamController : Controller
    {
        QLBS db = new QLBS();
        // GET: SanPham

        public ViewResult XemChiTiet(string BookID="0")
        {
            Book book = db.Books.SingleOrDefault(x => x.Id == BookID);
            if(book==null)
            {
                //trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }
            return View(book);
        }

        [ChildActionOnly]
        public PartialViewResult SachBanChayPartial()
        {          
              return PartialView(db.Books.Take(4).ToList());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
    }
}