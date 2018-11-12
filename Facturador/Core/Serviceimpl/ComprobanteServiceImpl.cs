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
    public class ComprobanteServiceImpl:ComprobanteService
    {
        private ComprobanteRepository comprobanteRepository;
        public ComprobanteServiceImpl()
        {
            comprobanteRepository = new ComprobanteRepositoryImpl();
        }

        public bool Save(Comprobante t)
        {
            return comprobanteRepository.Save(t);
        }

        public List<Comprobante> FindAll()
        {
            return comprobanteRepository.FindAll();
        }

        public Comprobante FindById(int? id)
        {
            return comprobanteRepository.FindById(id);
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
