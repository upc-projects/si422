using Core.Service;
using Core.Serviceimpl;
using Infaestructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Net;

namespace Facturador.Controllers
{
    public class ProductoController : Controller
    {
        private ProductService productService ;

        private CategoriaService categoriaService;

        public ProductoController()
        {
            productService =new ProductServiceImpl();
            categoriaService=new CategoriaServiceImpl();
        }

        // GET: Producto        
        public ActionResult Index()
        {
            var productos = productService.FindAll();

            return View(productos.ToList());
        }

        public ActionResult Create()
        {
            
            ViewBag.CategoriaId = new SelectList(categoriaService.FindAll(), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                productService.Save(producto);
                return RedirectToAction("Index", "Producto");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public JsonResult BuscarProducto(string nombre)
        {
            return Json(productService.FindProductByNombre(nombre));
        }


        // GET: Productoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = productService.FindById(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }


        // GET: Productoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = productService.FindById(id);
            if (producto == null)
            {
                return HttpNotFound();
            }

            ViewBag.CategoriaId = new SelectList(categoriaService.FindAll(), "Id", "Nombre", producto.CategoriaId);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        [HttpPost]        
        public ActionResult Edit(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            productService.Update(producto);            
            ViewBag.CategoriaId = new SelectList(categoriaService.FindAll(), "Id", "Nombre", producto.CategoriaId);
            return RedirectToAction("Index", "Producto");
        }

        // GET: Productoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = productService.FindById(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]        
        public ActionResult DeleteConfirmed(int id)
        {
            Producto producto = productService.FindById(id);
            productService.Delete(producto);
            return RedirectToAction("Index", "Producto");
        }

    }
}