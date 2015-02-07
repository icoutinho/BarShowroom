namespace BarShowroom.Migrations
{
    using BarShowroom.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BarShowroom.Models.BarShowroomDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BarShowroom.Models.BarShowroomDb context)
        {
            //  This method will be called after migrating to the latest version.

            context.Database.ExecuteSqlCommand("DELETE FROM BeerBars");
            context.Database.ExecuteSqlCommand("DELETE FROM Beers");
            context.Database.ExecuteSqlCommand("DELETE FROM Breweries");
            context.Database.ExecuteSqlCommand("DELETE FROM Bars");

            context.Breweries.AddOrUpdate(br => br.Name,
                new Brewery { Name = "Heineken"},
                new Brewery { Name = "Stella Artois" },
                new Brewery { Name = "Colorado" },
                new Brewery { Name = "Sudbrack" },
                new Brewery { Name = "Petrópolis" });

            context.SaveChanges();

            context.Beers.AddOrUpdate(be => be.Name,
                new Beer { Name = "Heineken", Brewery = context.Breweries.Single(s=>s.Name == "Heineken"), Price = 7.50 },
                new Beer { Name = "Amstel", Brewery = context.Breweries.Single(s=>s.Name == "Heineken"), Price = 8.50 },
                new Beer { Name = "Xingu", Brewery = context.Breweries.Single(s=>s.Name == "Heineken"), Price = 8.00 },
                new Beer { Name = "Stella Artois Black", Brewery = context.Breweries.Single(s=>s.Name == "Stella Artois"), Price = 6.00 },
                new Beer { Name = "Stella Artois Noire", Brewery = context.Breweries.Single(s=>s.Name == "Stella Artois"), Price = 7.00 },
                new Beer { Name = "Stella Artois", Brewery = context.Breweries.Single(s=>s.Name == "Stella Artois"), Price = 5.50 },
                new Beer { Name = "Colorado Ithaca", Brewery = context.Breweries.Single(s=>s.Name == "Colorado"), Price = 8.00 },
                new Beer { Name = "Colorado Vixnu", Brewery = context.Breweries.Single(s=>s.Name == "Colorado"), Price = 7.50 },
                new Beer { Name = "Colorado Indica", Brewery = context.Breweries.Single(s=>s.Name == "Colorado"), Price = 7.00 },
                new Beer { Name = "Eisenbahn Lust Prestige", Brewery = context.Breweries.Single(s=>s.Name == "Sudbrack"), Price = 9.00 },
                new Beer { Name = "Eisenbahn Lust", Brewery = context.Breweries.Single(s=>s.Name == "Sudbrack"), Price = 8.00 },
                new Beer { Name = "Eisenbahn Frosty Bison", Brewery = context.Breweries.Single(s=>s.Name == "Sudbrack"), Price = 9.00 },
                new Beer { Name = "Petra Stark Bier", Brewery = context.Breweries.Single(s=>s.Name == "Petrópolis"), Price = 7.00 },
                new Beer { Name = "Petra Aurum", Brewery = context.Breweries.Single(s=>s.Name == "Petrópolis"), Price = 7.50 },
                new Beer { Name = "Petra Weiss Bier", Brewery = context.Breweries.Single(s=>s.Name == "Petrópolis"), Price = 7.50 });

            context.SaveChanges();

            context.Bars.AddOrUpdate(b => b.Name,
                new Bar
                {
                    Name = "Bar dos Amigos",
                    Address = "Rua Domingues de Sa 33",
                    Cnpj = "33.123.455/2145.22",
                    Beers = new List <Beer> { 
                                context.Beers.Single(s=>s.Name == "Heineken"),
                                context.Beers.Single(s=>s.Name == "Xingu"),
                                context.Beers.Single(s=>s.Name == "Stella Artois"),
                                context.Beers.Single(s=>s.Name == "Petra Aurum"),
                                context.Beers.Single(s=>s.Name == "Colorado Ithaca")
                            }
                },

                new Bar
                {
                    Name = "Botequim Belmonte",
                    Address = "Rua Jardim Botanico 530",
                    Cnpj = "19.723.455/2145.22",
                    Beers = new List<Beer> { 
                                context.Beers.Single(s=>s.Name == "Heineken"),
                                context.Beers.Single(s=>s.Name == "Colorado Vixnu"),
                                context.Beers.Single(s=>s.Name == "Stella Artois"),
                                context.Beers.Single(s=>s.Name == "Petra Stark Bier"),
                                context.Beers.Single(s=>s.Name == "Colorado Ithaca")
                            }
                },


                new Bar
                {
                    Name = "Academia de Niteroi",
                    Address = "Avenida Quintino Bocaiuva 322",
                    Cnpj = "37.243.986/2145.22",
                    Beers = new List<Beer> { 
                                context.Beers.Single(s=>s.Name == "Eisenbahn Lust"),
                                context.Beers.Single(s=>s.Name == "Eisenbahn Frosty Bison"),
                                context.Beers.Single(s=>s.Name == "Stella Artois"),
                                context.Beers.Single(s=>s.Name == "Petra Weiss Bier"),
                                context.Beers.Single(s=>s.Name == "Stella Artois Black")
                            }
                });
        }
    }
}
