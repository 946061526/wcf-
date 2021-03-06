﻿using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using WCF.Web.Contracts.Impl;

namespace SJTU.WCF
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            RouteTable.Routes.Add(new ServiceRoute("User", new WebServiceHostFactory(), typeof(UserService)));
        }
    }
}