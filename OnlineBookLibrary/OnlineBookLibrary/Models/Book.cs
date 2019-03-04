using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [StringLength(100)]
        [Required]
        [MinLength(2)]
        public string Author { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        [Required]
        [MinLength(10)]
        public string Details { get; set; }
    }
}