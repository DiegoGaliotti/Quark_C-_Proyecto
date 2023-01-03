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
        public string Nombre { get { return nombre; } }
        public string Direccion { get { return direccion; } }
        public List<Prenda> ListadoPrendas { get { return listadoPrendas; } set { listadoPrendas = value; } }

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
