using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class Car :IEntity
    {
        
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public string ColorId { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
        
    }
}
