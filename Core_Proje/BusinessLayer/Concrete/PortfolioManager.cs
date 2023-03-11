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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void Add(Portfolio item)
        {
            _portfolioDal.Add(item);
        }

        public void Delete(Portfolio item)
        {
            _portfolioDal.Delete(item);
        }

        public Portfolio GetByID(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public List<Portfolio> GetList()
        {
            return _portfolioDal.GetList();
        }

		public List<Portfolio> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Portfolio item)
        {
            _portfolioDal.Update(item);
        }
    }
}
