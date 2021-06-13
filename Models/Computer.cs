using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace computer_store_MVC.Models
{
    public class Computer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(255)]
        public string Model { get; set; }
        [Required]
        [StringLength(255)]
        public string CPU { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int RAM { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int Storage { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int PriceILS { get; set; }
        [Url]
        public string ImageUrl { get; set; }

        public Computer() { }

        public Computer(int id, string manufacturer, string model, string cPU, int rAM, int storage, int priceILS, string imageUrl)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            CPU = cPU;
            RAM = rAM;
            Storage = storage;
            PriceILS = priceILS;
            ImageUrl = imageUrl;
        }

    }
}
