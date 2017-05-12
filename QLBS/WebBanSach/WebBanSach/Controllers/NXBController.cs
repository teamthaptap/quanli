using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.Models;

namespace WebBanSach.Controllers
{
    public class NXBController : Controller
    {
        QLBS125 db = new QLBS125();
        // GET: NXB
        public ActionResult SachTheoNXB(string PublisherId = "0")
        {
            Publisher pb = db.Publishers.SingleOrDefault(x => x.Id == PublisherId);
            List<Book> LBook = db.Books.Where(x => x.Publisher_Id == PublisherId).OrderBy(x => x.PriceNew).ToList();
            if (LBook.Count == 0)
            {
                ViewBag.Books = "Không có sách nào thuộc NXB này";
            }
            else
            {
                ViewBag.PublisherName = pb.Name;
                ViewBag.PublisherAddress = pb.Address;
            }
            return View(LBook);
        }
        public ActionResult NXBPartial()
        {
            return View();
        }
    }
}