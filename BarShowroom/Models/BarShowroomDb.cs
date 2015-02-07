using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BarShowroom.Models
{
    public class BarShowroomDb : DbContext
    {
        public BarShowroomDb() :base("name=DefaultConnection")
        {

        }

        public DbSet<Bar> Bars { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Beer> Beers { get; set; }
    }
}