using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
      public interface  IRentalServices
    {

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();  // tüm listeyi verir.
        IDataResult<List<Rental>> GetById(int rentalid);  // ıd ye göre getirir.
        IDataResult<List<RentalDetailsDto>> GetRentalDetails();
        IDataResult<Rental> CheckCarAvailable(int id);
    }
}
