﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uruk.UI.Web.Startup))]
namespace Uruk.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
