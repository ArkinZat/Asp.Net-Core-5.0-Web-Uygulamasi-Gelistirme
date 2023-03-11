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
	public class ToDoListManager : IToDoListService
	{
		private readonly IToDoListDal _toDoListDal;

		public ToDoListManager(IToDoListDal toDoListDal)
		{
			_toDoListDal = toDoListDal;
		}
		public void Add(ToDoList item)
		{
			_toDoListDal.Add(item);
		}

		public void Delete(ToDoList item)
		{
			_toDoListDal.Delete(item);
		}

		public ToDoList GetByID(int id)
		{
			return _toDoListDal.GetByID(id);
		}

		public List<ToDoList> GetList()
		{
			return _toDoListDal.GetList();
		}

		public List<ToDoList> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(ToDoList item)
		{
			_toDoListDal.Update(item);
		}
	}
}
