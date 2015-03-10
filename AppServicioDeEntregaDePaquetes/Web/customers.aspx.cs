using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppServicioDeEntregaDePaquetes.Web
{
    public partial class customers : System.Web.UI.Page
    {
        
        private string nombre;


        private string apellido;
        private string direccion;
        private int telefono;
        private string email;



        public customers(string nombre, string apellido,string direccion, int telefono, string email);

        public string Nombre

        {
          get { return nombre; }
          set { nombre = value; }
         }
        public string Direccion
        {
         get { return direccion; }
         set { direccion = value; }
         }
        public int Telefono
        {
         get { return telefono; }
         set { telefono = value; }
        }
        public string Email
        {
         get { return email; }
         set { email = value; }
         }
        
        }
    }
