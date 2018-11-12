using Infaestructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infaestructura.Repository
{
    public interface ProductRepository :CrudRepository<Producto>
    {
        List<Producto> FindProductByNombre(string nombre);
    }
}
