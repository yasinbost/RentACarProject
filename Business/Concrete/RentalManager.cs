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
    public class RentalManager : IRentalServices
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.RentDate != null && rental.ReturnDate != null)
            {

                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);


            }
            else
            {
                return new SuccessResult(Messages.RentalNotAdded);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var result = _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(result, Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetById(int RentalId)
        {
            var result = _rentalDal.GetAll(s => s.RentalId == RentalId);
            return new SuccessDataResult<List<Rental>>(result);
        }



        public IDataResult<List<RentalDetailsDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailsDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
        public IDataResult<Rental> CheckCarAvailable(int id)
        {
            var carInfo = _rentalDal.Get(c => c.CarId == id);
            if (carInfo != null && carInfo.ReturnDate == null)
            {
                return new ErrorDataResult<Rental>(carInfo, Messages.RentalError);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == id));
        }
    }
}
