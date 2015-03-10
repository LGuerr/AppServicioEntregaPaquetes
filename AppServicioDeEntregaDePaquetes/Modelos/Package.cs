using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace AppServicioDeEntregaDePaquetes
{
    public abstract class Package : TwoDayPackage
    {
        private string nombre;


        private string codigo;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string codigo_postal_remitente;
        private string codigo_postal_destinatario;
        private int peso;
        private int costo= 1000;

        public Package(string nombre, string codigo, string direccion, string ciudad, string departamento, string codigo_postal_remitente, string codigo_postal_destinatario, int peso, int costo);

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }

        }
        public string Codigo_postal_remitente
        {
            get { return codigo_postal_remitente; }
            set { codigo_postal_remitente = value; }
        }
        public string Codigo_postal_destinatario
        {
            get { return codigo_postal_destinatario; }
            set { codigo_postal_destinatario = value; }
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public Package()
        {
            this.Nombre = "Nombre";
            this.Codigo = "Codigo";
            this.Direccion = "Direccion";
            this.Ciudad = " Ciudad";
            this.Departamento = "Departamento";
            this.Codigo_postal_remitente = "Codigo Postal Del Remitente";
            this.Codigo_postal_destinatario = "Codigo Postal DeL Destinatario";
            this.peso = "Peso";
            this.Costo = " Costo";





        }
        


        public void calculateCost()
        {
            int costo_paquete;
            
            costo_paquete = peso * costo;


        }


            
            }

        }
    

