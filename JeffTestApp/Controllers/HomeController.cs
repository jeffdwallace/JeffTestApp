using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JeffTestApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using JeffTestApp.Repository;

namespace JeffTestApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IGetGridRepository _getGridRepository { get; set; }
        public HomeController(IGetGridRepository getGridRepository)
        {
            _getGridRepository = getGridRepository;
        }

        public IActionResult Index()
        {
            var model = new GridViewModel();
            model.Items = _getGridRepository.GetGridData();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
