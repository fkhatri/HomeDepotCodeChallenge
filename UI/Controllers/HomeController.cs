using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _service;

        private readonly FactoryMethod _factoryMethod;

        public HomeController(IService service)
        {
            _service = service;
            _factoryMethod = new FactoryMethod();
        }

        public ActionResult Index()
        {
            var bandColors = _service.GetAllBandColors();
            var model = _factoryMethod.CreateHomeViewModel(bandColors);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(HomePageViewModels model)
        {
            var bandColors = _service.GetAllBandColors();
            var postmodel = _factoryMethod.CreateHomeViewModel(bandColors);
            if (!ModelState.IsValid)
            {
                return View(postmodel);
            }

            postmodel.Result = _service.CalculateResistor(model.SelectedBandA, model.SelectedBandB, model.SelectedBandC, model.SelectedBandD);

            return View(postmodel)
;        }
        
    }
}