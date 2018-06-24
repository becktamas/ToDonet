using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoAlkalmazas.Models;

namespace ToDoAlkalmazas.Controllers
{
    public class TodoController : Controller
    {
        [HttpGet, HttpPost]
        public ActionResult Index()
        {
            //Adatok

            //ViewBag.Lista = lista;

            return View(MyDb.Lista);
        }
        [HttpGet]// a routing csak ekkor irányítja ide
        public ActionResult Create()//Get
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                MyDb.Lista.Add(new TodoItem() { Name = Name, Done = true });
                //Adatok mentése és vissza az Index-re
                return RedirectToAction("Index");
            }
            return View();
        }
    }

}