using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAcces.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDao _rentalDao;

        public RentalManager(IRentalDao rentalDao)
        {
            _rentalDao = rentalDao;
        }

        public IResult Add(Rental rental)
        {
            _rentalDao.Add(rental);
            return new SuccesResult(Message.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {

            _rentalDao.Delete(rental);
            return new SuccesResult(Message.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccesDataResult<List<Rental>>(_rentalDao.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccesDataResult<Rental>(_rentalDao.Get(r => r.Id == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDao.Update(rental);
            return new SuccesResult(Message.RentalUpdated);
        }
    }
}
