using ProductDemo.Admin.ViewModel;
using ProductDemo.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductDemo.Admin.Controllers
{
    public class MainHomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;
        private readonly IProductImageRepository _productImageRepository;
        private readonly IProductFeatureRepository _productFeatureRepository;
        public MainHomeController(ICategoryRepository categoryRepository, IProductRepository productRepository,IProductImageRepository productImageRepository, IProductFeatureRepository productFeatureRepository)
        {
            _categoryRepository = categoryRepository;
            _productFeatureRepository = productFeatureRepository;
            _productImageRepository = productImageRepository;
            _productRepository = productRepository;
        }
        public ActionResult Index()
        {
            var pageModel = new HomePageModel
            {
                CategoryCount = _categoryRepository.Count(),
                ProductCount = _productRepository.Count(),
                ProductImageCoubt=_productImageRepository.Count(),
                ProductFeatureCount=_productFeatureRepository.Count()
            };


            

            return View(pageModel);
        }
    }
}