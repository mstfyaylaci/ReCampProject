using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfBrandDao : EfEntityRepositoryBase<Brand,RentACarContext>,IBrandDao
    {
       
    }
}
