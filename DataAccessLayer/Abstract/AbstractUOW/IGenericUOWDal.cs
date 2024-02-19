using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.AbstractUOW
{
    public interface IGenericUOWDal<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void MultiUpdate(List<T> items);
        T GetById(int id);
    }
}
