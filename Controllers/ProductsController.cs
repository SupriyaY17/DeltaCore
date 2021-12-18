using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeltaCore.Models;

namespace DeltaCore.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult product()
        {
            var products = new List<ProductsService>()
            {
                new ProductsService { Id = 1001,Name = "Tools Gears" , Description = "Gear Tools production specification"},
                new ProductsService { Id = 2001,Name = "panels" , Description = "Switch Gear Panels"},
                new ProductsService { Id = 2008,Name = "DocTonar" , Description ="Document Solar Objects" }

            };
            return View(products);
        }
    }
}
