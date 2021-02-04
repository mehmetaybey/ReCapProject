using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        
            List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId="#000000", ModelYear=1965, DailyPrice=40000, Description="Shelby Mustang"},
                new Car{CarId=2, BrandId=1, ColorId="#1c1c1c", ModelYear=1957, DailyPrice=250000, Description="GWA Ferrari 340."},
                new Car{CarId=3, BrandId=2, ColorId="#1c0f45", ModelYear=1953, DailyPrice=25000, Description="Chevrolet Corvette."},
                new Car{CarId=4, BrandId=3, ColorId="#cd5555", ModelYear=1952, DailyPrice=50000, Description="Cadillac Eldorado."},
                new Car{CarId=5, BrandId=3, ColorId="#8b0000", ModelYear=1960, DailyPrice=350000, Description="Ford Mustang Elanor"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
