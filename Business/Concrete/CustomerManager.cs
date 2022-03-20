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
    public class CustomerManager : ICustomerService
    {
        ICustomerDao _customerDao;

        public CustomerManager(ICustomerDao customerDao)
        {
            _customerDao = customerDao;
        }

        public IResult Add(Customer customer)
        {
            _customerDao.Add(customer);
            return new SuccesResult(Message.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDao.Delete(customer);

            return new SuccesResult(Message.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccesDataResult<List<Customer>>(_customerDao.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccesDataResult<Customer>(_customerDao.Get(c => c.Id == id));
        }

        public IResult Update(Customer customer)
        {
            _customerDao.Update(customer);

            return new SuccesResult(Message.CustomerUpdated);
        }
    }
}
