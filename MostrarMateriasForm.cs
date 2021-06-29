using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty
{
    public partial class MostrarMateriasForm : Form
    {
        private ControlEscolar controlEscolar;
        public MostrarMateriasForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
        }
        private void MostrarMateriasForm_Load(object sender, EventArgs e)
        {
            dgvMostrarMaterias.DataSource = controlEscolar.GetMaterias();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
