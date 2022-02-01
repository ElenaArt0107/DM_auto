using DMAutoservice.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.DMAutoservice.Models.BrandModels;
using Presentation.DMAutoservice.Models.PersonModels;
using Services;
using System.Linq;

namespace Presentation.DMAutoservice.Controllers
{
    public class PersonController : Controller
    {
        private readonly IUserCarService _userCarService;
        private readonly IBrandService _brandService;
        private readonly IPersonService _personService;
        public PersonController(IUserCarService userCarService, IBrandService brandService, IPersonService personService)
        {
            _brandService = brandService;
            _personService = personService;
            _userCarService = userCarService;
        }

        public IActionResult Index()
        {
            var people = _personService.GetAllPeople();
            var model = people.Select(person => new PersonIndexViewModelItem
            {
                PersonId = person.Id,
                FullName = person.FullName,
                Cars = string.Join(", ", person.Brands.Select(c => c.BrandName))
            });

            return View(model);
        }

        public ActionResult Create()
        {
            var model = new PersonViewModel
            {
                Brands = _brandService
                        .GetBrandsSortedOnBrandNameDesc()
                        .Select(b => new BrandViewModel() { Id = b.Id, Name = b.BrandName })
                        .ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonViewModel model)
        {
            var brands = _brandService.GetBrandsSortedOnBrandNameDesc().Where(x => model.SelectedBrandIds.Contains(x.Id)).ToList();

            var newPerson = new Person()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                PhoneNumber = model.Phone,
                Brands = brands
            };

            _personService.CreatePerson(newPerson);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var person = _personService.GetPerson(id);

            if (person == null) { return RedirectToAction("Index"); }

            var model = new PersonViewModel
            {
                PersonId = person.Id,
                Name = person.Name,
                Surname = person.Surname,
                Email = person.Email,
                Phone = person.PhoneNumber,
                SelectedBrandIds = person.Brands.Select(x => x.Id).ToList(),
                Brands = _brandService
                            .GetBrandsSortedOnBrandNameDesc()
                            .Select(b => new BrandViewModel() { Id = b.Id, Name = b.BrandName })
                            .ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var person = _personService.GetPerson(model.PersonId);

            if (person is null)
            {
                return View(model);
            }

            var brands = _brandService.GetBrandsSortedOnBrandNameDesc().Where(x => model.SelectedBrandIds.Contains(x.Id)).ToList();

            person.Name = model.Name;
            person.Surname = model.Surname;
            person.Email = model.Email;
            person.PhoneNumber = model.Phone;
            person.Brands = brands;

            _personService.UpdatePerson(person);

            return RedirectToAction("Index");
        }

    }
}
