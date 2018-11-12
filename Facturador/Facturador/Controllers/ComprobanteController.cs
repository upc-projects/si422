using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Service;
using Core.Serviceimpl;
using Facturador.ViewModel;

//https://docs.microsoft.com/es-es/dotnet/standard/base-types/standard-numeric-format-strings#example
namespace Facturador.Controllers
{
    public class ComprobanteController : Controller
    {
        private ComprobanteService comprobanteService;

        public ComprobanteController()
        {
            comprobanteService = new ComprobanteServiceImpl();
        }

        // GET: Comprobante
        public ActionResult Index()
        {
            return View(comprobanteService.FindAll());
        }


        public ActionResult Details(int id)
        {
            return View(comprobanteService.FindById(id));
        }


        public ActionResult Create()
        {
            return View(new ComprobanteViewModel());
        }

        [HttpPost]
        public ActionResult Create(ComprobanteViewModel model, string action)
        {
            if (action == "generar")
            {
                if (!string.IsNullOrEmpty(model.Cliente))
                {
                    if (comprobanteService.Save(model.ToModel()))
                    {
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("cliente", "Debe agregar un cliente para el comprobante");
                }
            }
            else if (action == "agregar_producto")
            {
                // Si no ha pasado nuestra validación, mostramos el mensaje personalizado de error
                if (!model.SeAgregoUnProductoValido())
                {
                    ModelState.AddModelError("producto_agregar", "Solo puede agregar un producto válido al detalle");
                }
                else if (model.ExisteEnDetalle(model.CabeceraProductoId))
                {
                    ModelState.AddModelError("producto_agregar", "El producto elegido ya existe en el detalle");
                }
                else
                {
                    model.AgregarItemADetalle();
                }
            }
            else if (action == "retirar_producto")
            {
                model.RetirarItemDeDetalle();
            }
            else
            {
                throw new Exception("Acción no definida ..");
            }

            return View(model);
        }
    }
}