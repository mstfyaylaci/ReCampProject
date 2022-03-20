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
    public class BrandManager : IBrandService
    {
        IBrandDao _brandDao;

        public BrandManager(IBrandDao brandDao)
        {
            _brandDao = brandDao;
        }
        public IResult Add(Brand brand)
        {
            return new SuccesResult(Message.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccesResult(Message.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            return new SuccesResult(Message.BrandUpdated);
        }
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccesDataResult<List<Brand>>(_brandDao.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccesDataResult<Brand>(_brandDao.Get(b => b.Id == id));
        }

       
    }
}
