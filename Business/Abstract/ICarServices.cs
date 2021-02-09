using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarServices
    {
        void Added(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();  // tüm listeyi verir.
        List<Car> GetCarsBrandId(int id);  // ıd ye göre getirir.
        List<Car> GetCarsColorId(int id);
        List<CarDetailsDto> GetCarDetails();


    }
}
