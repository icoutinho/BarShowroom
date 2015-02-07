using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarShowroom.Models
{
    public class BeerBar
    {
        [BarExists(true)]
        [Required]
        public string Name { get; set; }
    }
}