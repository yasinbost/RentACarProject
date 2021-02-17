using Business.Concrete;
using DataAcces.Concrete;
using DataAcces.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            RentalAdd(rentalManager);
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



        }
        private static void RentalAdd(RentalManager rentalManager)
        {

            rentalManager.Add(new Rental
            {
                CarId=5, CustomerId=2,

                RentDate = new DateTime(2021, 02, 13),
                ReturnDate = new DateTime(2021, 02, 15)
            });
        }
    }
}
