﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Event_App.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Display (Name = "Venue Name ")]
        public string Venue { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
