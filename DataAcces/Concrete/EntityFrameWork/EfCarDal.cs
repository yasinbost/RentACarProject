using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car,RentACarDbContext>, ICarDal
    {

        public List<CarDetailsDto> GetCarDetails()
        {

            using (RentACarDbContext context = new RentACarDbContext())
            {
                var result = from c in context.Cars     // cars ile brands tablolarını ortak olan brandıd ye göre join et
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new CarDetailsDto
                             {
                                 Id = c.CarId,
                                 BrandId = c.BrandId,
                                 BrandName = b.BrandName,
                                 CarName = b.BrandName,
                                 ColorId = c.ColorId,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice


                             };

                return result.ToList();
            }
        }
    }
}
