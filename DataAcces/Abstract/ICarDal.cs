using Core.DataAcces;
using DataAcces.Concrete.EntityFrameWork;
using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {

        List<CarDetailsDto> GetCarDetails();



    }

}