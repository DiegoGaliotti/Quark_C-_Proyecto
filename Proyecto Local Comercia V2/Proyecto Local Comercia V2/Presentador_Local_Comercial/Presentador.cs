using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Local_Comercia_V2.Modelo_Local_Comercial;

namespace Proyecto_Local_Comercia_V2.Presentador_Local_Comercial
{
    public class Presentador
    {
        private readonly Vendedor vendedor;
        public Presentador()
        {
            vendedor = new Vendedor("Lautaro", "Martina", 10001);
            vendedor.ingresoTienda("La Coulette", "Granaderos 456, Cdad, Mza");
        }
        public double cotizarPrenda(bool pantalon, double preciobase, int cantidadprendas, bool chupin, bool mao, bool larga, bool calidadPremium)
        {
            return vendedor.cotizarPrenda(pantalon, preciobase, cantidadprendas, chupin, mao, larga, calidadPremium);
        }
        public List<Cotizacion> solicitarCotizaciones()
        {
            return vendedor.HistoriaCotizaciones;
        }
        public string datosVendedor()
        {
            //return (vendedor.Nombre + " " + vendedor.Apellido + \\n + vendedor.IdVendedor.ToString());
            return (vendedor.Nombre + " " + vendedor.Apellido + " | Id: " + vendedor.IdVendedor.ToString());
        }
        public string local()
        {
            return vendedor.Tienda.Nombre;
        }
        public string direccionLocal()
        {
            return vendedor.Tienda.Direccion;
        }
        public List<string> verListaCorizaciones()
        {
            List<string> listaCotizaciones = new List<string>();
            foreach (var cot in vendedor.HistoriaCotizaciones)
            {
                string id = cot.IdCotizacion.ToString();
                string vendedor = cot.IdVendedor.ToString();
                string nombrePrenda = cot.PrendaCotizada.Nombre.ToString();
                string fecha = cot.FechaCotizacion.ToString();
                string cant = cot.CantidadUnidadesCotizadas.ToString();
                string precioFinal = cot.PrecioCotizacion.ToString();
                listaCotizaciones.Add( id + "-  Nombre: ´" + nombrePrenda + "´ - Cant: " + cant+" - Precio: $"+ precioFinal);
            }
            return listaCotizaciones;
        }
        public void ingresoMercaderia() //Creo el método para permitir hacer el ingreso de mercadería desde afuera del modelo . Para simplificar creo y cargo todo acá 
        {
            Camisa camisaPremiumMaoCorta = new Camisa();
            camisaPremiumMaoCorta.ingresoMercadería("Camisa Prem m_corta c_mao", 100, true, true, false);
            Camisa camisaStandardMaoCorta = new Camisa();
            camisaStandardMaoCorta.ingresoMercadería("Camisa Stan m_corta c_mao", 100, false, true, false);
            Camisa camisaPremiumComunCorta = new Camisa();
            camisaPremiumComunCorta.ingresoMercadería("Camisa Prem m_corta c_comun", 150, true, false, false);
            Camisa camisaStandardComunCorta = new Camisa();
            camisaStandardComunCorta.ingresoMercadería("Camisa Stan m_corta c_comun", 150, false, false, false);
            Camisa camisaPremiumMaoLarga = new Camisa();
            camisaPremiumMaoLarga.ingresoMercadería("Camisa Prem m_larga c_mao", 75, true, true, true);
            Camisa camisaStandardMaoLarga = new Camisa();
            camisaStandardMaoLarga.ingresoMercadería("Camisa Stan m_larga c_mao", 75, false, true, true);
            Camisa camisaPremiumComunLarga = new Camisa();
            camisaPremiumComunLarga.ingresoMercadería("Camisa Prem m_larga c_comun", 175, true, false, true);
            Camisa camisaStandardComunLarga = new Camisa();
            camisaStandardComunLarga.ingresoMercadería("Camisa Stan m_larga c_comun", 175, false, false, true);
            Pantalon pantalonPremiumChupin = new Pantalon();
            pantalonPremiumChupin.ingresoMercadería("Pantalon Prem chupin", 750, true, true);
            Pantalon pantalonStandarChupin = new Pantalon();
            pantalonStandarChupin.ingresoMercadería("Pantalon Stan chupin", 750, false, true);
            Pantalon pantalonPremiumComun = new Pantalon();
            pantalonPremiumComun.ingresoMercadería("Pantalon Prem comun", 250, true, false);
            Pantalon pantalonStandarComun = new Pantalon();
            pantalonStandarComun.ingresoMercadería("Pantalon Stan comun", 250, false, false);

            vendedor.ingresoMercaderia(camisaPremiumMaoCorta);
            vendedor.ingresoMercaderia(camisaStandardMaoCorta);
            vendedor.ingresoMercaderia(camisaPremiumComunCorta);
            vendedor.ingresoMercaderia(camisaStandardComunCorta);
            vendedor.ingresoMercaderia(camisaPremiumMaoLarga);
            vendedor.ingresoMercaderia(camisaStandardMaoLarga);
            vendedor.ingresoMercaderia(camisaPremiumComunLarga);
            vendedor.ingresoMercaderia(camisaStandardComunLarga);
            vendedor.ingresoMercaderia(pantalonPremiumChupin);
            vendedor.ingresoMercaderia(pantalonStandarChupin);
            vendedor.ingresoMercaderia(pantalonPremiumComun);
            vendedor.ingresoMercaderia(pantalonStandarComun);
        }
        public int verStockTienda()
        {
            int ultimoValorCotizado = vendedor.HistoriaCotizaciones.Count - 1;

            foreach (Prenda prenda in vendedor.Tienda.ListadoPrendas)
            {
                if (prenda.Nombre == vendedor.HistoriaCotizaciones[ultimoValorCotizado].PrendaCotizada.Nombre)
                    return prenda.Stock;
            }
            return vendedor.Tienda.ListadoPrendas.Count;
        }

    }
}
