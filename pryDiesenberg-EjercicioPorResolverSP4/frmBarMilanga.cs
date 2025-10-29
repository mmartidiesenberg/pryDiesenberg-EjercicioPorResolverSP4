using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_EjercicioPorResolverSP4
{
    public partial class frmBarMilanga : Form
    {
        public frmBarMilanga()
        {
            InitializeComponent();
        }

        float[,] matVentas = new float[5, 4];

        private void frmBarMilanga_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add("Julio");
            dgvVentas.Rows.Add("Esteban");
            dgvVentas.Rows.Add("Javier");
            dgvVentas.Rows.Add("Gonzalo");
            dgvVentas.Rows.Add("Alberto");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CalcularTotales()
        {
            double totalComida = 0;
            double totalBebSinAlcohol = 0;
            double totalBebConAlcohol = 0;
            double totalPostres = 0;

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                if (fila.Cells["colComida"].Value != null)
                    totalComida += Convert.ToDouble(fila.Cells["colComida"].Value);
                if (fila.Cells["colBebidaSinAlcohol"].Value != null)
                    totalBebSinAlcohol += Convert.ToDouble(fila.Cells["colBebidaSinAlcohol"].Value);
                if (fila.Cells["colBebidaConAlcohol"].Value != null)
                    totalBebConAlcohol += Convert.ToDouble(fila.Cells["colBebidaConAlcohol"].Value);
                if (fila.Cells["colPostres"].Value != null)
                    totalPostres += Convert.ToDouble(fila.Cells["colPostres"].Value);
            }

            double totalGeneral = totalComida + totalBebSinAlcohol + totalBebConAlcohol + totalPostres;

            lblTotales.Text = totalGeneral.ToString("C");
            lblTotalComida.Text = totalComida.ToString("C");
            lblTotalSinAlcohol.Text = totalBebSinAlcohol.ToString("C");
            lblTotalBebidasCAlcohol.Text = totalBebConAlcohol.ToString("C");
            lblTotalPostres.Text = totalPostres.ToString("C");
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            for (int indiceFilas = 0; indiceFilas < dgvVentas.Rows.Count; indiceFilas++)
            {
                for (int indiceColumnas = 1; indiceColumnas < dgvVentas.Columns.Count; indiceColumnas++) {
                    {
                        if (dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value != null)
                        {
                            string valor = dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value.ToString();
                            float numero;
                            if (float.TryParse(valor, out numero))
                            {
                                dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "si";
                            }
                            else
                            {
                                dgvVentas.Rows[indiceFilas].Cells[indiceColumnas].Value = "no";
                            }
                        }

                    }
                }
            }
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            CalcularTotales();
        }
    }
}
