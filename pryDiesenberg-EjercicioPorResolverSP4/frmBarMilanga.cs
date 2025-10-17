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
    }
}
