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
        public List<CarDetailDto2> GetCarDetailDtos2(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in filter == null ? context.Car : context.Car.Where(filter)
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join color in context.Color
                             on c.ColorId equals color.ColorId
                             join img in context.CarImages
                             on c.Id equals img.CarId
                             select new CarDetailDto2
                             {
                                 CarId = c.Id,
                                 ModelYear = c.ModelYear,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.DescriptionCar,
                                 ImagePath = img.ImagePath,
                                 FindexPoint = c.FindexPoint
                             };
                return result.ToList();
            }
        }
    }
}
