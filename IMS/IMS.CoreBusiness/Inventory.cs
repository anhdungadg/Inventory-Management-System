﻿using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string? InventoryName { get; set; } // this is somethings new in C# 10
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}