using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infaestructura.Entities;
using System.Data.Entity;
using Infaestructura.Repository;

namespace Infaestructura.RepositoryImpl
{
    public class ProductRepositoryImpl : ProductRepository
    {
        private FacturadorContext context;

        public ProductRepositoryImpl()
        {
             context = new FacturadorContext();
        }

        public bool Delete(Producto t)
        {
            try
            {
                context.Entry(t).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Producto> FindAll()
        {
            return context.Producto.Include(c => c.Categoria).ToList();
        }

        public Producto FindById(int? id)
        {
            return context.Producto
              .Find(id);
        }

        

        public List<Producto> FindProductByNombre(string nombre)
        {
            var productos = context.Producto
                .OrderBy(x => x.Nombre)
                .Where(x => x.Nombre.Contains(nombre))
                .Take(10)
                .ToList();
            return productos;
        }

        public bool Save(Producto t)
        {
            try
            {
                context.Entry(t).State = EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Producto t)
        {
            try
            {
                context.Entry(t).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
