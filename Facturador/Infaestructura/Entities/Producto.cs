namespace Infaestructura.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public class Producto
    {
        
        public int id { get; set; }

        [Required(ErrorMessage = "Debe ingresar nombre")]
        [StringLength(300)]
        public string Nombre { get; set; }


        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        // [Range(0, 150, ErrorMessage = "Debe tener una edad entre 0 y 150 años")]
    }
}
