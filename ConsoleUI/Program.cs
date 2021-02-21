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
            //Console.WriteLine("-----------------CAR OPERASYONLARI-----------------"); 

            //CarManager carManager = new CarManager(new EfCarDal());
            //////İş kuralını geçemeyecek şekilde ekleme: Kural: Description bilgisinin 2 karakterden fazla olma şartı
            ////carManager.Add(new Car { Id = 20, BrandId = 2, ColorId = 5, ModelYear = 2021, DailyPrice = 175, Description = "a" });

            //////İş kuralını geçeyecek şekilde ekleme
            //carManager.Add(new Car { BrandId = 4, ColorId = 8, ModelYear = 2021, DailyPrice = 142, Description = "Spor" });

            //////Araç Silme

            ////Car car1 = new Car { Id = 2003, BrandId = 4, ColorId = 8, ModelYear = 2021, DailyPrice = 142, Description = "Spor" };
            ////carManager.Delete(car1);
            ////Console.WriteLine("işlem başarılı");

            //////Update
            //Car car2 = new Car { Id = 3, BrandId = 3, ColorId = 4, ModelYear = 2012, DailyPrice = 110, Description = "Dizel++" };
            //carManager.Update(car2);

            //////Detaya göre listeleme
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Id No'su " + car.Id + " olan " + car.ModelYear + " model " + car.BrandName + " marka aracın günlük fiyatı " + car.DailyPrice + " TL'dir. Araç Rengi: " + car.ColorName);
            //}

            ////foreach (var car in carManager.GetCarDetails())
            ////{
            ////    Console.WriteLine(car.DailyPrice);
            ////}

            //foreach (var car in carManager.GetCarsByCarId(3))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}

            //foreach (var car in carManager.GetCarsByBrandId(3))
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}

            Console.WriteLine("-------------BRAND OPERASYONLARI-------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}

            brandManager.GetById(2);
            Console.WriteLine(brandManager.GetById(2).BrandName);



        }


    }
}
