namespace MainCorreo
{
    partial class FrmPal
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
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxEntregado = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxEnViaje = new System.Windows.Forms.ListBox();
            this.lbxIngresado = new System.Windows.Forms.ListBox();
            this.gbPaquete = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.mtbTrackingId = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.gbEstado.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.label3);
            this.gbEstado.Controls.Add(this.label2);
            this.gbEstado.Controls.Add(this.label1);
            this.gbEstado.Controls.Add(this.lbxEntregado);
            this.gbEstado.Controls.Add(this.lbxEnViaje);
            this.gbEstado.Controls.Add(this.lbxIngresado);
            this.gbEstado.Location = new System.Drawing.Point(12, 12);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(752, 240);
            this.gbEstado.TabIndex = 0;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado Paquetes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Entregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "En viaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresado";
            // 
            // lbxEntregado
            // 
            this.lbxEntregado.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxEntregado.FormattingEnabled = true;
            this.lbxEntregado.Location = new System.Drawing.Point(522, 48);
            this.lbxEntregado.Name = "lbxEntregado";
            this.lbxEntregado.Size = new System.Drawing.Size(215, 186);
            this.lbxEntregado.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.MostrarToolStripMenuItem_Click);
            // 
            // lbxEnViaje
            // 
            this.lbxEnViaje.FormattingEnabled = true;
            this.lbxEnViaje.Location = new System.Drawing.Point(267, 48);
            this.lbxEnViaje.Name = "lbxEnViaje";
            this.lbxEnViaje.Size = new System.Drawing.Size(215, 186);
            this.lbxEnViaje.TabIndex = 1;
            // 
            // lbxIngresado
            // 
            this.lbxIngresado.FormattingEnabled = true;
            this.lbxIngresado.Location = new System.Drawing.Point(15, 48);
            this.lbxIngresado.Name = "lbxIngresado";
            this.lbxIngresado.Size = new System.Drawing.Size(215, 186);
            this.lbxIngresado.TabIndex = 0;
            // 
            // gbPaquete
            // 
            this.gbPaquete.Controls.Add(this.btnMostrar);
            this.gbPaquete.Controls.Add(this.btnAgregar);
            this.gbPaquete.Controls.Add(this.tbDireccion);
            this.gbPaquete.Controls.Add(this.mtbTrackingId);
            this.gbPaquete.Controls.Add(this.label5);
            this.gbPaquete.Controls.Add(this.label4);
            this.gbPaquete.Location = new System.Drawing.Point(460, 258);
            this.gbPaquete.Name = "gbPaquete";
            this.gbPaquete.Size = new System.Drawing.Size(304, 131);
            this.gbPaquete.TabIndex = 0;
            this.gbPaquete.TabStop = false;
            this.gbPaquete.Text = "Paquete";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(201, 76);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 39);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar Todos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(201, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 39);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(21, 92);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(174, 20);
            this.tbDireccion.TabIndex = 7;
            // 
            // mtbTrackingId
            // 
            this.mtbTrackingId.Location = new System.Drawing.Point(21, 43);
            this.mtbTrackingId.Mask = "000-000-0000";
            this.mtbTrackingId.Name = "mtbTrackingId";
            this.mtbTrackingId.Size = new System.Drawing.Size(174, 20);
            this.mtbTrackingId.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tracking ID";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Enabled = false;
            this.rtbMostrar.Location = new System.Drawing.Point(12, 258);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(442, 131);
            this.rtbMostrar.TabIndex = 6;
            this.rtbMostrar.Text = "";
            // 
            // FrmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 395);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.gbPaquete);
            this.Controls.Add(this.gbEstado);
            this.Name = "FrmPal";
            this.Text = "Massimo Di Berardino";
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbPaquete.ResumeLayout(false);
            this.gbPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.GroupBox gbPaquete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxEntregado;
        private System.Windows.Forms.ListBox lbxEnViaje;
        private System.Windows.Forms.ListBox lbxIngresado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.MaskedTextBox mtbTrackingId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

