using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using ShopThaoMoc.Models.DAO;

namespace ShopThaoMoc.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            ProductDAO spDAO = new ProductDAO();
            IQueryable<SanPham> list = spDAO.getAllSanPham();
            //return View(spDAO.getAllSanPham());
            return View(list);
        }
        public PartialViewResult SliderPartial()
        {
            ProductDAO spDAO = new ProductDAO();
            return PartialView(spDAO.getSlider());
        }
        public PartialViewResult AboutPartial()
        {
            ProductDAO spDAO = new ProductDAO();
            return PartialView(spDAO.getAbout());
        }
        
    }
}