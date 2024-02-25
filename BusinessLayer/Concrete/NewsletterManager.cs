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
    
    public class NewsletterManager : INewsletterService
    {
        private readonly IDalManager _dalManager;

        public NewsletterManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

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
            return _dalManager.Newsletter.GetList();
        }

        public List<Newsletter> TGetListById(Expression<Func<Newsletter, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Newsletter entity)
        {
            _dalManager.Newsletter.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
            throw new NotImplementedException();
        }
    }
}
