using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAcces.Concrete.EntityFrameWork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDbContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails()
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             join u in context.Users on cu.UserId equals u.Id
                             select new RentalDetailsDto
                             {
                                 BrandName = b.BrandName,
                                 CarId = c.CarId,
                                 ColorName = clr.ColorName,
                                 CompanyName = cu.CompanyName,
                                 Description = c.Descriptions,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentalId = r.RentalId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };



                return result.ToList();
            }
        }
    }
}
