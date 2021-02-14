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

            //Car car1 = new Car() { BrandId=1, ColorId=3, DailyPrice= 450, Descriptions=" Dizel Otomatik", ModelYear= "2019"};
            //Brand brand1 = new Brand() { 
            //BrandName="Mazda"};
            //Brand brand2 = new Brand() { BrandName="aa"};

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Id +" " + car.CarName +" " + car.ColorName + " " + car.DailyPrice);
            }

            

          


        }
    }
}
