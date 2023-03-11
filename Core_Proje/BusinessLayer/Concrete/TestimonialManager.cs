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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial item)
        {
            _testimonialDal.Add(item);
        }

        public void Delete(Testimonial item)
        {
            _testimonialDal.Delete(item);
        }

        public Testimonial GetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

		public List<Testimonial> GetListByFilter()
		{
			throw new NotImplementedException();
		}

		public void Update(Testimonial item)
        {
            _testimonialDal.Update(item);
        }
    }
}
