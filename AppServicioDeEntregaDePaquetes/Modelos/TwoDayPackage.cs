using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioDeEntregaDePaquetes
{
    public class TwoDayPackage

    {
       public int cargosEnvio;
       public int cuotaFija;

       public TwoDayPackage(int CargoEnvio, int cuotaFija);



        public void calculateCost()
        {
            int cargos_de_envio;

            throw new System.NotImplementedException();
        }
    }
}
