using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Local_Comercia_V2.Modelo_Local_Comercial
{
    public class Cotizacion
    {
        //Atributos 
        public int IdCotizacion { get; set; }
        public DateTime FechaCotizacion { get; set; }
        public int IdVendedor { get; set; }
        public Prenda PrendaCotizada { get; set; }
        public int CantidadUnidadesCotizadas { get; set; }
        public double PrecioCotizacion { get; set; }

        //Metodo
        public Cotizacion(bool pantalon, double preciobase, int cantidadprendas, bool chupin, bool mao, bool larga, bool calidadPremium)
        {
            if (pantalon == true)
            {
                Pantalon pantalon1 = new Pantalon();
                pantalon1.CalidadPremium = calidadPremium;
                pantalon1.Chupin = chupin;
                this.PrecioCotizacion = pantalon1.precioFinal(preciobase) * cantidadprendas;
                if (calidadPremium == true && chupin == true)
                {
                    pantalon1.Nombre = "Pantalon Prem chupin";
                    this.PrendaCotizada = pantalon1;
                }
                else if (calidadPremium == true && chupin == false)
                {
                    pantalon1.Nombre = "Pantalon Prem comun";
                    this.PrendaCotizada = pantalon1;
                }
                else if (calidadPremium == false && chupin == false)
                {
                    pantalon1.Nombre = "Pantalon Stan comun";
                    this.PrendaCotizada = pantalon1;
                }
                else
                {
                    pantalon1.Nombre = "Pantalon Stan chupin";
                    this.PrendaCotizada = pantalon1;
                }
            }
            else
            {
                Camisa camisa1 = new Camisa();
                camisa1.MangaLarga = larga;
                camisa1.CuelloMao = mao;
                camisa1.CalidadPremium = calidadPremium;
                this.PrecioCotizacion = camisa1.precioFinal(preciobase)*cantidadprendas;
                if (calidadPremium == true)
                {
                    if (larga == true && mao == true)
                    {
                        camisa1.Nombre = "Camisa Prem m_larga c_mao";
                        this.PrendaCotizada = camisa1;
                    }
                    else if (larga == true && mao == false)
                    {
                        camisa1.Nombre = "Camisa Prem m_larga c_comun";
                        this.PrendaCotizada = camisa1;
                    }
                    else if (larga == false && mao == false)
                    {
                        camisa1.Nombre = "Camisa Prem m_corta c_comun";
                        this.PrendaCotizada = camisa1;
                    }
                    else
                    {
                        camisa1.Nombre = "Camisa Prem m_corta c_mao";
                        this.PrendaCotizada = camisa1;
                    }
                }
                else
                {
                    if (larga == true && mao == true)
                    {
                        camisa1.Nombre = "Camisa Stan m_larga c_mao";
                        this.PrendaCotizada = camisa1;
                    }
                    else if (larga == true && mao == false)
                    {
                        camisa1.Nombre = "Camisa Stan m_larga c_comun";
                        this.PrendaCotizada = camisa1;
                    }
                    else if (larga == false && mao == false)
                    {
                        camisa1.Nombre = "Camisa Stan m_corta c_comun";
                        this.PrendaCotizada = camisa1;
                    }
                    else
                    {
                        camisa1.Nombre = "Camisa Stan m_corta c_mao";
                        this.PrendaCotizada = camisa1;
                    }
                }
           
            }
        }

    }
}
