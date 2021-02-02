using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcces.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAcces.Concrete
{
    public class InMemory : IProductDal
    {
        List<Car> _carList;
        public InMemory()
        {
            _carList = new List<Car>()
            {
                new Car{CarId=1,BrandId=1, DailyPrice=100000, Description=" Clio", ModelYear=2018},
                new Car{CarId=2,BrandId=1, DailyPrice=150000, Description=" Megan 3", ModelYear=2015},
                 new Car{CarId=3,BrandId=2, DailyPrice=200000, Description=" Passat", ModelYear=2020},
                  new Car{CarId=4,BrandId=2, DailyPrice=300000, Description=" Golf", ModelYear=2019},
                   new Car{CarId=5,BrandId=3, DailyPrice=250000, Description="C4", ModelYear=2018}

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

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetById(int carId)
        {
            return _carList.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
