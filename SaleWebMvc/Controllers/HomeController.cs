using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebMvc.Models.ViewModels;

namespace SaleWebMvc.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Aplicação para estudo com foco no aprendizado em desenvolvimento ASP.NET.";
            ViewData["Email"] = "dusecolin@gmail.com";
            ViewData["Developer"] = "Eduardo Secolin.";
            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Email para contato.";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
