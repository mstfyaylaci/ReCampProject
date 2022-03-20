
using Core.DataAcces;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface ICarDao : IEntityRepository<Car>
    {

        public List<CarDetailDto> GetCarDetail();
    }
}
