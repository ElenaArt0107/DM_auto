using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.models;
using Microsoft.AspNetCore.Mvc;
using Presentatie.Website.Models.RekeningModels;
using Services;

namespace Presentatie.Website.Controllers
{
    public class RekeningController : Controller
    {
        private readonly IRekeningService _rekeningService;
        public RekeningController(IRekeningService rekeningService)
        {
            _rekeningService = rekeningService;
        }
        public IActionResult Index()
        {
            var rekeningen = _rekeningService.GetRekeningenSortedOnBalansDesc();
            return View(rekeningen);
        }

        public IActionResult Details(int id)
        {
            var rekening = _rekeningService.GetRekening(id);
            return View(rekening);
        }
        public IActionResult Create()
        {
            return View(new CreateRekeningViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreateRekeningViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var rekening = new Rekening
            {
                OpNaamVan = model.OpNaamVan,
                RekeningType = model.RekeningType,
                Balans = model.Balans
            };
            _rekeningService.CreateRekenig(rekening);
            //return Json(new { opNaamVan, rekeningType , balans });
            //return Json(new { model });
            return RedirectToAction("Index", "Rekening");
        }


        //public IActionResult Delete(int id)
        //{
        //    var rekening = _rekeningService.GetRekening(id);
        //    _rekeningService.DeleteRekening(rekening);
        //    return View(rekeningToUpdate);
        //}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var rekening = _rekeningService.GetRekening(id);

            var model = new EditRekeningViewModel
            {
                OpNaamVan = rekening.OpNaamVan,
                RekeningType = rekening.RekeningType,
                Balans = rekening.Balans
            };

            //_rekeningService.UpdateRekening(rekening);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditRekeningViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var rekeningToUpdate = _rekeningService.GetRekening(model.Id);

            rekeningToUpdate.OpNaamVan = model.OpNaamVan;
            rekeningToUpdate.RekeningType = model.RekeningType;
            rekeningToUpdate.Balans = model.Balans;


            _rekeningService.UpdateRekening(rekeningToUpdate);
            return RedirectToAction("Index", "Rekening");

        }

        public ActionResult Delete(int id)
        {
            var rekenin = _rekeningService.GetRekening(id);

            return View(rekenin);
        }

        [HttpPost]
        public ActionResult Delete(Rekening rekening)
        {
            _rekeningService.DeleteRekening(rekening.Id);

            return RedirectToAction("Index", "Rekening");
        }
    }
}
