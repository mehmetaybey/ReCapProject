﻿using Bussines.Concrete;
using DataAccess.Concrete.InMemory;
using System;
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

                foreach (var cars in carManager.GetAll())
                {
                    Console.WriteLine(cars.CarId +" "+ cars.BrandId + " " + cars.ColorId + " " + cars.ModelYear + " " + cars.DailyPrice + " " + cars.Description);
                }

                foreach (var brands in brandManager.GetCarsByBrandId(1))
                {
                    Console.WriteLine(brands.BrandId + " Marka eklendi" );
                }

                foreach (var colors in colorManager.GetAll())
                {
                    Console.WriteLine(colors.ColorName);
                }

                carManager.Add(new Car {CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 55000, ModelYear = "1968", Description = "Camarro"});
                
                brandManager.Add(new Brand{BrandId = 10,BrandName = "Ford"});

                colorManager.Add(new Color{ColorId = 12,ColorName = "Metalik Siyah"});
             }
        
    }
}
