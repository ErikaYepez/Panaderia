﻿using Owin;
using Panaderia.BL.Data;

namespace PanaderiaWS
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //Configura dbContext para ser usado por request como unica instancia
            app.CreatePerOwinContext(PanaderiaContext.Create);

        }



    }

}