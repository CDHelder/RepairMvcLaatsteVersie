using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepairMvc.Domain.Models
{
    public enum Status
    {
        On_Hold,
        Under_Repair,
        Waiting_for_parts,
        Done
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string OrderRef { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }

        [Required]
        [Display(Name = "Status")]
        public Status? Status { get; set; }

        [Required(ErrorMessage = "Hours worked input is required")]
        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }

        [Required(ErrorMessage = "Begin date is required")]
        [Display(Name = "Begin Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Repair order description is required")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        [Display(Name = "Work Report")]
        public string WorkReport { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }

        //~~~~~~~~ All Parts ~~~~~~~~
        //Part 1
        [Display(Name = "Part 1")]
        public Product Part1 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID1 { get; set; }
        [Display(Name = "Quantity Part 1")]
        public int Part1Quantity { get; set; }
        //Part 2
        [Display(Name = "Part 2")]
        public Product Part2 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID2 { get; set; }
        [Display(Name = "Quantity Part 2")]
        public int Part2Quantity { get; set; }
        //Part 3
        [Display(Name = "Part 3")]
        public Product Part3 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID3 { get; set; }
        [Display(Name = "Quantity Part 3")]
        public int Part3Quantity { get; set; }
        //Part 4
        [Display(Name = "Part 4")]
        public Product Part4 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID4 { get; set; }
        [Display(Name = "Quantity Part 4")]
        public int Part4Quantity { get; set; }
        //Part 5
        [Display(Name = "Part 5")]
        public Product Part5 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID5 { get; set; }
        [Display(Name = "Quantity Part 5")]
        public int Part5Quantity { get; set; }
        //Part 6
        [Display(Name = "Part 6")]
        public Product Part6 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID6 { get; set; }
        [Display(Name = "Quantity Part 6")]
        public int Part6Quantity { get; set; }
        //Part 7
        [Display(Name = "Part 7")]
        public Product Part7 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID7 { get; set; }
        [Display(Name = "Quantity Part 7")]
        public int Part7Quantity { get; set; }
        //Part 8
        [Display(Name = "Part 8")]
        public Product Part8 { get; set; }
        [ForeignKey("ProductId")]
        public int? PartID8 { get; set; }
        [Display(Name = "Quantity Part 8")]
        public int Part8Quantity { get; set; }
    }
}
