using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.DataBase;
using Shop.Services.DataBase;

namespace Shop.Controllers
{
    public class CatalogController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Catalog = LoadGoodsFromDataBase();
            return View();
        }

        private List<Goods> LoadGoodsFromDataBase()
        {
            List<Goods> catalog = new List<Goods>();
            using (ShopContext db = new ShopContext())
            {
                catalog = db.Goods.ToList();
            }

            return catalog;
        }

        private void ChangeAmount(int id, int amount)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Goods.FirstOrDefault(x => x.Id == id).Amount -= amount;
                db.SaveChanges();
            }
        }


        [HttpPost]
        public IActionResult Index(string amount, string ItemId)
        {
            ChangeAmount(Convert.ToInt32(ItemId), Convert.ToInt32(amount));
            ViewBag.Catalog = LoadGoodsFromDataBase();
            return View();
        }

    }
}