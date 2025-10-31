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
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.lblMozo = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblTotalComida = new System.Windows.Forms.Label();
            this.lblTotalSinAlcohol = new System.Windows.Forms.Label();
            this.lblTotalBebidasCAlcohol = new System.Windows.Forms.Label();
            this.lblTotalPostres = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMozo,
            this.colComida,
            this.colBebSinAlcohol,
            this.colBebConAlcohol,
            this.colPostres});
            this.dgvVentas.Location = new System.Drawing.Point(12, 3);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(543, 332);
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
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(566, 166);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(91, 39);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnTotales
            // 
            this.btnTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotales.Location = new System.Drawing.Point(346, 359);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(91, 39);
            this.btnTotales.TabIndex = 2;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // btnMozo
            // 
            this.btnMozo.Location = new System.Drawing.Point(12, 359);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(91, 39);
            this.btnMozo.TabIndex = 3;
            this.btnMozo.Text = "Mozo del Día";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMozo.Location = new System.Drawing.Point(126, 359);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(0, 15);
            this.lblMozo.TabIndex = 4;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotales.Location = new System.Drawing.Point(443, 350);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(98, 15);
            this.lblTotales.TabIndex = 5;
            this.lblTotales.Text = "Total General:";
            // 
            // lblTotalComida
            // 
            this.lblTotalComida.AutoSize = true;
            this.lblTotalComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComida.Location = new System.Drawing.Point(443, 372);
            this.lblTotalComida.Name = "lblTotalComida";
            this.lblTotalComida.Size = new System.Drawing.Size(121, 15);
            this.lblTotalComida.TabIndex = 6;
            this.lblTotalComida.Text = "Total por Comida:";
            // 
            // lblTotalSinAlcohol
            // 
            this.lblTotalSinAlcohol.AutoSize = true;
            this.lblTotalSinAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSinAlcohol.Location = new System.Drawing.Point(443, 397);
            this.lblTotalSinAlcohol.Name = "lblTotalSinAlcohol";
            this.lblTotalSinAlcohol.Size = new System.Drawing.Size(173, 15);
            this.lblTotalSinAlcohol.TabIndex = 7;
            this.lblTotalSinAlcohol.Text = "Total Bebidas sin Alcohol:";
            // 
            // lblTotalBebidasCAlcohol
            // 
            this.lblTotalBebidasCAlcohol.AutoSize = true;
            this.lblTotalBebidasCAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBebidasCAlcohol.Location = new System.Drawing.Point(443, 423);
            this.lblTotalBebidasCAlcohol.Name = "lblTotalBebidasCAlcohol";
            this.lblTotalBebidasCAlcohol.Size = new System.Drawing.Size(177, 15);
            this.lblTotalBebidasCAlcohol.TabIndex = 8;
            this.lblTotalBebidasCAlcohol.Text = "Total Bebidas con Alcohol:";
            // 
            // lblTotalPostres
            // 
            this.lblTotalPostres.AutoSize = true;
            this.lblTotalPostres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPostres.Location = new System.Drawing.Point(443, 446);
            this.lblTotalPostres.Name = "lblTotalPostres";
            this.lblTotalPostres.Size = new System.Drawing.Size(121, 15);
            this.lblTotalPostres.TabIndex = 9;
            this.lblTotalPostres.Text = "Total Por Postres:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(566, 221);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 39);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmBarMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 511);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTotalPostres);
            this.Controls.Add(this.lblTotalBebidasCAlcohol);
            this.Controls.Add(this.lblTotalSinAlcohol);
            this.Controls.Add(this.lblTotalComida);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.lblMozo);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBarMilanga";
            this.Text = "Bar Milanga";
            this.Load += new System.EventHandler(this.frmBarMilanga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebSinAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBebConAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostres;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblTotalComida;
        private System.Windows.Forms.Label lblTotalSinAlcohol;
        private System.Windows.Forms.Label lblTotalBebidasCAlcohol;
        private System.Windows.Forms.Label lblTotalPostres;
        private System.Windows.Forms.Button btnCerrar;
    }
}

