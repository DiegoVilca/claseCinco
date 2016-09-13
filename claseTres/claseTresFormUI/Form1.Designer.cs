namespace claseTresFormUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.gpbListaAutos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lbsListado = new System.Windows.Forms.ListBox();
            this.txtGanador = new System.Windows.Forms.TextBox();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.cmbCorrerCarrera = new System.Windows.Forms.ComboBox();
            this.gpbCarrera.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            this.gpbListaAutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(22, 80);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(103, 23);
            this.btnCrearCarrera.TabIndex = 0;
            this.btnCrearCarrera.Text = "Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.txtFecha);
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Controls.Add(this.btnCrearCarrera);
            this.gpbCarrera.Location = new System.Drawing.Point(41, 12);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(696, 118);
            this.gpbCarrera.TabIndex = 1;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.cmbFabricante);
            this.gpbAutos.Controls.Add(this.btnAgregarAuto);
            this.gpbAutos.Controls.Add(this.lblNombrePiloto);
            this.gpbAutos.Controls.Add(this.txtNombrePiloto);
            this.gpbAutos.Controls.Add(this.lblFabricante);
            this.gpbAutos.Location = new System.Drawing.Point(412, 149);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(325, 127);
            this.gpbAutos.TabIndex = 2;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Autos";
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.cmbCorrerCarrera);
            this.gpbResultados.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultados.Controls.Add(this.txtGanador);
            this.gpbResultados.Location = new System.Drawing.Point(41, 136);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(344, 127);
            this.gpbResultados.TabIndex = 3;
            this.gpbResultados.TabStop = false;
            this.gpbResultados.Text = "Resultados";
            // 
            // gpbListaAutos
            // 
            this.gpbListaAutos.Controls.Add(this.lbsListado);
            this.gpbListaAutos.Location = new System.Drawing.Point(47, 282);
            this.gpbListaAutos.Name = "gpbListaAutos";
            this.gpbListaAutos.Size = new System.Drawing.Size(702, 186);
            this.gpbListaAutos.TabIndex = 4;
            this.gpbListaAutos.TabStop = false;
            this.gpbListaAutos.Text = "Lista de autos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(255, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(258, 44);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(479, 20);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 6;
            this.lblLugar.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(482, 44);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(24, 27);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 6;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(152, 27);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(90, 13);
            this.lblNombrePiloto.TabIndex = 8;
            this.lblNombrePiloto.Text = "Nombre del Piloto";
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(155, 51);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePiloto.TabIndex = 7;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(27, 90);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarAuto.TabIndex = 9;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(27, 51);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(103, 21);
            this.cmbFabricante.TabIndex = 10;
            // 
            // lbsListado
            // 
            this.lbsListado.FormattingEnabled = true;
            this.lbsListado.Location = new System.Drawing.Point(43, 19);
            this.lbsListado.Name = "lbsListado";
            this.lbsListado.Size = new System.Drawing.Size(295, 147);
            this.lbsListado.TabIndex = 0;
            // 
            // txtGanador
            // 
            this.txtGanador.Location = new System.Drawing.Point(192, 90);
            this.txtGanador.Name = "txtGanador";
            this.txtGanador.Size = new System.Drawing.Size(100, 20);
            this.txtGanador.TabIndex = 0;
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(22, 90);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(100, 23);
            this.btnCorrerCarrera.TabIndex = 1;
            this.btnCorrerCarrera.Text = "Correr Carrera";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.btnCorrerCarrera_Click);
            // 
            // cmbCorrerCarrera
            // 
            this.cmbCorrerCarrera.FormattingEnabled = true;
            this.cmbCorrerCarrera.Location = new System.Drawing.Point(25, 40);
            this.cmbCorrerCarrera.Name = "cmbCorrerCarrera";
            this.cmbCorrerCarrera.Size = new System.Drawing.Size(97, 21);
            this.cmbCorrerCarrera.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 526);
            this.Controls.Add(this.gpbListaAutos);
            this.Controls.Add(this.gpbResultados);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            this.gpbResultados.PerformLayout();
            this.gpbListaAutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.GroupBox gpbListaAutos;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lbsListado;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.TextBox txtGanador;
        private System.Windows.Forms.ComboBox cmbCorrerCarrera;
    }
}

