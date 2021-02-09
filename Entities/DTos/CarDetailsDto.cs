using Core.IDTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
   public class CarDetailsDto :IDTo
    {

        // Dto tablodaki verileri join etmek için kullanılır. buraya join ettikten sonra kullancağımız sutunlari yazariz. 

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }


    }
}
