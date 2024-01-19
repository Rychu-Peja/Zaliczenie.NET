﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-5")]
        [Range(1, 1000)]
        public double Price { get; set; }
        

        [Required]
        [Display(Name = "Price for 5+")]
        [Range(1, 1000)]
        public double Price5 { get; set; }
        //zmienione z price50
        //price100 usuniete



    }
}