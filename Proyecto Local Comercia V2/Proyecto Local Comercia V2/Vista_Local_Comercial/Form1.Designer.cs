namespace Proyecto_Local_Comercia_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton_Camisa = new System.Windows.Forms.RadioButton();
            this.radioButton_Pantalon = new System.Windows.Forms.RadioButton();
            this.checkBox_mangaLarga = new System.Windows.Forms.CheckBox();
            this.checkBox_cuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBox_chupin = new System.Windows.Forms.CheckBox();
            this.textBox_precioUnitario = new System.Windows.Forms.TextBox();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.button_cotizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_precioFinal = new System.Windows.Forms.Label();
            this.gb_Prendas = new System.Windows.Forms.GroupBox();
            this.gb_calidadPrendas = new System.Windows.Forms.GroupBox();
            this.radioButton_stadard = new System.Windows.Forms.RadioButton();
            this.radioButton_Premium = new System.Windows.Forms.RadioButton();
            this.gb_precioYCantidad = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nombreTienda = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_nombreVendedor = new System.Windows.Forms.Label();
            this.linkLabel_historial = new System.Windows.Forms.LinkLabel();
            this.listView_historialCotizaciones = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label_stockActual = new System.Windows.Forms.Label();
            this.gb_Prendas.SuspendLayout();
            this.gb_calidadPrendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidades en stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "#";
            // 
            // radioButton_Camisa
            // 
            this.radioButton_Camisa.AutoSize = true;
            this.radioButton_Camisa.Location = new System.Drawing.Point(19, 39);
            this.radioButton_Camisa.Name = "radioButton_Camisa";
            this.radioButton_Camisa.Size = new System.Drawing.Size(94, 29);
            this.radioButton_Camisa.TabIndex = 6;
            this.radioButton_Camisa.TabStop = true;
            this.radioButton_Camisa.Text = "Camisa";
            this.radioButton_Camisa.UseVisualStyleBackColor = true;
            this.radioButton_Camisa.CheckedChanged += new System.EventHandler(this.radioButton_Camisa_CheckedChanged);
            // 
            // radioButton_Pantalon
            // 
            this.radioButton_Pantalon.AutoSize = true;
            this.radioButton_Pantalon.Location = new System.Drawing.Point(18, 83);
            this.radioButton_Pantalon.Name = "radioButton_Pantalon";
            this.radioButton_Pantalon.Size = new System.Drawing.Size(105, 29);
            this.radioButton_Pantalon.TabIndex = 7;
            this.radioButton_Pantalon.TabStop = true;
            this.radioButton_Pantalon.Text = "Pantalon";
            this.radioButton_Pantalon.UseVisualStyleBackColor = true;
            this.radioButton_Pantalon.CheckedChanged += new System.EventHandler(this.radioButton_Pantalon_CheckedChanged);
            // 
            // checkBox_mangaLarga
            // 
            this.checkBox_mangaLarga.AutoSize = true;
            this.checkBox_mangaLarga.Location = new System.Drawing.Point(320, 39);
            this.checkBox_mangaLarga.Name = "checkBox_mangaLarga";
            this.checkBox_mangaLarga.Size = new System.Drawing.Size(141, 29);
            this.checkBox_mangaLarga.TabIndex = 8;
            this.checkBox_mangaLarga.Text = "Manga Larga";
            this.checkBox_mangaLarga.UseVisualStyleBackColor = true;
            // 
            // checkBox_cuelloMao
            // 
            this.checkBox_cuelloMao.AutoSize = true;
            this.checkBox_cuelloMao.Location = new System.Drawing.Point(170, 40);
            this.checkBox_cuelloMao.Name = "checkBox_cuelloMao";
            this.checkBox_cuelloMao.Size = new System.Drawing.Size(128, 29);
            this.checkBox_cuelloMao.TabIndex = 9;
            this.checkBox_cuelloMao.Text = "Cuello Mao";
            this.checkBox_cuelloMao.UseVisualStyleBackColor = true;
            // 
            // checkBox_chupin
            // 
            this.checkBox_chupin.AutoSize = true;
            this.checkBox_chupin.Location = new System.Drawing.Point(170, 81);
            this.checkBox_chupin.Name = "checkBox_chupin";
            this.checkBox_chupin.Size = new System.Drawing.Size(94, 29);
            this.checkBox_chupin.TabIndex = 10;
            this.checkBox_chupin.Text = "Chupin";
            this.checkBox_chupin.UseVisualStyleBackColor = true;
            // 
            // textBox_precioUnitario
            // 
            this.textBox_precioUnitario.Location = new System.Drawing.Point(377, 515);
            this.textBox_precioUnitario.Name = "textBox_precioUnitario";
            this.textBox_precioUnitario.Size = new System.Drawing.Size(66, 31);
            this.textBox_precioUnitario.TabIndex = 13;
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(471, 515);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(62, 31);
            this.textBox_cantidad.TabIndex = 14;
            // 
            // button_cotizar
            // 
            this.button_cotizar.Location = new System.Drawing.Point(114, 602);
            this.button_cotizar.Name = "button_cotizar";
            this.button_cotizar.Size = new System.Drawing.Size(112, 34);
            this.button_cotizar.TabIndex = 15;
            this.button_cotizar.Text = "Cotizar";
            this.button_cotizar.UseVisualStyleBackColor = true;
            this.button_cotizar.Click += new System.EventHandler(this.button_cotizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "$";
            // 
            // label_precioFinal
            // 
            this.label_precioFinal.AutoSize = true;
            this.label_precioFinal.Location = new System.Drawing.Point(303, 604);
            this.label_precioFinal.Name = "label_precioFinal";
            this.label_precioFinal.Size = new System.Drawing.Size(173, 25);
            this.label_precioFinal.TabIndex = 17;
            this.label_precioFinal.Text = "_______________________";
            // 
            // gb_Prendas
            // 
            this.gb_Prendas.Controls.Add(this.radioButton_Pantalon);
            this.gb_Prendas.Controls.Add(this.checkBox_mangaLarga);
            this.gb_Prendas.Controls.Add(this.radioButton_Camisa);
            this.gb_Prendas.Controls.Add(this.checkBox_cuelloMao);
            this.gb_Prendas.Controls.Add(this.checkBox_chupin);
            this.gb_Prendas.Location = new System.Drawing.Point(77, 239);
            this.gb_Prendas.Name = "gb_Prendas";
            this.gb_Prendas.Size = new System.Drawing.Size(497, 125);
            this.gb_Prendas.TabIndex = 18;
            this.gb_Prendas.TabStop = false;
            this.gb_Prendas.Text = "Prendas";
            // 
            // gb_calidadPrendas
            // 
            this.gb_calidadPrendas.Controls.Add(this.radioButton_stadard);
            this.gb_calidadPrendas.Controls.Add(this.radioButton_Premium);
            this.gb_calidadPrendas.Location = new System.Drawing.Point(77, 473);
            this.gb_calidadPrendas.Name = "gb_calidadPrendas";
            this.gb_calidadPrendas.Size = new System.Drawing.Size(251, 89);
            this.gb_calidadPrendas.TabIndex = 19;
            this.gb_calidadPrendas.TabStop = false;
            this.gb_calidadPrendas.Text = "Calidad de las prendas";
            // 
            // radioButton_stadard
            // 
            this.radioButton_stadard.AutoSize = true;
            this.radioButton_stadard.Location = new System.Drawing.Point(5, 41);
            this.radioButton_stadard.Name = "radioButton_stadard";
            this.radioButton_stadard.Size = new System.Drawing.Size(108, 29);
            this.radioButton_stadard.TabIndex = 13;
            this.radioButton_stadard.TabStop = true;
            this.radioButton_stadard.Text = "Standard";
            this.radioButton_stadard.UseVisualStyleBackColor = true;
            // 
            // radioButton_Premium
            // 
            this.radioButton_Premium.AutoSize = true;
            this.radioButton_Premium.Location = new System.Drawing.Point(137, 39);
            this.radioButton_Premium.Name = "radioButton_Premium";
            this.radioButton_Premium.Size = new System.Drawing.Size(108, 29);
            this.radioButton_Premium.TabIndex = 12;
            this.radioButton_Premium.TabStop = true;
            this.radioButton_Premium.Text = "Premium";
            this.radioButton_Premium.UseVisualStyleBackColor = true;
            // 
            // gb_precioYCantidad
            // 
            this.gb_precioYCantidad.Location = new System.Drawing.Point(334, 473);
            this.gb_precioYCantidad.Name = "gb_precioYCantidad";
            this.gb_precioYCantidad.Size = new System.Drawing.Size(240, 89);
            this.gb_precioYCantidad.TabIndex = 20;
            this.gb_precioYCantidad.TabStop = false;
            this.gb_precioYCantidad.Text = "Precio Unitario y cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cotizador Express";
            // 
            // label_nombreTienda
            // 
            this.label_nombreTienda.AutoSize = true;
            this.label_nombreTienda.Location = new System.Drawing.Point(77, 123);
            this.label_nombreTienda.Name = "label_nombreTienda";
            this.label_nombreTienda.Size = new System.Drawing.Size(135, 25);
            this.label_nombreTienda.TabIndex = 22;
            this.label_nombreTienda.Text = "Nombre Tienda";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(345, 123);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(185, 25);
            this.label_direccion.TabIndex = 23;
            this.label_direccion.Text = "Direccion de la Tienda";
            // 
            // label_nombreVendedor
            // 
            this.label_nombreVendedor.AutoSize = true;
            this.label_nombreVendedor.Location = new System.Drawing.Point(77, 178);
            this.label_nombreVendedor.Name = "label_nombreVendedor";
            this.label_nombreVendedor.Size = new System.Drawing.Size(160, 25);
            this.label_nombreVendedor.TabIndex = 24;
            this.label_nombreVendedor.Text = "Nombre Vendedor";
            // 
            // linkLabel_historial
            // 
            this.linkLabel_historial.AutoSize = true;
            this.linkLabel_historial.Location = new System.Drawing.Point(396, 177);
            this.linkLabel_historial.Name = "linkLabel_historial";
            this.linkLabel_historial.Size = new System.Drawing.Size(181, 25);
            this.linkLabel_historial.TabIndex = 25;
            this.linkLabel_historial.TabStop = true;
            this.linkLabel_historial.Text = "Historial Cotizaciones";
            this.linkLabel_historial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_historial_LinkClicked);
            // 
            // listView_historialCotizaciones
            // 
            this.listView_historialCotizaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_historialCotizaciones.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_historialCotizaciones.Location = new System.Drawing.Point(38, 675);
            this.listView_historialCotizaciones.Name = "listView_historialCotizaciones";
            this.listView_historialCotizaciones.Size = new System.Drawing.Size(581, 185);
            this.listView_historialCotizaciones.TabIndex = 26;
            this.listView_historialCotizaciones.UseCompatibleStateImageBehavior = false;
            this.listView_historialCotizaciones.View = System.Windows.Forms.View.Details;
            this.listView_historialCotizaciones.SelectedIndexChanged += new System.EventHandler(this.listView_historialCotizaciones_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cotizaciones";
            this.columnHeader1.Width = 560;
            // 
            // label_stockActual
            // 
            this.label_stockActual.AutoSize = true;
            this.label_stockActual.Location = new System.Drawing.Point(247, 402);
            this.label_stockActual.Name = "label_stockActual";
            this.label_stockActual.Size = new System.Drawing.Size(47, 25);
            this.label_stockActual.TabIndex = 27;
            this.label_stockActual.Text = "_____";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 898);
            this.Controls.Add(this.label_stockActual);
            this.Controls.Add(this.listView_historialCotizaciones);
            this.Controls.Add(this.linkLabel_historial);
            this.Controls.Add(this.label_nombreVendedor);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_nombreTienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_precioFinal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_cotizar);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.textBox_precioUnitario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gb_Prendas);
            this.Controls.Add(this.gb_precioYCantidad);
            this.Controls.Add(this.gb_calidadPrendas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Prendas.ResumeLayout(false);
            this.gb_Prendas.PerformLayout();
            this.gb_calidadPrendas.ResumeLayout(false);
            this.gb_calidadPrendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private RadioButton radioButton_Camisa;
        private RadioButton radioButton_Pantalon;
        private CheckBox checkBox_mangaLarga;
        private CheckBox checkBox_cuelloMao;
        private CheckBox checkBox_chupin;
        private TextBox textBox_precioUnitario;
        private TextBox textBox_cantidad;
        private Button button_cotizar;
        private Label label7;
        private Label label_precioFinal;
        private GroupBox gb_Prendas;
        private GroupBox gb_calidadPrendas;
        private GroupBox gb_precioYCantidad;
        private RadioButton radioButton_Premium;
        private RadioButton radioButton_stadard;
        private Label label1;
        private Label label_nombreTienda;
        private Label label_direccion;
        private Label label_nombreVendedor;
        private LinkLabel linkLabel_historial;
        private ListView listView_historialCotizaciones;
        //private TextBox textBox1;
        private ColumnHeader columnHeader1;
        private Label label_stockActual;
    }
}