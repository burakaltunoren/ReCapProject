using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(car.BrandId);
            }

            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car2 in carManager2.GetByDailyPrice(90, 180))
            {
                Console.WriteLine(car2.ModelYear);
            }


        }
    }
}
