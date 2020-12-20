using CrazyCupCakeLady.Models;
using CrazyCupCakeLady.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyCupCakeLady.Controllers
{
    public class ProductControler : Controller
    {
        private IProductRepository _productRepo;
        public ProductControler(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }
        // GET: ProductControler
        public ActionResult Index()
        {
            List<Products> products = _productRepo.GetAllProducts();

            return View(products);
        }

        // GET: ProductControler/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductControler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductControler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductControler/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductControler/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductControler/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductControler/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
