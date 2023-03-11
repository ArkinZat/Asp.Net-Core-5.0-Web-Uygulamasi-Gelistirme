using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterMessageManager : IWriterMessageService
	{
		private readonly IWriterMessageDal _writerMessageDal;

		public WriterMessageManager(IWriterMessageDal writerMessageDal)
		{
			_writerMessageDal = writerMessageDal;
		}
		public void Add(WriterMessage item)
		{
			_writerMessageDal.Add(item);
		}

		public void Delete(WriterMessage item)
		{
			_writerMessageDal.Delete(item);
		}

		public WriterMessage GetByID(int id)
		{
			return _writerMessageDal.GetByID(id);
		}

		public List<WriterMessage> GetList()
		{
			return _writerMessageDal.GetList();
		}

		public List<WriterMessage> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public List<WriterMessage> GetListReceiverMessage(string p)
		{
			return _writerMessageDal.GetByFilter(x => x.Receiver == p);
		}

		public List<WriterMessage> GetListSenderMessage(string p)
		{
			return _writerMessageDal.GetByFilter(x => x.Sender == p);
		}

		public void Update(WriterMessage item)
		{
			_writerMessageDal.Update(item);
		}
	}
}
