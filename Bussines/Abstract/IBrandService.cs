using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace Bussines.Abstract
{
    public interface IBrandService 
    {
        List<Brand> GetAll();
        List<Brand> GetCarsByBrandId(int id);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);

    }
}
