using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{
   public interface IProductDal
    {
        List<Car> GetById(int carId);
        List<Car> GetAll();
      void Add(Car car); 
      void Update(Car car);
      void Delete(Car car); 

        



    }
}
