﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserServices
    {
        IUserDal _userDal;

        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }
        public IResult Added(User user)
        {
             _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            
           return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);

        }

        public IDataResult<List<User>> GetById(int id)
        {
          return new SuccessDataResult<List<User>>(_userDal.GetAll(s => s.Id == id));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);

        }
    }
}
