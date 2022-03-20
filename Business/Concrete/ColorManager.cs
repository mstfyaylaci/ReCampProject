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
    public class ColorManager : IColorService
    {
        IColorDao _colorDao;
        public ColorManager(IColorDao colorDao)
        {
            _colorDao = colorDao;
        }
        public IResult Add(Color color)
        {
            _colorDao.Add(color);
            return new SuccesResult(Message.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            return new SuccesResult(Message.ColorDeleted);
        }

        public IResult Update(Color color)
        {
            return new SuccesResult(Message.ColorUpdated);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccesDataResult<List<Color>>(_colorDao.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccesDataResult<Color>(_colorDao.Get(c=>c.Id==id));
        }

        

       
    }
}
