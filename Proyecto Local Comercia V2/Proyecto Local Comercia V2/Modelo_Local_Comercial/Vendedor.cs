using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Local_Comercia_V2.Modelo_Local_Comercial
{
    public class Vendedor
    {
        //Atributos
        private string nombre;
        private string apellido;
        private int idVendedor;
        private List<Cotizacion> historiaCotizaciones;
        private Tienda tienda;

        //Propiedades
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int IdVendedor { get { return idVendedor; } }
        public Tienda Tienda { get { return tienda; } set { tienda = value; } }
        public List<Cotizacion> HistoriaCotizaciones { get; set; }

        // Constructor
        public Vendedor(string nombre, string apellido, int idvendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idVendedor = idvendedor;
            HistoriaCotizaciones = new List<Cotizacion>();
        }
        //Metodo
        public double cotizarPrenda( bool pantalon, double preciobase, int cantidadprendas, bool chupin, bool mao, bool larga, bool calidadPremium)
        {
            Cotizacion cotizacion1 = new Cotizacion( pantalon, preciobase, cantidadprendas, chupin, mao, larga,calidadPremium);
            cotizacion1.FechaCotizacion = DateTime.Now;
            cotizacion1.IdCotizacion = HistoriaCotizaciones.Count + 1;
            cotizacion1.IdVendedor = this.IdVendedor;
            cotizacion1.CantidadUnidadesCotizadas = cantidadprendas;
            HistoriaCotizaciones.Add(cotizacion1);
            return cotizacion1.PrecioCotizacion;
        }
        public void ingresoTienda(string nom, string dir)
        {
            Tienda = new Tienda(nom, dir);
        }
        public void ingresoMercaderia(Prenda prenda)
        {
            Tienda.ingresoMercadería(prenda);
        }
        public int verStockEnTienda(Prenda prenda)
        {
            return Tienda.stockEnTienda(prenda);
        }
    }
}
