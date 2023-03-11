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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature item)
        {
            _featureDal.Add(item);
        }

        public void Delete(Feature item)
        {
            _featureDal.Delete(item);
        }

        public Feature GetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

		public List<Feature> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Feature item)
        {
            _featureDal.Update(item);
        }
    }
}
