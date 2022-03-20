using Core.Business;
using Core.Utilities.Result;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICarService:IBaseService<Car>
    {
        

        IDataResult<List<Car>> GetCarsByBrandId(int BrandId);

        IDataResult<List<Car>> GetCarsByColorId(int ColorId);

        IDataResult<List<CarDetailDto>> GetCarDetail();
       

    }
}
