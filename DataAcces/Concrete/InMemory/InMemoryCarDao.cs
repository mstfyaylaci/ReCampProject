using DataAcces.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDao : ICarDao
    {
        List<Car> _cars;
        public InMemoryCarDao()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,ColorId=1,BrandId=1,ModelYear="2020",DailyPrice=250,Description="Sedan"},
                new Car{CarId=2,ColorId=2,BrandId=3,ModelYear="2022",DailyPrice=250,Description="SUV"},
                new Car{CarId=3,ColorId=2,BrandId=2,ModelYear="2022",DailyPrice=250,Description="HatcBack"},
                new Car{CarId=4,ColorId=3,BrandId=2,ModelYear="2019",DailyPrice=250,Description="Spor"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = null;

            carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.CarId = car.CarId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
