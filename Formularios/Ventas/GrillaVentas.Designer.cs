namespace Formularios.Ventas
{
    partial class GrillaVentas
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
            this.gridGrillaVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrillaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGrillaVentas
            // 
            this.gridGrillaVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridGrillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrillaVentas.Location = new System.Drawing.Point(25, 79);
            this.gridGrillaVentas.Name = "gridGrillaVentas";
            this.gridGrillaVentas.RowTemplate.Height = 24;
            this.gridGrillaVentas.Size = new System.Drawing.Size(1417, 706);
            this.gridGrillaVentas.TabIndex = 0;
            this.gridGrillaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGrillaVentas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTADO DE VENTAS";
            // 
            // GrillaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1643, 851);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridGrillaVentas);
            this.Name = "GrillaVentas";
            this.Text = "Grilla Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GrillaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGrillaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGrillaVentas;
        private System.Windows.Forms.Label label1;
    }
}