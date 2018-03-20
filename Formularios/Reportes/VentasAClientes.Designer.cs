namespace Formularios.Reportes
{
    partial class VentasAClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasAClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSegundaFecha = new System.Windows.Forms.DateTimePicker();
            this.dtPrimerFecha = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarGrillaVentasCliente = new System.Windows.Forms.Button();
            this.cbSeleccionarCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridVentasCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtSegundaFecha);
            this.groupBox1.Controls.Add(this.dtPrimerFecha);
            this.groupBox1.Controls.Add(this.btnActualizarGrillaVentasCliente);
            this.groupBox1.Controls.Add(this.cbSeleccionarCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Desde";
            // 
            // dtSegundaFecha
            // 
            this.dtSegundaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSegundaFecha.Location = new System.Drawing.Point(183, 99);
            this.dtSegundaFecha.Name = "dtSegundaFecha";
            this.dtSegundaFecha.Size = new System.Drawing.Size(263, 22);
            this.dtSegundaFecha.TabIndex = 4;
            // 
            // dtPrimerFecha
            // 
            this.dtPrimerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrimerFecha.Location = new System.Drawing.Point(183, 68);
            this.dtPrimerFecha.Name = "dtPrimerFecha";
            this.dtPrimerFecha.Size = new System.Drawing.Size(263, 22);
            this.dtPrimerFecha.TabIndex = 3;
            this.dtPrimerFecha.Value = new System.DateTime(2017, 11, 8, 0, 0, 0, 0);
            // 
            // btnActualizarGrillaVentasCliente
            // 
            this.btnActualizarGrillaVentasCliente.Location = new System.Drawing.Point(883, 30);
            this.btnActualizarGrillaVentasCliente.Name = "btnActualizarGrillaVentasCliente";
            this.btnActualizarGrillaVentasCliente.Size = new System.Drawing.Size(131, 63);
            this.btnActualizarGrillaVentasCliente.TabIndex = 2;
            this.btnActualizarGrillaVentasCliente.Text = "Buscar Ventas";
            this.btnActualizarGrillaVentasCliente.UseVisualStyleBackColor = true;
            this.btnActualizarGrillaVentasCliente.Click += new System.EventHandler(this.btnActualizarGrillaVentasCliente_Click);
            // 
            // cbSeleccionarCliente
            // 
            this.cbSeleccionarCliente.FormattingEnabled = true;
            this.cbSeleccionarCliente.Location = new System.Drawing.Point(183, 29);
            this.cbSeleccionarCliente.Name = "cbSeleccionarCliente";
            this.cbSeleccionarCliente.Size = new System.Drawing.Size(263, 24);
            this.cbSeleccionarCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Cliente";
            // 
            // gridVentasCliente
            // 
            this.gridVentasCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridVentasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentasCliente.Location = new System.Drawing.Point(23, 191);
            this.gridVentasCliente.Name = "gridVentasCliente";
            this.gridVentasCliente.RowTemplate.Height = 24;
            this.gridVentasCliente.Size = new System.Drawing.Size(1062, 528);
            this.gridVentasCliente.TabIndex = 2;
            // 
            // VentasAClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1147, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridVentasCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentasAClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasAClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentasAClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentasCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSegundaFecha;
        private System.Windows.Forms.DateTimePicker dtPrimerFecha;
        private System.Windows.Forms.Button btnActualizarGrillaVentasCliente;
        private System.Windows.Forms.ComboBox cbSeleccionarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridVentasCliente;
    }
}