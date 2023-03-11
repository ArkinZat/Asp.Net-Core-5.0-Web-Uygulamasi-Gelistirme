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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill item)
        {
            _skillDal.Add(item);
        }

        public void Delete(Skill item)
        {
            _skillDal.Delete(item);
        }

        public Skill GetByID(int id)
        {
            return _skillDal.GetByID(id);
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetList();
        }

		public List<Skill> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Skill item)
        {
            _skillDal.Update(item);
        }
    }
}
