using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }

            
            CarManager carManager3 = new CarManager(new EfCarDal());
            carManager3.Add(new Car { BrandId = 11, ColorId = 7, ModelYear = 2020, DailyPrice = 180, Description = "Ticari" });






        }
    }
}
