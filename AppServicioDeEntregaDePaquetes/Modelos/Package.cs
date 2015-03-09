using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioDeEntregaDePaquetes
{
    public abstract class Package : OvernightPackage
    {
        private  string nombre;
        private  int codigo ;
        private  int direccion ;
        private  string cuidad ;
        private string Departamento ;
        private string codigo_postal_remitente;
        private string codigo_postal_destinatario;
        private float peso ;
        private float costo;

        public Package(string nombre;)
        {
            throw new System.NotImplementedException();
        }
    }
}
