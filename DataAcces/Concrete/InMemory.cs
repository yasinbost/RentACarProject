using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAcces.Abstract;

using Entities.Concrete;
using Entities.DTos;

namespace DataAcces.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _carList;
        public InMemory()
        {
            _carList = new List<Car>()
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100000, Descriptions=" Clio", ModelYear="2018"},
                new Car{CarId=2,BrandId=1,ColorId=2, DailyPrice=150000, Descriptions=" Megan 3", ModelYear="2015"},
                 new Car{CarId=3,BrandId=2, ColorId=3,DailyPrice=200000, Descriptions=" Passat", ModelYear="2020"},
                  new Car{CarId=4,BrandId=2, ColorId=2,DailyPrice=300000, Descriptions=" Golf", ModelYear="2019"},
                   new Car{CarId=5,BrandId=3,ColorId=3, DailyPrice=250000, Descriptions="C4", ModelYear="2018"}

            };
        }


        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            _carList.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _carList.Where(p => p.CarId == carId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
