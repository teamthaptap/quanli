using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class AuthController : Controller
    {
        QLBS db = new QLBS();
        // GET: Auth
        public ActionResult SachTheoTacgia(string AuthId = "0")
        {
            Auth au = db.Auths.SingleOrDefault(x => x.Id == AuthId);
            List<Book> LBook = db.Books.Where(x => x.Auth_Id == AuthId).OrderBy(x => x.PriceNew).ToList();
            if (LBook.Count == 0)
            {
                ViewBag.Books = "Không có sách nào thuộc Tác giả này";
            }
            else
            {
                ViewBag.AuthName = au.Name;
                ViewBag.AuthContent = au.Content;
            }
            return View(LBook);
        }
        public ActionResult TacgiaPartial()
        {
            return View();
        }
    }
}