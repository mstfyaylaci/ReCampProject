using DataAcces.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;                                                                                                                                               
using Microsoft.EntityFrameworkCore;
using Core.DataAcces.EntityFramework;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfColorDao : EfEntityRepositoryBase<Color,RentACarContext> ,IColorDao
    {
       
    }
}
