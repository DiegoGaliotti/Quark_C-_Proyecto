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
        public string Nombre { get { return nombre; } set { nombre = value; } } //Para cargar y ver desde afuera 
        public bool CalidadPremium { get { return calidadPremium; } set { calidadPremium = value; } } //Para cargar y ver desde afuera 
        public int Stock { get { return stock; }  } //Para ver desde afuera ya que el stock se carga directo de el método de las subclases

        //Metodo
        public abstract double precioFinal(double precioBase);
    }
}
