namespace pryComettoMascota
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnCuidar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblNombreCrear = new System.Windows.Forms.Label();
            this.mrcAcciones = new System.Windows.Forms.GroupBox();
            this.prbCuidar = new System.Windows.Forms.ProgressBar();
            this.prbJugar = new System.Windows.Forms.ProgressBar();
            this.prbAlimentar = new System.Windows.Forms.ProgressBar();
            this.mrcCrearMascota = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstMascotasForm = new System.Windows.Forms.ListBox();
            this.lblEdadCrear = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tmrNecesidades = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.mrcAcciones.SuspendLayout();
            this.mrcCrearMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(6, 19);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(106, 55);
            this.btnAlimentar.TabIndex = 0;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnCuidar
            // 
            this.btnCuidar.Location = new System.Drawing.Point(6, 141);
            this.btnCuidar.Name = "btnCuidar";
            this.btnCuidar.Size = new System.Drawing.Size(106, 55);
            this.btnCuidar.TabIndex = 2;
            this.btnCuidar.Text = "Cuidar";
            this.btnCuidar.UseVisualStyleBackColor = true;
            this.btnCuidar.Click += new System.EventHandler(this.btnCuidar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(6, 80);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(106, 55);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(270, 18);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cmbTipo.Location = new System.Drawing.Point(115, 36);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(242, 37);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(58, 20);
            this.nudEdad.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(322, 29);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(74, 33);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblNombreCrear
            // 
            this.lblNombreCrear.AutoSize = true;
            this.lblNombreCrear.Location = new System.Drawing.Point(6, 20);
            this.lblNombreCrear.Name = "lblNombreCrear";
            this.lblNombreCrear.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCrear.TabIndex = 4;
            this.lblNombreCrear.Text = "Nombre:";
            // 
            // mrcAcciones
            // 
            this.mrcAcciones.Controls.Add(this.prbCuidar);
            this.mrcAcciones.Controls.Add(this.prbJugar);
            this.mrcAcciones.Controls.Add(this.prbAlimentar);
            this.mrcAcciones.Controls.Add(this.btnAlimentar);
            this.mrcAcciones.Controls.Add(this.btnCuidar);
            this.mrcAcciones.Controls.Add(this.btnJugar);
            this.mrcAcciones.Enabled = false;
            this.mrcAcciones.Location = new System.Drawing.Point(318, 12);
            this.mrcAcciones.Name = "mrcAcciones";
            this.mrcAcciones.Size = new System.Drawing.Size(230, 204);
            this.mrcAcciones.TabIndex = 1;
            this.mrcAcciones.TabStop = false;
            this.mrcAcciones.Text = "Acciones";
            // 
            // prbCuidar
            // 
            this.prbCuidar.Location = new System.Drawing.Point(118, 155);
            this.prbCuidar.Name = "prbCuidar";
            this.prbCuidar.Size = new System.Drawing.Size(100, 23);
            this.prbCuidar.TabIndex = 6;
            // 
            // prbJugar
            // 
            this.prbJugar.Location = new System.Drawing.Point(118, 94);
            this.prbJugar.Name = "prbJugar";
            this.prbJugar.Size = new System.Drawing.Size(100, 23);
            this.prbJugar.TabIndex = 5;
            // 
            // prbAlimentar
            // 
            this.prbAlimentar.Location = new System.Drawing.Point(118, 35);
            this.prbAlimentar.Name = "prbAlimentar";
            this.prbAlimentar.Size = new System.Drawing.Size(100, 23);
            this.prbAlimentar.TabIndex = 4;
            // 
            // mrcCrearMascota
            // 
            this.mrcCrearMascota.Controls.Add(this.btnEliminar);
            this.mrcCrearMascota.Controls.Add(this.lstMascotasForm);
            this.mrcCrearMascota.Controls.Add(this.lblEdadCrear);
            this.mrcCrearMascota.Controls.Add(this.lblTipo);
            this.mrcCrearMascota.Controls.Add(this.lblNombreCrear);
            this.mrcCrearMascota.Controls.Add(this.cmbTipo);
            this.mrcCrearMascota.Controls.Add(this.btnCrear);
            this.mrcCrearMascota.Controls.Add(this.txtNombre);
            this.mrcCrearMascota.Controls.Add(this.nudEdad);
            this.mrcCrearMascota.Location = new System.Drawing.Point(12, 318);
            this.mrcCrearMascota.Name = "mrcCrearMascota";
            this.mrcCrearMascota.Size = new System.Drawing.Size(402, 195);
            this.mrcCrearMascota.TabIndex = 0;
            this.mrcCrearMascota.TabStop = false;
            this.mrcCrearMascota.Text = "Crear Mascota";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(322, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 33);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstMascotasForm
            // 
            this.lstMascotasForm.FormattingEnabled = true;
            this.lstMascotasForm.Location = new System.Drawing.Point(9, 68);
            this.lstMascotasForm.Name = "lstMascotasForm";
            this.lstMascotasForm.Size = new System.Drawing.Size(291, 121);
            this.lstMascotasForm.TabIndex = 4;
            this.lstMascotasForm.SelectedIndexChanged += new System.EventHandler(this.lstMascotasForm_SelectedIndexChanged);
            // 
            // lblEdadCrear
            // 
            this.lblEdadCrear.AutoSize = true;
            this.lblEdadCrear.Location = new System.Drawing.Point(239, 21);
            this.lblEdadCrear.Name = "lblEdadCrear";
            this.lblEdadCrear.Size = new System.Drawing.Size(35, 13);
            this.lblEdadCrear.TabIndex = 6;
            this.lblEdadCrear.Text = "Edad:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(112, 20);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo:";
            // 
            // tmrNecesidades
            // 
            this.tmrNecesidades.Interval = 1000;
            this.tmrNecesidades.Tick += new System.EventHandler(this.tmrNecesidades_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 517);
            this.Controls.Add(this.mrcCrearMascota);
            this.Controls.Add(this.mrcAcciones);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mascopet";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.mrcAcciones.ResumeLayout(false);
            this.mrcCrearMascota.ResumeLayout(false);
            this.mrcCrearMascota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnCuidar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblNombreCrear;
        private System.Windows.Forms.GroupBox mrcAcciones;
        private System.Windows.Forms.GroupBox mrcCrearMascota;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEdadCrear;
        private System.Windows.Forms.ProgressBar prbCuidar;
        private System.Windows.Forms.ProgressBar prbJugar;
        private System.Windows.Forms.ProgressBar prbAlimentar;
        private System.Windows.Forms.Timer tmrNecesidades;
        private System.Windows.Forms.ListBox lstMascotasForm;
        private System.Windows.Forms.Button btnEliminar;
    }
}

