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
    public class ContactManager : IContactService
    {
        public void TDelete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact TFindByCondition(Expression<Func<Contact, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetListById(Expression<Func<Contact, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
