using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EnlaceNoivas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "ProfileProvider",
                url: "Fornecedor/Perfil/{providerName}",
                defaults: new { controller = "Provider", action = "Profile"}
            );
            routes.MapRoute(
                name: "SearchPage",
                url: "Fornecedor/Proucurar/{searched}/{page}",
                defaults: new { controller = "Search", action = "SearchProvider"}
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}