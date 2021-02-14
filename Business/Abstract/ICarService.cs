using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void AddCar(Car car);
        void DeleteCar(Car carId);
        void UpdateCar(Car carId);
        List<CarDetailDto> GetCarDetails();
    }
}
