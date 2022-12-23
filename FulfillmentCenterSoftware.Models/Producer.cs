﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FulfillmentCenterSoftware.Models
{
    public class Producer
    {
        [Key] public int Id { get; set; }
        [Required] [MaxLength(100)] public string Name { get; set; } = null!;

        public string? Description { get; set; } 

        public virtual IEnumerable<Product> Products { get; set; } = new List<Product>();


    }
}
