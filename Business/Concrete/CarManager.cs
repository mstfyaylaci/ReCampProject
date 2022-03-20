using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAcces.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDao _carDao;
        public CarManager(ICarDao carDao)
        {
            _carDao = carDao;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length<2 && car.DailyPrice<0)
            {
                return new  ErrorResult(Message.CarNameInvalid);
            }
            _carDao.Add(car);
            return new SuccesResult(Message.CarAdded);
        }

        public IResult Delete(Car car)
        {
           
            _carDao.Delete(car);
            return new SuccesResult(Message.CarDeleted);
        }


        public IResult Update(Car car)
        {
            _carDao.Update(car);

            return new SuccesResult(Message.CarUpdated);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==11)
            {
                return new ErrorDataResult<List<Car>>(Message.MaintenanceTime);
            }
            return new SuccesDataResult<List<Car>> (_carDao.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
        {
            return new SuccesDataResult<List<Car>>( _carDao.GetAll(c => c.BrandId == BrandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int ColorId)
        {
            return new SuccesDataResult<List<Car>>( _carDao.GetAll(c => c.ColorId == ColorId));
        }

        


        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDao.GetCarDetail());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccesDataResult<Car>(_carDao.Get(c => c.CarId == id));
        }
    }
}
