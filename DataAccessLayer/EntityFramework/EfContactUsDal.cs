using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        private Context _context;
        public EfContactUsDal(Context context) : base(context)
        {
            _context = context;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            var value = _context.ContactUses.Find(id);
            value.Status = false;
            _context.ContactUses.Update(value);
            _context.SaveChanges();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
           return _context.ContactUses.Where(c => c.Status == false).ToList();
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            return _context.ContactUses.Where(c => c.Status == true).ToList();
        }
    }
}
