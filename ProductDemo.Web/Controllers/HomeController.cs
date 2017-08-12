using ProductDemo.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepo;


        public HomeController(ICategoryRepository categoryRepository, IProductRepository productRepo)
        {
            _categoryRepository = categoryRepository;
            _productRepo=productRepo;
        }
        public ActionResult Index()
        {
            var catrgoryList = _productRepo.GetAll().ToList();
            return View(catrgoryList);
        }
    }
}