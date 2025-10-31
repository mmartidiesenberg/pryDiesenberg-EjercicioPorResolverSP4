using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            float[,] ventas = new float[5, 4]; // matriz local, se carga desde la grilla

            float totalGeneral = 0;
            float[] totalesPorCategoria = new float[4]; // 0: Comida, 1: Sin Alcohol, 2: Con Alcohol, 3: Postres

            for (int fila = 0; fila < 5; fila++)
            {
                for (int col = 1; col < 5; col++) // columnas 1 a 4 (salteamos "Mozo")
                {
                    string celda = dgvVentas.Rows[fila].Cells[col].Value?.ToString().Trim();
                    float valor = 0;

                    if (!float.TryParse(celda, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
                    {
                        // Si hay error, lo ignoramos y seguimos con 0
                        valor = 0;
                    }

                    ventas[fila, col - 1] = valor;
                    totalesPorCategoria[col - 1] += valor;
                    totalGeneral += valor;
                }
            }

            // Mostrar resultados
            lblTotales.Text = $"Total General: ${totalGeneral}";
            lblTotalComida.Text = $"Total por Comida: ${totalesPorCategoria[0]}";
            lblTotalSinAlcohol.Text = $"Total Bebidas sin Alcohol: ${totalesPorCategoria[1]}";
            lblTotalBebidasCAlcohol.Text = $"Total Bebidas con Alcohol: ${totalesPorCategoria[2]}";
            lblTotalPostres.Text = $"Total por Postres: ${totalesPorCategoria[3]}";
        }
    }
}
