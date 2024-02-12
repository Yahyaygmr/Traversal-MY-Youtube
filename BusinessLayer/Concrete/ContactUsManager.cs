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
    public class ContactUsManager : IContactUsService
    {
        private readonly IDalManager _dalManager;

        public ContactUsManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            _dalManager.ContactUs.ContactUsStatusChangeToFalse(id);
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            return _dalManager.ContactUs.GetListContactUsByFalse();
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            return _dalManager.ContactUs.GetListContactUsByTrue();
        }

        public void TDelete(ContactUs entity)
        {
            _dalManager.ContactUs.Delete(entity);
        }

        public ContactUs TFindByCondition(Expression<Func<ContactUs, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            return _dalManager.ContactUs.GetById(id);
        }

        public List<ContactUs> TGetList()
        {
            return _dalManager.ContactUs.GetList();
        }

        public List<ContactUs> TGetListById(Expression<Func<ContactUs, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(ContactUs entity)
        {
            _dalManager.ContactUs.Insert(entity);
        }

        public void TUpdate(ContactUs entity)
        {
            _dalManager.ContactUs.Update(entity);
        }
    }
}
