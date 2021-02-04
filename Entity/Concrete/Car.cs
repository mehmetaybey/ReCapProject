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
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        
    }
}
