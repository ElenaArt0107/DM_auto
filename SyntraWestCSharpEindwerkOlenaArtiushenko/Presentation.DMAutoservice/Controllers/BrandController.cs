using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.DMAutoservice.Models;
using Presentation.DMAutoservice.Models.BrandModels;
using Services;
using System;

namespace Presentation.DMAutoservice.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IPersonService _personService;
        public BrandController(IBrandService brandService, IPersonService personService)
        {
            _brandService = brandService;
            _personService = personService;
        }
        public IActionResult Index()
        {
            var brands = _brandService.GetBrandsSortedOnBrandNameDesc();
            return View(brands);
        }

        public ActionResult Details(int id)
        {
            var brand = _brandService.GetBrand(id);

            return View(brand);
        }


        public ActionResult Edit(int id)
        {
            var brand = _brandService.GetBrand(id);

            return View(brand);
        }

        [HttpPost]
        public ActionResult Edit(Brand brand)
        {

            _brandService.UpdateBrand(brand);

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            var newBrand = new Brand();

            var model = new BrandCreateViewModel
            {
                Brand = newBrand
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(BrandCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _brandService.CreateBrand(model.Brand);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var brand = _brandService.GetBrand(id);

            return View(brand);
        }

        [HttpPost]
        public ActionResult Delete(Brand brand )
        {
            _brandService.DeleteBrand(brand.Id);

            return RedirectToAction("Index");
        }
    }
}
