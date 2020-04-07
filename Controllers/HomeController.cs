using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnniesTeaShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnniesTeaShop.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ITeaRepository _teaRepository;
        private readonly IPieRepository _pieRepository;

        public HomeController(ITeaRepository teaRepository, IPieRepository pieRepository)
        {
            _teaRepository = teaRepository;
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                TeasOfTheWeek = _teaRepository.TeasOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
