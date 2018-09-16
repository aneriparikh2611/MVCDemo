﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    [Table("Address")]
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }
        
        public string StreetNumber { get; set; }
        
        public string PostalCode { get; set; } 
    }
}