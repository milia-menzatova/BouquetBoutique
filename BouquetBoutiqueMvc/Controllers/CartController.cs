using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using BouquetBoutiqueMvc.Models;
using BouquetBoutiqueLibrary.Manager;
using BouquetBoutiqueLibrary.Model;
using BouquetBoutiqueMvc.Services;


namespace BouquetBoutiqueMvc.Controllers
{
    public class CartController : Controller
    {
        private readonly IBouquetManager bouquetManager;

        private readonly SessionCartService sessionCartService;
        public CartController(IBouquetManager bouquetManager,
            SessionCartService sessionCartService)
        {
            this.bouquetManager = bouquetManager;
            this.sessionCartService = sessionCartService;
        }

        public IActionResult Index()
        {
            ISession session = HttpContext.Session;
            CartViewModel cart = this.sessionCartService.GetCartFromSession(session);
            return View(cart);
        }

        [HttpPost]
        public IActionResult AddToCart(string bouquetId)
        {
            ISession session = HttpContext.Session;
            Bouquet bouquet = bouquetManager.GetBouquetById(bouquetId);
            this.sessionCartService.AddToSessionCart(session, bouquet);
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult RemoveItem(string bouquetId) 
        {
            ISession session = HttpContext.Session;
            Bouquet bouquet = this.bouquetManager.GetBouquetById(bouquetId);
            this.sessionCartService.RemoveItemFromSessionCart(session, bouquet);
            return RedirectToAction("Index", "Cart");
        }

    }
}