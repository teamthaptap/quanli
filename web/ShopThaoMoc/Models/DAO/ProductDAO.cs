using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace ShopThaoMoc.Models.DAO
{
    public class ProductDAO
    {
        ThaoMocShop dbShop = null;
        public ProductDAO()
        {
            dbShop = new ThaoMocShop();
        }
        public IQueryable<SanPham> getAllSanPham()
        {
            var rs = from sp in dbShop.SanPhams select sp;
            return rs;
        }
        public IQueryable<SanPham> getSlider()
        {
            var rs = from sp in dbShop.SanPhams.Take(4) select sp;
            return rs;
        }
        public IQueryable<SanPham> getAbout()
        {
            var rs = from sp in dbShop.SanPhams.Take(4) select sp;
            return rs;
        }
    }
}