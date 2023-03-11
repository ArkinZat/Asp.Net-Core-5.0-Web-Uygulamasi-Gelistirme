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
    public class MessageManager : IMessageService
    {
		private readonly IMessageDal _messageDal;

		public MessageManager(IMessageDal messageDal)
		{
			_messageDal = messageDal;
		}

        public void Add(Message item)
        {
            _messageDal.Add(item);
        }

        public void Delete(Message item)
        {
            _messageDal.Delete(item);
        }

        public Message GetByID(int id)
        {
            return _messageDal.GetByID(id);
        }

        public List<Message> GetList()
        {
            return _messageDal.GetList();
        }

		public List<Message> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Message item)
        {
            throw new NotImplementedException();
        }
    }
}
