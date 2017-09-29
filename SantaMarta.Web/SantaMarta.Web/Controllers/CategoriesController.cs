﻿using SantaMarta.Bussines.CategoriesBussines;
using SantaMarta.Bussines.SubCategoriesBussines;
using System.Linq;
using System.Web.Mvc;

namespace SantaMarta.Web.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesB categoriesB = new CategoriesB();
        SubCategoriesB subCategoriesB = new SubCategoriesB();
        // GET: Categories
        public ActionResult Index()
        {
            ViewBag.Categories = categoriesB.GetAll().ToList();
            ViewBag.SubCategories = subCategoriesB.GetAll().ToList();
            return View();
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
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

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categories/Edit/5
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

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categories/Delete/5
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
    }
}
