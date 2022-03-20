﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
    }
}
