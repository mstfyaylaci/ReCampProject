﻿using Core.DataAcces;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
   public interface ICustomerDao:IEntityRepository<Customer>
    {
    }
}
