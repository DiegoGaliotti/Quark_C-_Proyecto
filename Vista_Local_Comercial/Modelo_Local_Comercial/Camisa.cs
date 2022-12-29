using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Local_Comercial
{
    internal class Camisa : Prendas
    {
        //Atributos
        private bool mangaLarga = false;
        private bool cuelloMao = false;


        //Propiedades
        public bool MangaLarga { get { return mangaLarga; } set { mangaLarga = value; } }
        public bool CuelloMao { get { return cuelloMao; } set { cuelloMao=value; } }

        //Método
        public override double precioFinal(double precioBase)
        {
            double precio1, precio2;

            if (mangaLarga = false)
                precio1 = precioBase * 0.80;
            else
                precio1 = precioBase;

            if (cuelloMao = true)
                precio2 = precio1 * 1.03;
            else
                precio2 = precio1;

            base.precioFinal(precio2);

            return this.precio;
        }

        public void ingresoMercadería(string nombre, int stock, bool calidad, bool cuelloMallao, bool mangaLarga)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.calidadPremium = calidad;  
            this.mangaLarga = mangaLarga;
            this.cuelloMao = cuelloMallao;
        }

    }
}
