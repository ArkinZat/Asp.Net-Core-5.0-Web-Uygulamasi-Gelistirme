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
	public class AnnouncementManager : IAnnouncementService
	{
		private readonly IAnnouncementDal _announcementDal;

		public AnnouncementManager(IAnnouncementDal announcementDal)
		{
			_announcementDal = announcementDal;
		}
		public void Add(Announcement item)
		{
			throw new NotImplementedException();
		}

		public void Delete(Announcement item)
		{
			throw new NotImplementedException();
		}

		public Announcement GetByID(int id)
		{
			return _announcementDal.GetByID(id);
		}

		public List<Announcement> GetList()
		{
			return _announcementDal.GetList();
		}

		public List<Announcement> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Announcement item)
		{
			throw new NotImplementedException();
		}
	}
}
