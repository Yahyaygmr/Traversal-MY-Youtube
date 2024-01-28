using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly IDalManager _dalManager;

        public TestimonialManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public Testimonial TFindByCondition(Expression<Func<Testimonial, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _dalManager.Testimonial.GetList();
        }

        public List<Testimonial> TGetListById(Expression<Func<Testimonial, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
