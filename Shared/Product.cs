﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImagenUrl { get; set; } = string.Empty;
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
        public Category? Category{get; set;}
        public int Categoryid{get; set;}
    }
}
