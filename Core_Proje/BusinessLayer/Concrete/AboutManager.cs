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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void Add(About item)
        {
            _aboutDal.Add(item);
        }

        public void Delete(About item)
        {
            _aboutDal.Delete(item);
        }

        public About GetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public List<About> GetList()
        {
            return _aboutDal.GetList();
        }

		public List<About> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(About item)
        {
            _aboutDal.Update(item);
        }
    }
}
