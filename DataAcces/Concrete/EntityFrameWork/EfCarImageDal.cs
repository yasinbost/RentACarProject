using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFrameWork
{
   public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentACarDbContext>,ICarImageDal
    {


    }
}
