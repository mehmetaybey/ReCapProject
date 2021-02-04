using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace Bussines.Abstract
{
   public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetCarsByColorId(int id);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
