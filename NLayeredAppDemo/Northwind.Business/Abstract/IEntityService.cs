﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;
namespace Northwind.Business.Abstract
{
    public interface IEntityService<T> where T : class, IEntity,new()
    {
        List<T> GetAll();
    }
}
