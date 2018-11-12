using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Service;
using Core.Serviceimpl;
using Infaestructura.Entities;
using System.Net;

namespace Facturador.Controllers
{
    public class CategoriaController : Controller
    {

        private CategoriaService categoriaService;

        public CategoriaController()
        {
            categoriaService=new CategoriaServiceImpl();
        }
        // GET: Categoria
        public ActionResult Index()
        {
            var categorias = categoriaService.FindAll();
            return View(categorias);
        }


        public ActionResult Create()
        {
            return View(new Categoria());
        }


        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                categoriaService.Save(categoria);
                return RedirectToAction("Index", "Categoria");
            }
            catch (Exception)
            {
                return View();
            }
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = categoriaService.FindById(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }


        // GET: Categorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = categoriaService.FindById(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Categorias/Edit/5        
        [HttpPost]        
        public ActionResult Edit(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View();                
            }

            categoriaService.Update(categoria);
            return RedirectToAction("Index", "Categoria");
        }


        // GET: Categorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = categoriaService.FindById(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]       
        public ActionResult DeleteConfirmed(int id)
        {
            Categoria categoria = categoriaService.FindById(id);
            categoriaService.Delete(categoria);
            return RedirectToAction("Index", "Categoria");
        }


    }
}