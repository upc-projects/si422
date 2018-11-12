using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//http://www.jiodev.com/aspnet/mvc/getting-started/mvc-5/adding-search
//http://www.tutorialsteacher.com/mvc/viewdata-in-asp.net-mvc
//https://www.codeproject.com/Tips/883701/An-ASP-NET-MVC-Cascading-Dropdown-List
//https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application
//https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application
//http://anexsoft.com/p/82/asp-net-mvc-insertando-actualizando-con-relaciones-de-mucho-a-mucho
//http://www.puntonetalpunto.net/2013/10/validaciones-con-dataannotations.html
namespace Infaestructura.Entities
{
    [Table("Categoria")]
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Nombre { get; set; }
        
    }
}
