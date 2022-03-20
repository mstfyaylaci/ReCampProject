using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
   public class EfUserDao:EfEntityRepositoryBase<User,RentACarContext>,IUserDao
    {
    }
}
