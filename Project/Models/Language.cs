using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Language
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name required")]
        [StringLength(50, ErrorMessage = "Name: maximum length 50 symbols")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code required")]
        [StringLength(5, ErrorMessage = "Code: maximum length 5 symbols")]
        [Display(Name = "ISO 639-1 code")]
        public string Code { get; set; }
    }
}