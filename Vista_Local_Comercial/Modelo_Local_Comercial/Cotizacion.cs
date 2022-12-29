using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Local_Comercial
{
    public class Cotizacion
    {
        //Atributos 
        public int IdCotizacion { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public int IdVendedor { get; set; }
        public Prendas PrendaCotizada { get; set; }
        public int CantidadPrendasCotizar { get; set; }

        //Metodo
        public double precioCotizacion(Prendas nombrePrenda, double preciobase, int cantidadprendas)
        {
            double precioIntermedio = nombrePrenda.precioFinal(preciobase);
            return precioIntermedio*cantidadprendas;

        }


    }
}
