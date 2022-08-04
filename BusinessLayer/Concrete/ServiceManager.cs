using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager :IServiceService
    {
        private IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void Add(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

        public Service GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
