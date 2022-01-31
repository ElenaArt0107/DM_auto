using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using DMAutoservice.Domain.Models;
using Presentation.DMAutoservice.Models.UserCarModels;

namespace Presentation.DMAutoservice.Controllers
{
    public class UserCarController : Controller
    {
        // GET: UserPerCarController
        private readonly IUserCarService _userCarService;
        private readonly IBrandService _brandService;
        private readonly IPersonService _personService;
        public UserCarController(IUserCarService userCarService, IBrandService brandService, IPersonService personService)
        {
            _brandService = brandService;
            _personService = personService;
            _userCarService = userCarService;
        }
        public IActionResult Index()
        {
            var userCars = _userCarService.GetUserCarSortedOnPersonIdDsc(true);
            return View(userCars);
        }

        // GET: UserPerCarController/Details/5
        public ActionResult Details(int id)
        {
            var userCar = _userCarService.GetUserCar(id);
            return View(userCar);
        }

        // GET: UserPerCarController/Create
        public ActionResult Create()
        {
            var newPerson = new Person();
            
            CreateUserCarViewModel model = new CreateUserCarViewModel
            {
                BrandsForDropDown = _brandService.GetBrandsSortedOnBrandNameDesc(),
                Person = newPerson,

            };
            return View(model);
        }

        // POST: UserPerCarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateUserCarViewModel model)
        {
            var newPerson = new Person();
            _personService.CreatePerson(model.Person);

            if (!ModelState.IsValid)
            {
                model.BrandsForDropDown = _brandService.GetBrandsSortedOnBrandNameDesc();
                model.Person = newPerson;
                return View(model);
            }
            

            UserCar newUserCar = new UserCar
            {
                BrandId = model.BrandId, 
                PersonId = model.Person.Id
            };
            _userCarService.CreateUserCar(newUserCar);
            


            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserPerCarController/Edit/5
        public ActionResult Edit(int id)
        {
            var selectedUserCar = _userCarService.GetUserCar(id);
            var brandsForDropDown = _brandService.GetBrandsSortedOnBrandNameDesc();
            var model = new EditUserCarViewModel
            {
                UserCar = selectedUserCar,
                BrandsForDropDown = brandsForDropDown
            };
            return View(model);
        }

        // POST: UserPerCarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditUserCarViewModel model)
        {
            // var person2check = _personService.GetPerson(model.Person.ProperName);


            if (!ModelState.IsValid)
            {
                model.BrandsForDropDown = _brandService.GetBrandsSortedOnBrandNameDesc();
                return View(model);
            }

            //if (person2check is null)
            //{
            //    _personService.CreatePerson(model.Person);

            //}
            //else
            //{
            //    _personService.UpdatePerson(model.Person);
            //};

            //UserCar userCar2Update = _userCarService.GetUserCar(model.UserCarId);
            //userCar2Update.PersonId = model.Person.Id;
            //userCar2Update.BrandId = model.BrandId;



            _userCarService.UpdateUserCar(model.UserCar);

            return RedirectToAction("Index");
            }

        // GET: UserPerCarController/Delete/5
        public ActionResult Delete(int id)
        {
            var userCar = _userCarService.GetUserCar(id);
            return View(userCar);
        }

        // POST: UserPerCarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UserCar userCar)
        {
            _userCarService.DeleteUserCar(userCar.Id);
            return RedirectToAction("Index");

        }
    }
}
