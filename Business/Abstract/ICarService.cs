using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IResult AddCar(Car car);
        IResult DeleteCar(Car car);
        IResult UpdateCar(Car car);
        IDataResult<List<Car>> GetById(int carId);

        IDataResult<List<CarDetailDto2>> GetCarDetails(int id);
        IDataResult<List<CarDetailDto2>> GetCarDetails2();
        IResult AddTransactionalTest(Car car);
    }
}
