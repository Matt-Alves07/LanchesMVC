using LanchesMVC.Models;
using LanchesMVC.Repositories.Interfaces;
using LanchesMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanchesMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILanchesRepository _lancheRepository;
        public HomeController(ILanchesRepository lanchesRepository)
        {
            _lancheRepository = lanchesRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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