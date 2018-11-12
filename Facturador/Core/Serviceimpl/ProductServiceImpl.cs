using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infaestructura.Entities;
using Infaestructura.Repository;
using Infaestructura.RepositoryImpl;

namespace Core.Serviceimpl
{
    public class ProductServiceImpl : ProductService
    {
        private ProductRepository productRepository;
        public ProductServiceImpl()
        {
            productRepository =new ProductRepositoryImpl();
        }

        public List<Producto> FindAll()
        {
            return productRepository.FindAll();
        }

        public Producto FindById(int? id)
        {
            return productRepository.FindById(id);
        }

        public bool Save(Producto t)
        {
            return productRepository.Save(t);
        }

        public List<Producto> FindProductByNombre(string nombre)
        {
            return productRepository.FindProductByNombre(nombre);
        }

        public bool Update(Producto t)
        {
            return productRepository.Update(t);
        }

        public bool Delete(Producto t)
        {
            return productRepository.Delete(t);
        }
    }
}
