using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_Pattern_Repository.Interfaces;
using Crud_Pattern_Repository.Models;
using Crud_Pattern_Repository.Services;
using Crud_Pattern_Repository.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Pattern_Repository.Controllers
{
    public class ProductController : Controller
    {
        private IBaseService<Product> _service;

        public ProductController(IBaseService<Product> service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var List = await _service.FindAllAsync();
            return View(List);
        }
        public IActionResult Create()
        {
            var viewmodel = new ProductViewModel();
            return View(viewmodel);
        }
       [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new ProductViewModel { Product = product };
                return View(viewmodel);
            }            

            await _service.InsertAsync(product);
            return RedirectToAction(nameof(Index));
        }
    }
}