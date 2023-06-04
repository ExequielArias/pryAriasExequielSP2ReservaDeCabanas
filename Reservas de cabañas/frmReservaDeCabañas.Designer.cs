namespace Reservas_de_cabañas
{
    partial class frmReservaDeCabañas
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
            this.mrcReservarCabañas = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.mrcFormasDePago = new System.Windows.Forms.GroupBox();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.cboTarjetas = new System.Windows.Forms.ComboBox();
            this.mrcTitularDeLaReserva = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.mrcReservarCabañas.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormasDePago.SuspendLayout();
            this.mrcTitularDeLaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcReservarCabañas
            // 
            this.mrcReservarCabañas.Controls.Add(this.txtDias);
            this.mrcReservarCabañas.Controls.Add(this.cboPersonas);
            this.mrcReservarCabañas.Controls.Add(this.cboTipo);
            this.mrcReservarCabañas.Controls.Add(this.lblDias);
            this.mrcReservarCabañas.Controls.Add(this.lblPersonas);
            this.mrcReservarCabañas.Controls.Add(this.lblTipo);
            this.mrcReservarCabañas.Location = new System.Drawing.Point(12, 12);
            this.mrcReservarCabañas.Name = "mrcReservarCabañas";
            this.mrcReservarCabañas.Size = new System.Drawing.Size(587, 90);
            this.mrcReservarCabañas.TabIndex = 0;
            this.mrcReservarCabañas.TabStop = false;
            this.mrcReservarCabañas.Text = "Tipo De Cabañas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(10, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 19);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(218, 44);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(70, 19);
            this.lblPersonas.TabIndex = 1;
            this.lblPersonas.Text = "Personas";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(465, 40);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(37, 19);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboTipo.Location = new System.Drawing.Point(55, 42);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(142, 21);
            this.cboTipo.TabIndex = 3;
            // 
            // cboPersonas
            // 
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Location = new System.Drawing.Point(294, 42);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(142, 21);
            this.cboPersonas.TabIndex = 4;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(508, 40);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(58, 20);
            this.txtDias.TabIndex = 5;
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevisor);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Location = new System.Drawing.Point(12, 108);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(157, 148);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(6, 36);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(6, 69);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(6, 101);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(69, 17);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // mrcFormasDePago
            // 
            this.mrcFormasDePago.Controls.Add(this.cboTarjetas);
            this.mrcFormasDePago.Controls.Add(this.lblTarjetas);
            this.mrcFormasDePago.Controls.Add(this.optTarjeta);
            this.mrcFormasDePago.Controls.Add(this.optEfectivo);
            this.mrcFormasDePago.Location = new System.Drawing.Point(175, 108);
            this.mrcFormasDePago.Name = "mrcFormasDePago";
            this.mrcFormasDePago.Size = new System.Drawing.Size(424, 147);
            this.mrcFormasDePago.TabIndex = 2;
            this.mrcFormasDePago.TabStop = false;
            this.mrcFormasDePago.Text = "Formas De Pago";
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(38, 36);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(38, 69);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(139, 71);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(48, 13);
            this.lblTarjetas.TabIndex = 2;
            this.lblTarjetas.Text = "Tarjetas:";
            // 
            // cboTarjetas
            // 
            this.cboTarjetas.FormattingEnabled = true;
            this.cboTarjetas.Location = new System.Drawing.Point(142, 99);
            this.cboTarjetas.Name = "cboTarjetas";
            this.cboTarjetas.Size = new System.Drawing.Size(247, 21);
            this.cboTarjetas.TabIndex = 3;
            // 
            // mrcTitularDeLaReserva
            // 
            this.mrcTitularDeLaReserva.Controls.Add(this.txtNombre);
            this.mrcTitularDeLaReserva.Controls.Add(this.txtTelefonos);
            this.mrcTitularDeLaReserva.Controls.Add(this.lblTelefonos);
            this.mrcTitularDeLaReserva.Controls.Add(this.lblNombre);
            this.mrcTitularDeLaReserva.Location = new System.Drawing.Point(12, 262);
            this.mrcTitularDeLaReserva.Name = "mrcTitularDeLaReserva";
            this.mrcTitularDeLaReserva.Size = new System.Drawing.Size(587, 103);
            this.mrcTitularDeLaReserva.TabIndex = 3;
            this.mrcTitularDeLaReserva.TabStop = false;
            this.mrcTitularDeLaReserva.Text = "Titular De La Reserva";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(22, 64);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(54, 13);
            this.lblTelefonos.TabIndex = 1;
            this.lblTelefonos.Text = "Telefonos";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(82, 61);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(484, 20);
            this.txtTelefonos.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(484, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(477, 384);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(111, 40);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // frmReservaDeCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 436);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.mrcTitularDeLaReserva);
            this.Controls.Add(this.mrcFormasDePago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcReservarCabañas);
            this.Name = "frmReservaDeCabañas";
            this.Text = "Reserva De cabañas";
            this.mrcReservarCabañas.ResumeLayout(false);
            this.mrcReservarCabañas.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormasDePago.ResumeLayout(false);
            this.mrcFormasDePago.PerformLayout();
            this.mrcTitularDeLaReserva.ResumeLayout(false);
            this.mrcTitularDeLaReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcReservarCabañas;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mrcFormasDePago;
        private System.Windows.Forms.ComboBox cboTarjetas;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox mrcTitularDeLaReserva;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cmdAceptar;
    }
}