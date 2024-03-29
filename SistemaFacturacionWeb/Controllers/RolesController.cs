﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaFacturacionWeb.Models;

namespace SistemaFacturacionWeb.Controllers
{
    public class RolesController : Controller
    {
        private facturacionEntities db = new facturacionEntities();

        // GET: Roles
        public ActionResult Index()
        {
            return View(db.AspNetRoles.ToList());
        }

        // GET: Roles/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            if (aspNetRoles == null)
            {
                return RedirectToAction("Error");
            }
            return View(aspNetRoles);
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] AspNetRoles aspNetRoles)
        {
            if (ModelState.IsValid)
            {
                db.AspNetRoles.Add(aspNetRoles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aspNetRoles);
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            if (aspNetRoles == null)
            {
                return RedirectToAction("Error");
            }
            return View(aspNetRoles);
        }

        // POST: Roles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] AspNetRoles aspNetRoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aspNetRoles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aspNetRoles);
        }

        // GET: Roles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            if (aspNetRoles == null)
            {
                return RedirectToAction("Error");
            }
            return View(aspNetRoles);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AspNetRoles aspNetRoles = db.AspNetRoles.Find(id);
            db.AspNetRoles.Remove(aspNetRoles);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
