using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class TheLoaiController : Controller
    {
        QLBS125 db = new QLBS125();
        // GET: TheLoai
        public ActionResult TheLoaiPartial()
        {
            return PartialView(db.Books.Where(x=>x.GroupBook_Id == "GB0002").Take(4).OrderBy(x=>x.PriceNew).ToList());
        }
        public ViewResult SachTheoTheLoai(string GroupBookId = "0")
        {
            GroupBook gr = db.GroupBooks.SingleOrDefault(x => x.Id == GroupBookId);
            if (gr==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Book> LBook = db.Books.Where(x => x.GroupBook_Id == GroupBookId).OrderBy(x => x.PriceNew).ToList();
            if(LBook.Count==0)
            {
                ViewBag.Books = "không có sách nào thuộc thể loại này";
            }
            else
            {
                ViewBag.Books = gr.Name;
            }
            return View(LBook);
        }
    }
}