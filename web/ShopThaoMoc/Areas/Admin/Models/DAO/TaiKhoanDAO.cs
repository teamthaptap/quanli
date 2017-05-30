using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopThaoMoc.Areas.Admin.Models.DAO;
using Model;
namespace ShopThaoMoc.Areas.Admin.Models.DAO
{
    public class TaiKhoanDAO
    {
        ThaoMocShop dbShop = null;
        public TaiKhoanDAO()
        {
            dbShop = new ThaoMocShop();
        }
        public IQueryable<NguoiDung> getListTK()
        {
            var rs = from tk in dbShop.NguoiDungs select tk;
            return rs;
        }
    }
}