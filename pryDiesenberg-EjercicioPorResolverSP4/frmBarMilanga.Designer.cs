namespace pryDiesenberg_EjercicioPorResolverSP4
{
    partial class frmBarMilanga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarMilanga));
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colMozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebSinAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBebConAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMozo,
            this.colComida,
            this.colBebSinAlcohol,
            this.colBebConAlcohol,
            this.colPostres});
            this.dgvVentas.Location = new System.Drawing.Point(108, 33);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(563, 202);
            this.dgvVentas.TabIndex = 0;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colMozo
            // 
            this.colMozo.HeaderText = "Mozo";
            this.colMozo.Name = "colMozo";
            // 
            // colComida
            // 
            this.colComida.HeaderText = "Comida";
            this.colComida.Name = "colComida";
            // 
            // colBebSinAlcohol
            // 
            this.colBebSinAlcohol.HeaderText = "Bebida Sin Alcohol";
            this.colBebSinAlcohol.Name = "colBebSinAlcohol";
            // 
            // colBebConAlcohol
            // 
            this.colBebConAlcohol.HeaderText = "Bebida Con Alcohol";
            this.colBebConAlcohol.Name = "colBebConAlcohol";
            // 
            // colPostres
            // 
            this.colPostres.HeaderText = "Postres";
            this.colPostres.Name = "colPostres";
            // 
            // frmBarMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBarMilanga";
            this.Text = "Bar Milanga";
            this.Load += new System.EventHandler(this.frmBarMilanga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebSinAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebConAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostres;
    }
}

