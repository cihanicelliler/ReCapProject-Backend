using Business.Abstract;
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

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void AddBrand(Brand brand)
        {
            _brandDal.Add(brand);
        }
        public void DeleteBrand(Brand brand)
        {
            _brandDal.Delete(brand);
        }
        public void UpdateBrand(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
