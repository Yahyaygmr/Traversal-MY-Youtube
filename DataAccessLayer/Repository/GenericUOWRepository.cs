using DataAccessLayer.Abstract.AbstractUOW;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericUOWRepository<T> : IGenericUOWDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUOWRepository(Context context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T item)
        {
            _context.Add(item);
        }

        public void MultiUpdate(List<T> items)
        {
            _context.UpdateRange(items);
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }
}
