namespace Infaestructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComprobanteDetalle")]
    public class ComprobanteDetalle
    {
        public int id { get; set; }

        public int ComprobanteId { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Monto { get; set; }

        public  Comprobante Comprobante { get; set; }

        public  Producto Producto { get; set; }
    }
}
