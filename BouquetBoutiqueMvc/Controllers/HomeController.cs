using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BouquetBoutiqueMvc.Models;
using BouquetBoutiqueLibrary.Manager;

using BouquetBoutiqueLibrary.Model;

namespace BouquetBoutiqueMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBouquetManager bouquetManager;

        public HomeController(IBouquetManager bouquetManager)
        {
            this.bouquetManager = bouquetManager;
        }

        public IActionResult Index()
        {
            ICollection<Bouquet> bouquets = bouquetManager.GetAll();
            return View(bouquets);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
