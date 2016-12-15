using Course8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course8.Controllers
{
    //Exercise 1 - Course 8
    public class EvaluationController : Controller
    {
        // GET: Evaluation
        public ActionResult Index()
        {
            return View(ListOfProject);
        }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
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

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //Exercise 7 - Course 8
        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //Exercise 8 - Course 8
                // TODO: Add update logic here
                var evaluation = ListOfProject.Single(e => e.Id == id);
                if (TryUpdateModel(evaluation)) {
                    return RedirectToAction("Index");
                }
                return View(evaluation);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
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


        //Exercise 2 - Course 8
        public static List<ProjectEvaluation> ListOfProject = new List<ProjectEvaluation>() {
            new ProjectEvaluation() {
                Name="Florin",
                City="<script>alert('xss');</script>", // Exercise 2 - Course 8
                Country="Romania",
                Rating=8,
                Id = 45, //Exercise 7 - Course 8
                Description="Un text oarecare scris in graba!"
                

            }
        };
    }
}
