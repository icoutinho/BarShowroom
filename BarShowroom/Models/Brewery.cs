using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarShowroom.Models
{
    public class Brewery
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public String Name { get; set; }
    }
}