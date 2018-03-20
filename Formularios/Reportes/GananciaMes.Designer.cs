namespace Formularios.Reportes
{
    partial class GananciaMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GananciaMes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcularGanancia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtSegundaFechaPeriodo = new System.Windows.Forms.DateTimePicker();
            this.dtPrimerFechaPeriodo = new System.Windows.Forms.DateTimePicker();
            this.gridVentasPeriodo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentasPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcularGanancia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtSegundaFechaPeriodo);
            this.groupBox1.Controls.Add(this.dtPrimerFechaPeriodo);
            this.groupBox1.Location = new System.Drawing.Point(22, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar el Período";
            // 
            // btnCalcularGanancia
            // 
            this.btnCalcularGanancia.Location = new System.Drawing.Point(884, 34);
            this.btnCalcularGanancia.Name = "btnCalcularGanancia";
            this.btnCalcularGanancia.Size = new System.Drawing.Size(110, 49);
            this.btnCalcularGanancia.TabIndex = 4;
            this.btnCalcularGanancia.Text = "Calcular Balance";
            this.btnCalcularGanancia.UseVisualStyleBackColor = true;
            this.btnCalcularGanancia.Click += new System.EventHandler(this.btnCalcularGanancia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde";
            // 
            // dtSegundaFechaPeriodo
            // 
            this.dtSegundaFechaPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSegundaFechaPeriodo.Location = new System.Drawing.Point(94, 74);
            this.dtSegundaFechaPeriodo.Name = "dtSegundaFechaPeriodo";
            this.dtSegundaFechaPeriodo.Size = new System.Drawing.Size(200, 22);
            this.dtSegundaFechaPeriodo.TabIndex = 1;
            // 
            // dtPrimerFechaPeriodo
            // 
            this.dtPrimerFechaPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrimerFechaPeriodo.Location = new System.Drawing.Point(94, 35);
            this.dtPrimerFechaPeriodo.Name = "dtPrimerFechaPeriodo";
            this.dtPrimerFechaPeriodo.Size = new System.Drawing.Size(200, 22);
            this.dtPrimerFechaPeriodo.TabIndex = 0;
            // 
            // gridVentasPeriodo
            // 
            this.gridVentasPeriodo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridVentasPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentasPeriodo.Location = new System.Drawing.Point(22, 150);
            this.gridVentasPeriodo.Name = "gridVentasPeriodo";
            this.gridVentasPeriodo.RowTemplate.Height = 24;
            this.gridVentasPeriodo.Size = new System.Drawing.Size(1086, 577);
            this.gridVentasPeriodo.TabIndex = 2;
            // 
            // GananciaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1212, 766);
            this.Controls.Add(this.gridVentasPeriodo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GananciaMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comisión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GananciaMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentasPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcularGanancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtSegundaFechaPeriodo;
        private System.Windows.Forms.DateTimePicker dtPrimerFechaPeriodo;
        private System.Windows.Forms.DataGridView gridVentasPeriodo;
    }
}