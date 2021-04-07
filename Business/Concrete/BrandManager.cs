using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId));
        }

        public IResult AddBrand(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult();
        }
        public IResult DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult();
        }
        public IResult UpdateBrand(Brand brand)
        {
            IResult result = BusinessRules.Run(BrandExists(brand.BrandId));
            if (result != null)
            {
                return result;
            }
            _brandDal.Update(brand);
            return new SuccessResult();
        }

        private IResult BrandExists(int id)
        {
            if (_brandDal.Exists(b => b.BrandId == id))
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.ColorNotFound);
        }
    }
}
