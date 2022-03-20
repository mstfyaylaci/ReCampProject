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
    public class UserManager : IUserService
    {
        IUserDao _userDao;

        public UserManager(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public IResult Add(User user)
        {
            _userDao.Add(user);
            return new SuccesResult(Message.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDao.Delete(user);
            return new SuccesResult(Message.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccesDataResult<List<User>>(_userDao.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            
            return new SuccesDataResult<User>(_userDao.Get(u => u.UserId == id));
        }

        public IResult Update(User user)
        {
            _userDao.Update(user);
            return new SuccesResult(Message.UserUpdated);
        }
    }
}
