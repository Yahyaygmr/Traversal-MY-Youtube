﻿using DataAccessLayer.Abstract;
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
    public class EfFeature1Dal : GenericRepository<Feature1>, IFeature1Dal
    {
        public EfFeature1Dal(Context context) : base(context)
        {
        }
    }
}
