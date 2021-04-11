using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolioDemo.Context;
using MyPortfolioDemo.Models;
using MyPortfolioDemo.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortfolioRepository _portfolioRepository;

        public HomeController(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "به وب سایت شخصی احمدرضا رستمانی خوش آمدید.";
            ViewBag.Text = "این سایت به جهت معرفی بنده طراحی و پیاده سازی شده است.";
            return View(_portfolioRepository.GetPortfolios());
        }

        public IActionResult Contact()
        {
            ViewBag.Email = "rezarostamani.sru@gmail.com";
            ViewBag.Github = "github.com/rostamani";
            ViewBag.Mobile = "09389926212";
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
