using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnniesTeaShop.Models;
using AnniesTeaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AnniesTeaShop.Controllers
{
    public class TeaController : Controller
    {
        private readonly ITeaRepository _teaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TeaController(ITeaRepository teaRepository, ICategoryRepository categoryRepository)
        {
            _teaRepository = teaRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public ViewResult List()
        {
            TeaListViewModel teaListViewModel = new TeaListViewModel();
            teaListViewModel.Teas = _teaRepository.AllTeas;

            teaListViewModel.CurrentCategory = "Green teas";
            return View(teaListViewModel);
        }
        public IActionResult Details(int id)
        {
            var tea = _teaRepository.GetTeabyId(id);
            if (tea == null)
                return NotFound();
            return View(tea);
        }
    }
}