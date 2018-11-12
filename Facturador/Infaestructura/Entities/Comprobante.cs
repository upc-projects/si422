 namespace Infaestructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comprobante")]
    public class Comprobante
    {
        public Comprobante()
        {
            ComprobanteDetalle = new List<ComprobanteDetalle>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(300)]
        public string Cliente { get; set; }

        public decimal Total { get; set; }

        public DateTime Creado { get; set; }

        
        public List<ComprobanteDetalle> ComprobanteDetalle { get; set; }
    }
}
