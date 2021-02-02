using Business.Concrete;
using DataAcces.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine("Araba Adi : {0}" +
                    " Modeli : {1} " +
                    "fiyati : {2} ",car.Description,car.ModelYear,car.DailyPrice);
            };
            



        }
    }
}
