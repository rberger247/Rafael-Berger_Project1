﻿using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantData
{
   public interface IDbContext
    {

        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();

    }
}
