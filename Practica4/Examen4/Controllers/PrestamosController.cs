using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practica4.Models;
using System.Net;
using System.Data;
using System.IO;
using System.Web.Helpers;
using System.Collections;

namespace practica4.Controllers
{
    public class PrestamosController : Controller
    {
        #region Contexto
        private LibraryEntities _contexto;
        public LibraryEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new LibraryEntities();
                return _contexto;
            }
        }
        #endregion
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Prestamos nuevoPrestamo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Prestamos.Add(nuevoPrestamo);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevoPrestamo);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestamos PrestamoEditar = Contexto.Prestamos.Find(id);
            if (PrestamoEditar == null)
            {
                return HttpNotFound();
            }

            return View(PrestamoEditar);
        }

        [HttpPost]
        public ActionResult Edit(Prestamos PrestamoEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(PrestamoEditar).State = System.Data.Entity.EntityState.Modified;
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(PrestamoEditar);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prestamos PrestamoEliminar = Contexto.Prestamos.Find(id);
            if (PrestamoEliminar == null)
            {
                return HttpNotFound();
            }
            return View(PrestamoEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Prestamos Categoria1)
        {
            try
            {
                Prestamos PrestamoEliminar = new Prestamos();
                if (ModelState.IsValid)
                {
                    if (id == null)
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    PrestamoEliminar = Contexto.Prestamos.Find(id);
                    if (PrestamoEliminar == null)
                    {
                        return HttpNotFound();
                    }
                    Contexto.Prestamos.Remove(PrestamoEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(PrestamoEliminar);
            }
            catch
            {
                return View();
            }
        }
    }
}