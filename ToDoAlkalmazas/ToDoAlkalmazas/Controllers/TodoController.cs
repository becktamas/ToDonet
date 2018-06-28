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
        Db db = new Db();
        //[HttpPost]
        public ActionResult Index()
        {
            //Adatok

            //ViewBag.Lista = lista;

            return View(db.TodoItems.ToList());
        }
        [HttpGet]// a routing csak ekkor irányítja ide
        public ActionResult Create()//Get
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name, bool isDone)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                //int maxId = MyDb.Lista.Max(x=>x.Id)+1;
                //MyDb.Lista.Add(new TodoItem() { Id = maxId, Name = Name, Done = isDone});
                db.TodoItems.Add(new TodoItem() { Name = Name, Done = isDone });
                //Adatbázisba kiírás
                db.SaveChanges();
                //Adatok mentése és vissza az Index-re
                return RedirectToAction("Index");
            }
            return View();
        }
        /// <summary>
        /// Az Action feladata az adott elem megjelenítése módosításra.
        /// Létező adatot módosítunk, azonosítani kell az elemet.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //MyDb.Lista.Where(x => x.Id == id);//Egy új listát gyárt
            var Item = db.TodoItems.Single(x => x.Id == id);//Pontosan egy ilyen elem van.
            //var Item = MyDb.Lista.SingleOrDefault(x => x.Id == id);//Ha nem biztos hogy pontosan egy ilyen elem van.
            //if (Item == null){}
            //ezt módosítjuk

            return View(Item);
        }
        [HttpPost]
        public ActionResult Edit(int id, string name, bool done)
        {
            var item = db.TodoItems.Single(x => x.Id == id);
            item.Done = done;
            item.Name = name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var Item = db.TodoItems.Single(x => x.Id == id);
            return View(Item);
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var Item = db.TodoItems.Single(x => x.Id == id);
            db.TodoItems.Remove(Item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var Item = db.TodoItems.Single(x => x.Id == id);
            return View(Item);
        }
    }

}