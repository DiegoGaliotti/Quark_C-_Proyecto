using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Local_Comercial
{
    internal class Vendedor
    {
        //Atributos
        private string nombre = "Pedro";
        private string apellido = "Garcia";
        private int idVendedor = 10001;
        private List<Cotizacion> historiaCotizaciones;
        private Tienda tienda;  

        //Propiedades
        public string Nombre {  get { return nombre; }}
        public string Apellido { get { return apellido; }}
        public int IdVendedor { get { return idVendedor; }}

        public Tienda Tienda { get { return tienda; } set { tienda = value; } }

        //Metodo
        public double cotizarPrenda()
        {
            Cotizacion cotizacion = new Cotizacion();   
            cotizacion.precioCotizacion()
        }

    }
}
