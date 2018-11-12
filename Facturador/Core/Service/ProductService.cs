using Infaestructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface ProductService:CrudService<Producto>
    {
       
        List<Producto> FindProductByNombre(string nombre);

    }
}
