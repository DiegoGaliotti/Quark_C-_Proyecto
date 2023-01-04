using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Local_Comercia_V2.Modelo_Local_Comercial
{
    public class Camisa : Prenda
    {
        //Atributos
        private bool mangaLarga = false;
        private bool cuelloMao = false;

        //Propiedades
        public bool MangaLarga { get { return mangaLarga; } set { mangaLarga = value; } } //Para cargar y ver desde afuera 
        public bool CuelloMao { get { return cuelloMao; } set { cuelloMao = value; } } //Para cargar y ver desde afuera 

        //Método
        public override double precioFinal(double precioBase)
        {
            double precio1, precio2;
            if (mangaLarga == false)
                precio1 = precioBase * 0.90;
            else
                precio1 = precioBase;
            if (cuelloMao == true)
                precio2 = precio1 * 1.03;
            else
                precio2 = precio1;

            if (calidadPremium == false)
                this.precio = precio2;
            else
                this.precio = precio2 * 1.3;
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
