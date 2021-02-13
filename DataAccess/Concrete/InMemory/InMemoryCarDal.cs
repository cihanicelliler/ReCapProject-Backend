using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 20, DescriptionCar = "BMW", ModelYear = 2000 },
                new Car { Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 30, DescriptionCar = "Audi", ModelYear = 2005 },
                new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 50, DescriptionCar = "Opel", ModelYear = 1980 },
                new Car { Id = 4, BrandId = 1, ColorId = 2, DailyPrice = 40, DescriptionCar = "Nissan", ModelYear = 1970 }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.DescriptionCar = car.DescriptionCar;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
