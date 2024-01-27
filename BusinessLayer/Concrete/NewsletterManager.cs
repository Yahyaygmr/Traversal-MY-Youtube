using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        public void TDelete(Newsletter entity)
        {
            throw new NotImplementedException();
        }

        public Newsletter TFindByCondition(Expression<Func<Newsletter, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Newsletter TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Newsletter> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Newsletter entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Newsletter entity)
        {
            throw new NotImplementedException();
        }
    }
}
