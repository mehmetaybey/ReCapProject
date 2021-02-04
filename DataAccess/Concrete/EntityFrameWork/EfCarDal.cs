using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapDal context =new ReCapDal())
            {
                var addedCar = context.Entry(entity);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapDal context = new ReCapDal())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDal context = new ReCapDal())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }


        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDal context = new ReCapDal())
            {
                     return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapDal context = new ReCapDal())
            {
                var updateCar = context.Entry(entity);
                updateCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
