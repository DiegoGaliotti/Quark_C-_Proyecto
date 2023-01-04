using Proyecto_Local_Comercia_V2.Modelo_Local_Comercial;
using Proyecto_Local_Comercia_V2.Presentador_Local_Comercial;

namespace Proyecto_Local_Comercia_V2
{
    public partial class Form1 : Form
    {
        Presentador presentador = new Presentador();
        public Form1()
        {
            InitializeComponent();
            radioButton_Camisa.Checked = true;
            radioButton_stadard.Checked = true;
            label_nombreVendedor.Text = presentador.datosVendedor();
            label_nombreTienda.Text = presentador.local();
            label_direccion.Text = presentador.direccionLocal();
            presentador.ingresoMercaderia();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gb_Prendas.Controls.Add(radioButton_Camisa);
            gb_Prendas.Controls.Add(radioButton_Pantalon);
            gb_calidadPrendas.Controls.Add(radioButton_Premium);
            gb_calidadPrendas.Controls.Add(radioButton_stadard);
            textBox_cantidad.Text = "1";
        }
        private void radioButton_Camisa_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_chupin.Enabled = false;
            checkBox_cuelloMao.Enabled = true;
            checkBox_mangaLarga.Enabled = true;
            checkBox_chupin.Checked = false;
            checkBox_cuelloMao.Checked = false;
            checkBox_mangaLarga.Checked = false;
        }
        private void radioButton_Pantalon_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_cuelloMao.Enabled = false;
            checkBox_mangaLarga.Enabled = false;
            checkBox_chupin.Enabled = true;
            checkBox_chupin.Checked = false;
            checkBox_cuelloMao.Checked = false;
            checkBox_mangaLarga.Checked = false;
        }
        private void button_cotizar_Click(object sender, EventArgs e)
        {
            try
            {
                double precioCotizacion = presentador.cotizarPrenda(radioButton_Pantalon.Checked, double.Parse(textBox_precioUnitario.Text), int.Parse(textBox_cantidad.Text), checkBox_chupin.Checked, checkBox_cuelloMao.Checked, checkBox_mangaLarga.Checked, radioButton_Premium.Checked);
                label_precioFinal.Text = Math.Round(precioCotizacion, 2).ToString();
                
                if (presentador.verStockTienda() < int.Parse(textBox_cantidad.Text))
                {
                    label_stockActual.Text = "Falta de Stock en tienda";
                }
                else
                {
                    label_stockActual.Text = presentador.verStockTienda().ToString();
                }
            }
            catch (Exception)
            {
                label_precioFinal.Text = "Revisar Precio Unitario y Cantidad";
            }
        }
        private void linkLabel_historial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listView_historialCotizaciones.Items.Clear();
            foreach (var cotizacion in presentador.verListaCorizaciones())
            {
                listView_historialCotizaciones.Items.Add(cotizacion.ToString());
            }
        }
        private void listView_historialCotizaciones_SelectedIndexChanged(object sender, EventArgs e) //Queda acá, si elimino se rompe el forms. 
        {

        }
    }
}