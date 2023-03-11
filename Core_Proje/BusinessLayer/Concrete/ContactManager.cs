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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Add(Contact item)
        {
            _contactDal.Add(item);
        }

        public void Delete(Contact item)
        {
            _contactDal.Delete(item);
        }

        public Contact GetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }

		public List<Contact> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Contact item)
        {
            _contactDal.Update(item);
        }
    }
}
