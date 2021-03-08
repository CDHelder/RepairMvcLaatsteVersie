using System;
using System.Collections.Generic;
using System.Text;
using RepairMvc.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace RepairMvc.Domain.Models
{
    public enum PartType
    {
        Cpu,
        Motherboard,
        Memory,
        Graphic_Card,
        Storage,
        Power_Supply,
        Software,
        RepairOrder,
        Misc
    }

    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Part Type")]
        public PartType PartType { get; set; }
        public string Description { get; set; }     // overbodig???

        [Required]
        [Display(Name = "Part Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public ICollection<Stock> Stock { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}