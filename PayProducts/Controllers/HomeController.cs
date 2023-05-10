using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PayProducts.Models;
using PayProducts.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PayProducts.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _products;

        public HomeController(IProducts products)
        {
            _products = products;
        }
        public ViewResult Index()
        {

            HomeIndexViewModels viewModel = new HomeIndexViewModels
            {
                products = _products.GetAll()
            };
            return View(viewModel);
        }

        public ViewResult GetProductInfo()
        {
            HomeIndexViewModels model = new HomeIndexViewModels
            {
               getproductsInfo = _products.Get(1)
            };
           return View(model);
        }
        

    }
}
