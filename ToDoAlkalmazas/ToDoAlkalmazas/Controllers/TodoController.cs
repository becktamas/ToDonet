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
        private List<TodoItem> lista = new List<TodoItem>
            {
                new TodoItem() { Name = "Cukor", Done = true },
                new TodoItem() { Name = "Só", Done = false },
                new TodoItem() { Name = "Kávé", Done = false },
                new TodoItem() { Name = "Dió", Done = true }
            };

        public ActionResult Index()
        {
            //Adatok

            //ViewBag.Lista = lista;

            return View(lista);
        }
        public ActionResult Create(string Name)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                lista.Add(new TodoItem() { Name = Name, Done = true });
                //Adatok mentése és vissza az Index-re
                return RedirectToAction("Index");
            }
            return View();
        }
    }

}