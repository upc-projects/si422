using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infaestructura.Entities;
using Infaestructura.Repository;

namespace Infaestructura.RepositoryImpl
{
    public class ComprobanteRepositoryImpl:ComprobanteRepository
    {
        private FacturadorContext context;

        public ComprobanteRepositoryImpl()
        {
            context = new FacturadorContext();
        }

        public bool Save(Comprobante t)
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

        public List<Comprobante> FindAll()
        {
            return context.Comprobante.OrderByDescending(x => x.Creado).ToList();
        }

        public Comprobante FindById(int? id)
        {
            // Esta consulta incluye el detalle del comprobante, y el producto que tiene cada comprobante. Me refiero a sus relaciones
            return context.Comprobante.Include(x => x.ComprobanteDetalle.Select(y => y.Producto))
                .Where(x => x.id == id)
                .SingleOrDefault();
        }

        public bool Update(Comprobante t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Comprobante t)
        {
            throw new NotImplementedException();
        }

       
    }
}
