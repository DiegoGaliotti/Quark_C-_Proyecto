using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Local_Comercia_V2.Modelo_Local_Comercial
{
    public class Tienda
    {
        //Atributos
        private string nombre;
        private string direccion;
        private List<Prenda> listadoPrendas;

        //Propiedades
        public string Nombre { get { return nombre; } } //Solo geteamos ya que todo lo que cargue se hará desde el constructor. 
        public string Direccion { get { return direccion; } } //Solo geteamos ya que todo lo que cargue se hará desde el constructor.
        public List<Prenda> ListadoPrendas { get { return listadoPrendas; } } //Solo geteamos ya que todo lo que cargue se hará desde el metodo ingreso de mercadería. 

        //Constructor
        public Tienda(string nom, string dir)
        {
            this.nombre = nom;
            this.direccion = dir;
            listadoPrendas = new List<Prenda>();
        }
        public void ingresoMercadería(Prenda prenda)
        {
            listadoPrendas.Add(prenda);
        }
        public int stockEnTienda(Prenda prenda)
        {
            foreach (Prenda prenda2 in listadoPrendas)
            {
                if (prenda == prenda2)
                {
                    return prenda2.Stock;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
