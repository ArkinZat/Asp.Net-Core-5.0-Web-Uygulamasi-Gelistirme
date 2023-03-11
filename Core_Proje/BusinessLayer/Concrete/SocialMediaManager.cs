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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void Add(SocialMedia item)
        {
            _socialMediaDal.Add(item);
        }

        public void Delete(SocialMedia item)
        {
            _socialMediaDal.Delete(item);
        }

        public SocialMedia GetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public List<SocialMedia> GetList()
        {
            return _socialMediaDal.GetList();
        }

		public List<SocialMedia> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(SocialMedia item)
        {
            _socialMediaDal.Update(item);
        }
    }
}
