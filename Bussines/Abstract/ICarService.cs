using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
    }
}
