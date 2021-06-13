using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace computer_store_MVC.Dtos
{
    public class ComputerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter a Manufacturer")]
        [StringLength(255)]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "You must enter a Model")]
        [StringLength(255)]
        public string Model { get; set; }
        [Required(ErrorMessage = "You must enter a CPU model")]
        [StringLength(255)]
        public string CPU { get; set; }
        [Required(ErrorMessage = "You must enter Screen size")]
        [Range(1, int.MaxValue)]
        public int Screen { get; set; }
        [Required(ErrorMessage = "You must enter RAM")]
        [Range(1, int.MaxValue, ErrorMessage = "You Must enter a valid RAM value in GBs")]
        public int RAM { get; set; }
        [Required(ErrorMessage = "You must enter Storage")]
        [Range(1, int.MaxValue, ErrorMessage = "You Must enter a valid storage value in GBs")]
        public int Storage { get; set; }
        [Required(ErrorMessage = "You must enter Price")]
        [Range(1, int.MaxValue, ErrorMessage = "You Must enter a valid price value")]
        public int PriceILS { get; set; }
        [Url(ErrorMessage = "You must enter a valid URL")]
        public string ImageUrl { get; set; }
    }
}
