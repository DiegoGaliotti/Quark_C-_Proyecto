using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Local_Comercial
{
    public abstract class Prendas
    {
        //Atributos
        protected string nombre;
        protected double precio;
        protected bool calidadPremium;
        protected int stock;

        //Propiedades
        public string Nombre { get { return nombre; } }
        public bool CalidadPremium { get { return calidadPremium; }  set { calidadPremium = value; } }

        //Metodo
        public virtual double precioFinal(double precioBase)
        {
            if (calidadPremium = false)
                this.precio = precioBase;
            else
                this.precio = precioBase * 1.3;

            return this.precio;
        }


    }
}
