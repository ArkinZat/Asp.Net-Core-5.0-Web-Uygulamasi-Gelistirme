using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void Add(Service item)
        {
            _serviceDal.Add(item);
        }

        public void Delete(Service item)
        {
            _serviceDal.Delete(item);
        }

        public Service GetByID(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

		public List<Service> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Service item)
        {
            _serviceDal.Update(item);
        }
    }
}
