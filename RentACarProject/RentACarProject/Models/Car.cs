using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentACarProject.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        [Display(Name ="Marka")]
        public string Brand { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Model { get; set; }

        [MaxLength(300)]
        public string Image { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Mühərrik Həcmi")]
        public string EngineVolume { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Mühərrik Gücü")]
        public string HorsePower { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        [Display(Name ="Motor Tipi")]
        public string MotorType { get; set; }

        [Display(Name ="Buraxılış İli")]
        public string DateOfProduction { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Yürüş")]
        public string AmountOfMarch { get; set; }
    }
}