using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Service;
using Infaestructura.Entities;
using Infaestructura.Repository;
using Infaestructura.RepositoryImpl;

namespace Core.Serviceimpl
{
    public class CategoriaServiceImpl:CategoriaService
    {
        private CategoriaRepository categoriaRepository;

        public CategoriaServiceImpl()
        {
            categoriaRepository=new CategoriaRepositoryImpl();
        }

        public bool Save(Categoria t)
        {
            return categoriaRepository.Save(t);
        }

        public List<Categoria> FindAll()
        {
            return categoriaRepository.FindAll();
        }

        public Categoria FindById(int? id)
        {
            return categoriaRepository.FindById(id);
        }

        public bool Update(Categoria t)
        {
            return categoriaRepository.Update(t);
        }

        public bool Delete(Categoria t)
        {
            return categoriaRepository.Delete(t);
        }
    }
}
