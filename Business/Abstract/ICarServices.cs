using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarServices
    {
        IResult Added(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();  // tüm listeyi verir.
        IDataResult<List<Car>> GetCarsBrandId(int id);  // ıd ye göre getirir.
        IDataResult<List<Car>> GetCarsColorId(int id);
        IDataResult<List<Car>> GetCarsById(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails();


    }
}
