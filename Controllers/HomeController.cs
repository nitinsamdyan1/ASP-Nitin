using lab5_10_.Models;
using lab5_10_.Data.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace lab5_10_.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataAccess dataAccess;

        public HomeController(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            List<YourModel> data = dataAccess.GetData();
            return View(data);
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
