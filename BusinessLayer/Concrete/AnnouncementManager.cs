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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IDalManager _dalManager;

        public AnnouncementManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(Announcement entity)
        {
            _dalManager.Announcement.Delete(entity);
        }

        public Announcement TFindByCondition(Expression<Func<Announcement, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetById(int id)
        {
            return _dalManager.Announcement.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _dalManager.Announcement.GetList();
        }

        public List<Announcement> TGetListById(Expression<Func<Announcement, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Announcement entity)
        {
            _dalManager.Announcement.Insert(entity);
        }

        public void TUpdate(Announcement entity)
        {
            _dalManager.Announcement.Update(entity);
        }
    }
}
