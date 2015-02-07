using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BarShowroom
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BreweryBars",
                url: "Brewery/{breweryname}/Bars",
                defaults: new { controller = "BreweryBars", action = "Index", breweryname = "" });

            routes.MapRoute(
                name: "BreweryBeers",
                url: "Brewery/{breweryname}/Beers",
                defaults: new { controller = "BreweryBeers", action = "Index", breweryname = "" });

            routes.MapRoute(
                name: "BeerBars",
                url: "Beer/{beername}/Bars",
                defaults: new { controller = "BeerBars", action = "Index", beername = "" });

            routes.MapRoute(
                name: "BarBeers",
                url: "Bar/{barname}/Beers",
                defaults: new { controller = "BarBeers", action = "Index", barname = "" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}