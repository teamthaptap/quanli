using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopThaoMoc.Areas.Admin.Models.DAO;
using Model;



namespace ShopThaoMoc.Areas.Admin.Controllers
{
    public class QLTaiKhoanController : Controller
    {
        // GET: Admin/QLTaiKhoan
        public ActionResult DanhSachTK()
        {
            TaiKhoanDAO dao = new TaiKhoanDAO();
            IQueryable<NguoiDung> list = dao.getListTK();
            return View(list);
        }
    }
}