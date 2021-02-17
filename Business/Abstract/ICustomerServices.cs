using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerServices
    {
        IResult Added(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<Customer >> GetAll();  // tüm listeyi verir.
        IDataResult<List<Customer >> GetById(int id);  // ıd ye göre getirir.
    }
}
