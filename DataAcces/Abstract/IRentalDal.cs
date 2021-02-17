using Core.DataAcces;

using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAcces.Abstract
{
     public interface IRentalDal : IEntityRepository<Rental>
    {

        List<RentalDetailsDto> GetRentalDetails();
    }

}
