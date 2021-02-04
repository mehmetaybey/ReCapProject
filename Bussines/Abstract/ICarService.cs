using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICarService
    {
        
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetById(int id);
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
    }
}
