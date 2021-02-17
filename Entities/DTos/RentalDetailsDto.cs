﻿
using Core.IDTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
    public class RentalDetailsDto : IDTo
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}