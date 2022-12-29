using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Local_Comercial
{
    internal class Pantalon : Prendas
    {
        //Atributos
        private bool chupin = false;

        //Constructor
        public Pantalon()
        {
            nombre = "Pantalón";
        }

        //Propiedades
        public bool Chupin { get { return chupin; } set { chupin = value; } }

        //Método
        public override double precioFinal(double precioBase)
        {
            double precio1;
            if (chupin = true)
                precio1 = precioBase*0.88;
            else
                precio1 = precioBase;

            base.precioFinal(precio1);

            return this.precio;
        }
        public void ingresoMercadería(string nombre, int stock, bool calidad, bool chupin)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.calidadPremium = calidad;
            this.chupin = chupin;
        }
    }
}
