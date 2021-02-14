using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join color in context.Color
                             on c.ColorId equals color.ColorId
                             select new CarDetailDto 
                             { 
                                 Id=c.Id,DescriptionCar=c.DescriptionCar,ColorName=color.ColorName,BrandName=b.BrandName,ModelYear=c.ModelYear,DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
