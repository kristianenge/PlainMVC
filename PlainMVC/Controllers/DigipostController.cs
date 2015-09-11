using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using PlainMVC.Models;
using PlainMVC.Services.Digipost;

namespace PlainMVC.Controllers
{
    public class DigipostController : Controller
    {
        // GET: Digipost
        public ActionResult Index()
        {
            return View();
        }

        // GET: Digipost/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Digipost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Digipost/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Digipost/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Digipost/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Digipost/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Digipost/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public  ActionResult Search(DigipostSearchModel searchModel)
        {
            var digipostService = new DigipostService();

            var result = digipostService.Search("kristian sæther enge oslo");
            



            //GetDummyData(searchModel);

            return View(searchModel);
        }


        [HttpGet]
        public ActionResult Search()
        {

            return View();
        }

        
        public ActionResult Send()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Send(SearchDetails s)
        //{
        //    return View();
        //}
    }
}
