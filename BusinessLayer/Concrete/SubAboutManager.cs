﻿using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        public void TDelete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout TFindByCondition(Expression<Func<SubAbout, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
