using Bussines.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using Bussines.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using Entity.Concrete;

namespace ConsoleUI
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                BrandManager brandManager = new BrandManager(new EfBrandDal());
                CarManager carManager = new CarManager(new EfCarDal());
                ColorManager colorManager = new ColorManager(new EfColorDal());

               foreach (var cars in carManager.GetCarDetails())
               {
                   Console.WriteLine(cars.CarName +"/"+ cars.BrandName + "/" + cars.DailyPrice + "//" +cars.ColorName);
               }

               //* foreach (var brands in brandManager.GetCarsByBrandId(2))
               // {
               //    Console.WriteLine(brands.BrandName + " Marka eklendi");
               // }*/

               // foreach (var colors in colorManager.GetAll())
               // {
               //     Console.WriteLine(colors.ColorName);
               // }

               // carManager.Add(new Car {BrandId = 3,ColorId = 8, DailyPrice = 775000, ModelYear = "1968", Description = "Camaro Coupe"});
                
               // brandManager.Add(new Brand{BrandName = "Chevrolet"});

               // colorManager.Add(new Color{ColorName = "Metalik Siyah"});

               

            }
        
    }
}
