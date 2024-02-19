using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbstractUOW
{
    public interface IGenericUOWService<T> where T : class
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TMultiUpdate(List<T> entities);
        T TGetById(int id);
    }
}
