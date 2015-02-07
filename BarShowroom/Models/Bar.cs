using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarShowroom.Models
{
    public class Bar
    {
        public int Id{ get; set; }

        [Required]
        [StringLength(64)]
        [BarExists(false)]
        public String Name { get; set; }

        [StringLength(256)]
        public String Address { get; set; }

        [Required]
        public String Cnpj { get; set; }
        public ICollection<Beer> Beers { get; set; }
    }
}