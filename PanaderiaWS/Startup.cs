using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
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
<<<<<<< HEAD



    }

=======
    }
>>>>>>> c9634c55a2889122bb6f17a6d1473691187f58f4
}
