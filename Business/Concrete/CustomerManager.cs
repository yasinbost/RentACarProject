using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public  class CustomerManager : ICustomerServices
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Added(Customer customerDal)
        {
            _customerDal.Add(customerDal);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(Customer customerDal)
        {
            _customerDal.Delete(customerDal);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.UserListed);

        }

        public IDataResult<List<Customer>> GetById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(s => s.CustomerId == id));
        }

        public IResult Update(Customer customerDal)
        {
            _customerDal.Update(customerDal);
            return new SuccessResult(Messages.UserUpdated);

        }

     
    }
}

