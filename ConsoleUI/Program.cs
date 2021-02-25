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
            //Console.WriteLine("--------------------Car OP--------------------");

            CarManager carManager = new CarManager(new EfCarDal());

            ////Add operation
            //carManager.Add(new Car { BrandId = 6, ColorId = 4, ModelYear = 2019, DailyPrice = 100, Description = "spor model" });


            ////Delete operation
            //Car car1 = new Car { Id = 5, ColorId = 3, BrandId = 2, DailyPrice = 100, ModelYear = 2010, Description = "Benzin" };
            //carManager.Delete(car1);

            ////Update operation
            //Car car1 = new Car { Id = 5, ColorId = 3, BrandId = 2, DailyPrice = 100, ModelYear = 2019, Description = "spor model" };
            //carManager.Delete(car1);

            ////Hepsini listeleme
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.BrandId);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}

            ////Detaya göre listeleme

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelYear + " " + car.DailyPrice + " " + car.BrandName + " " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            
                
            

            //foreach (var car in carManager.GetCarsByBrandId(3))   // BrandId 'ye göre bak. BrandId'si 3 olanın ;
            //{
            //    Console.WriteLine(car.DailyPrice + " " + car.ModelYear + " " + car.Description);      // günlük fiyatını, model yılını ve fiyatını ver
            //}

            //Console.WriteLine("--------------------Brand OP--------------------");

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            ////Add operasyonu

            //Brand brand1 = new Brand { BrandName = "Subaru", Id = 20 };
            //brandManager.Add(brand1);

            //Brand brand2 = new Brand { BrandName = "Porsche", Id = 21 };
            //brandManager.Add(brand2);

            ////Delete Operasyonu
            //brandManager.Delete(brand2);

            ////Update operasyonu
            //Brand brand2 = new Brand { Id = 21, BrandName = "Aston Martin" };
            //brandManager.Update(brand2);

            ////Tümünü listele
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName + " " + brand.Id);
            //}

            ////Id 'ye göre getir
            //var brand = brandManager.GetById(2);        // Id'si 2 olan'ı brand değişkenine ata
            //Console.WriteLine(brand.BrandName);         // Id'si 2 olanın BrandName'ini yaz.

            //Console.WriteLine("--------------------Color OP--------------------");

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            ////Add operasyonu

            //Color color1 = new Color { Id = 7, ColorName = "Purple" };    // soru: vt tablosunda Id'yi oto artan veriyoruz. Burada neden Id yazımamız gerekiyor?
            //colorManager.Add(color1);                                    // çünkü Id parametresini vermezsem program hata dönüyor.

            //Color color2 = new Color { Id = 8, ColorName = "deneme" };
            //colorManager.Add(color2);

            ////Delete Operasyonu
            //colorManager.Delete(color2);

            ////Update Operasyonu
            //Color color2 = new Color { Id = 8, ColorName = "deneme++" };
            //colorManager.Update(color2);

            ////Tümünü listeleme
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Id + " " + color.ColorName);
            //}

            ////Id'ye göre listeleme

            //var color = colorManager.GetById(2);
            //Console.WriteLine(color.ColorName);






        }


    }
}
