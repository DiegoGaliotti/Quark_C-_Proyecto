using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Local_Comercia_V2.Modelo_Local_Comercial
{
    public abstract class Prenda
    {
        //Atributos
        protected string nombre;
        protected double precio;
        protected bool calidadPremium;
        protected int stock;

        //Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public bool CalidadPremium { get { return calidadPremium; } set { calidadPremium = value; } }
        public int Stock { get { return stock; } set { stock = value; } }

        //Metodo
        public abstract double precioFinal(double precioBase);
    }
}
