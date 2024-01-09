﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBasics
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "studentList",
            //    url: "view-123",
            //    defaults: new { controller = "Student", action = "ViewStudents" }
            //);

            //routes.MapRoute(
            //    name: "Default123",
            //    url: "{controller}/{action}/{name}",
            //    defaults: new { controller = "Student", action = "Test", name = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
