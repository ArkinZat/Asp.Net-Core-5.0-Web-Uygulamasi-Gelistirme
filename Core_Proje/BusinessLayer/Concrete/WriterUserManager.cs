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
	public class WriterUserManager : IWriterUserService
	{
		private readonly IWriterUserDal _writerUserDal;

		public WriterUserManager(IWriterUserDal writerUserDal)
		{
			_writerUserDal = writerUserDal;
		}
		public void Add(WriterUser item)
		{
			_writerUserDal.Add(item);
		}

		public void Delete(WriterUser item)
		{
			_writerUserDal.Delete(item);
		}

		public WriterUser GetByID(int id)
		{
			return _writerUserDal.GetByID(id);
		}

		public List<WriterUser> GetList()
		{
			return _writerUserDal.GetList();
		}

		public List<WriterUser> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(WriterUser item)
		{
			_writerUserDal.Update(item);
		}
	}
}
