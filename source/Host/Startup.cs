/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * see license
 */

using Owin;

namespace Thinktecture.IdentityManager.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var connString = "AspId";
            //var connString = "CustomAspId";
            var factory = new Thinktecture.IdentityManager.Host.AspNetIdentityIdentityManagerFactory(connString);
            app.UseIdentityManager(new IdentityManagerConfiguration()
            {
                IdentityManagerFactory = factory.Create
            });
        }
    }
}