using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_Local_Comercial
{
    public class Tienda
    {
        //Atributos
        private string nombre;
        private string direccion;
        private List<Prendas> listadoPrendas;
        private Vendedor vendedor;

        //Propiedades
        public string Nombre { get { return nombre; } }
        public string Direccion { get { return direccion; } }
        public List<Prendas> ListadoPrendas { get { return listadoPrendas; } set { listadoPrendas = value; } }

        //Constructor
        public Tienda()
        {
            nombre = "La Coupe";
            direccion = "Paso de los Andes 645, Mendoza, Argentina";
            //listadoPrendas = new List<Prendas>();
            Camisa camisaPremiumMaoCorta = new Camisa();
            camisaPremiumMaoCorta.ingresoMercadería("Camisa Premium Mao Corta", 100, true, true, false);
            Camisa camisaStandardMaoCorta = new Camisa();
            camisaStandardMaoCorta.ingresoMercadería("Camisa Standar Mao Corta", 100, false, true, false);
            Camisa camisaPremiumComunCorta = new Camisa();
            camisaPremiumComunCorta.ingresoMercadería("Camisa Premium Comun Corta", 150, true, false, false);
            Camisa camisaStandardComunCorta = new Camisa();
            camisaStandardComunCorta.ingresoMercadería("Camisa Standar Comun Corta", 150, false, false, false);
            Camisa camisaPremiumMaoLarga = new Camisa();
            camisaPremiumMaoLarga.ingresoMercadería("Camisa Premium Mao Larga", 75, true, true, true);
            Camisa camisaStandardMaoLarga = new Camisa();
            camisaStandardMaoLarga.ingresoMercadería("Camisa Standar Mao Larga", 75, false, true, true);
            Camisa camisaPremiumComunLarga = new Camisa();
            camisaPremiumComunLarga.ingresoMercadería("Camisa Premium Comun Larga", 175, true, false, true);
            Camisa camisaStandardComunLarga = new Camisa();
            camisaStandardComunLarga.ingresoMercadería("Camisa Standar Comun Larga", 175, false, false, true);
            Pantalon pantalonPremiumChupin = new Pantalon();
            pantalonPremiumChupin.ingresoMercadería("Pantalon Premium Chupin", 750, true, true);
            Pantalon pantalonStandarChupin = new Pantalon();
            pantalonStandarChupin.ingresoMercadería("Pantalon Standar Chupin", 750, false, true);
            Pantalon pantalonPremiumComun = new Pantalon();
            pantalonPremiumComun.ingresoMercadería("Pantalon Premium Chupin", 250, true, false);
            Pantalon pantalonStandarComun = new Pantalon();
            pantalonStandarComun.ingresoMercadería("Pantalon Standar Chupin", 250, false, false);

            listadoPrendas.Add(camisaPremiumMaoCorta);
            listadoPrendas.Add(camisaStandardMaoCorta);
            listadoPrendas.Add(camisaPremiumComunCorta);
            listadoPrendas.Add(camisaStandardComunCorta);
            listadoPrendas.Add(camisaPremiumMaoLarga);
            listadoPrendas.Add(camisaStandardMaoLarga);
            listadoPrendas.Add(camisaPremiumComunLarga);
            listadoPrendas.Add(camisaStandardComunLarga);
            listadoPrendas.Add(pantalonPremiumChupin);
            listadoPrendas.Add(pantalonStandarChupin);
            listadoPrendas.Add(pantalonPremiumComun);
            listadoPrendas.Add(pantalonStandarComun);
        }

    }
}
