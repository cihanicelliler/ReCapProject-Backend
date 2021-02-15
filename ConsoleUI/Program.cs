using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId);
            }
            Console.WriteLine("Hello world!");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if(result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Id + " " + car.BrandName + " " + car.ColorName + " " + car.DescriptionCar + " " + car.ModelYear + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
