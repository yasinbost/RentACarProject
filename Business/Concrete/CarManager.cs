using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Added(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _CarDal.Add(car);
                return new SuccessResult( Messages.CarAdded);
            }
            else {
                
                return new ErrorResult( Messages.CarPriceInvalid);
            }
            
        }

        public IResult Delete(Car car)
        {
            _CarDal.Delete(car);
            return new SuccessResult( Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_CarDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsById(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<Car>> GetCarsColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_CarDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _CarDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            else
            {
               
                return new ErrorResult( Messages.CarUpdatedInvalid);
            }
        }
    }
}
