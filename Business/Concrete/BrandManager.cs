using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandServices
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Added(Brand brand)
        {
            if (brand.BrandName.Length > 2 )
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
            else {
                return new ErrorResult(Messages.BrandNameInvalid);
            }

            
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Brand>>( Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(),Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                return new SuccessResult( Messages.BrandUpdated);
            }
            else
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
        }
    }
}
