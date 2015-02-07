using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarShowroom.Models
{
    public class Beer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public String Name { get; set; }

        [Required]
        public double Price { get; set; }

        [BreweryExists(true)]
        public Brewery Brewery { get; set; }

        public ICollection<Bar> Bars{ get; set; }
    }
}