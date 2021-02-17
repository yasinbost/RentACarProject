using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserServices
    {
        IResult Added(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();  // tüm listeyi verir.
        IDataResult<List<User>> GetById(int id);  // ıd ye göre getirir.
       
        
    }
}
