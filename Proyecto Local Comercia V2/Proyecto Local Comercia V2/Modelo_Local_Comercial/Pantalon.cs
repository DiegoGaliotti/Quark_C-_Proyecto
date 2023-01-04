using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Local_Comercia_V2.Modelo_Local_Comercial
{
    public class Pantalon : Prenda
    {
        //Atributos
        private bool chupin = false;

        //Propiedades
        public bool Chupin { get { return chupin; } set { chupin = value; } } //Para cargar y ver desde afuera 

        //Método
        public override double precioFinal(double precioBase)
        {
            double precio1;

            if (chupin == true)
                precio1 = precioBase * 0.88;
            else
                precio1 = precioBase;

            if (calidadPremium == false)
                this.precio = precio1;
            else
                this.precio = precio1 * 1.3;

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
