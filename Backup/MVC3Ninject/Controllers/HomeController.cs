using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3Ninject.Models;

namespace MVC3Ninject.Controllers
{
    public class HomeController : Controller
    {

        private IRepository myRepository;


        public HomeController(IRepository repository)
        {
            myRepository = repository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var result = myRepository.getCars();

            return View(result);
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cars newCar)
        {
            myRepository.addCar(newCar);
            return RedirectToAction("/index");
            
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            myRepository.removeCar(ID);
            return RedirectToAction("/Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var result = myRepository.getCarByID(ID);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Cars updatedCar)
        {
            myRepository.updateCar(updatedCar);
            return RedirectToAction("/index");
        }
    }
}
