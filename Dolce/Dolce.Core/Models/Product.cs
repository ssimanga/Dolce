﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolce.Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        [StringLength]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image;

        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

    }

}
