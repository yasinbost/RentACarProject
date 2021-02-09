using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarServices
    {
        ICarDal _CarDal;  // bağımlılığı ortadan kaldirmak için ICarDal oluşturduk.

        public CarManager ( ICarDal productDal)
        {
            _CarDal = productDal;
        }

        public void Added(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _CarDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi");
            }
            else {
                Console.WriteLine("lütfen günlük fiyati 0'dan büyük giriniz. Girilen Değer : {car.DailyPrice}");
            
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
            Console.WriteLine("Araba başarıyla silindi");
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }

        public List<Car> GetCarsBrandId(int id)
        {
            return _CarDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsColorId(int id)
        {
            return _CarDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _CarDal.Update(car);
            }
            else
            {
                Console.WriteLine($"lütfen günlük fiyati 0'dan büyük giriniz. Girilen Değer : {car.DailyPrice}");

            }
        }
    }
}
