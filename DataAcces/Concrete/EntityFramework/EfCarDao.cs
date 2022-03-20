using DataAcces.Abstract;
using Core.DataAcces.EntityFramework;
using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entites.DTOs;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfCarDao : EfEntityRepositoryBase<Car, RentACarContext>, ICarDao
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                
                                 BrandName=b.BrandName,
                                 ColorName=co.ColorName,
                                 DailyPrice= (short)c.DailyPrice,
                                 
                
                             };
                return result.ToList();
            }
        }
    }
}
