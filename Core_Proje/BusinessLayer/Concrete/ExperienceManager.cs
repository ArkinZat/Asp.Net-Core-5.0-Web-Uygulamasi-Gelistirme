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
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public void Add(Experience item)
        {
            _experienceDal.Add(item);
        }

        public void Delete(Experience item)
        {
            _experienceDal.Delete(item);
        }

        public Experience GetByID(int id)
        {
           return _experienceDal.GetByID(id);
        }

        public List<Experience> GetList()
        {
            return _experienceDal.GetList();
        }

		public List<Experience> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Experience item)
        {
            _experienceDal.Update(item);
        }
    }
}
