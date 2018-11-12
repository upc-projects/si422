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
    public class CategoriaRepositoryImpl:CategoriaRepository
    {
        private FacturadorContext context;

        public CategoriaRepositoryImpl()
        {
            context = new FacturadorContext();
        }

        public bool Save(Categoria t)
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

        public List<Categoria> FindAll()
        {
            return context.Categoria.ToList();
        }

        public Categoria FindById(int? id)
        {
            return context.Categoria
              .Find(id);
              
        }

        public bool Update(Categoria t)
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

        public bool Delete(Categoria t)
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
    }
}
