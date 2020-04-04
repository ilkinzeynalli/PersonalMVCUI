﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PersonelMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Anasayfa",
            //    url: "",
            //    defaults: new { controller = "Departman", action = "Merhaba" }
            //);

            //routes.MapRoute(
            //    name: "PersonalListesi",
            //    url: "personal/liste/{siralama}/{sayfa}",
            //    defaults: new { controller = "Personal", action = "PersonalLitesi", siralama=UrlParameter.Optional,sayfa=UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
