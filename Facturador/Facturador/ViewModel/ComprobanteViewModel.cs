using Infaestructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Facturador.ViewModel
{
    public class ComprobanteViewModel
    {
        #region Cabecera
        public string Cliente { get; set; }
        public int CabeceraProductoId { get; set; }
        public string CabeceraProductoNombre { get; set; }
        public int CabeceraProductoCantidad { get; set; }
        public decimal CabeceraProductoPrecio { get; set; }
        #endregion

        #region Contenido
        public List<ComprobanteDetalleViewModel> ComprobanteDetalle { get; set; }
        #endregion

        #region Pie
        public decimal Total()
        {
            return ComprobanteDetalle.Sum(x => x.Monto());
        }
        public DateTime Creado { get; set; }
        #endregion

        public ComprobanteViewModel()
        {
            ComprobanteDetalle = new List<ComprobanteDetalleViewModel>();
        }

        public bool SeAgregoUnProductoValido()
        {
            return !(CabeceraProductoId == 0 || string.IsNullOrEmpty(CabeceraProductoNombre) || CabeceraProductoCantidad == 0 || CabeceraProductoPrecio == 0);
        }

        public bool ExisteEnDetalle(int ProductoId)
        {
            return ComprobanteDetalle.Any(x => x.ProductoId == ProductoId);
        }

        public void RetirarItemDeDetalle()
        {
            if (ComprobanteDetalle.Count > 0)
            {
                var detalleARetirar = ComprobanteDetalle.Where(x => x.Retirar)
                    .SingleOrDefault();

                ComprobanteDetalle.Remove(detalleARetirar);
            }
        }

        public void AgregarItemADetalle()
        {
            ComprobanteDetalle.Add(new ComprobanteDetalleViewModel
            {
                ProductoId = CabeceraProductoId,
                ProductoNombre = CabeceraProductoNombre,
                PrecioUnitario = CabeceraProductoPrecio,
                Cantidad = CabeceraProductoCantidad,
            });
        }

        public Comprobante ToModel()
        {
            var comprobante = new Comprobante();
            comprobante.Cliente = this.Cliente;
            comprobante.Creado = DateTime.Now;
            comprobante.Total = this.Total();

            foreach (var d in ComprobanteDetalle)
            {
                comprobante.ComprobanteDetalle.Add(new ComprobanteDetalle
                {
                    ProductoId = d.ProductoId,
                    Monto = d.Monto(),
                    PrecioUnitario = d.PrecioUnitario,
                    Cantidad = d.Cantidad
                });
            }

            return comprobante;
        }

    }
}