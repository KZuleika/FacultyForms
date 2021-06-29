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
    public partial class AltaAlumnosForm : Form
    {
        private ControlEscolar controlEscolar;
        public AltaAlumnosForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
        }

        public AltaAlumnosForm(ControlEscolar controlEscolar, string nombre, string apellido)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
            tbNombre.Text = nombre;
            tbApellido.Text = apellido;
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int matricula = 0;
            string nombre = tbNombre.Text;
            string apellido = tbApellido.Text;

            if(tbMatricula.Text.Trim().Length > 0) matricula = Convert.ToInt32(tbMatricula.Text.Trim());

            if (tbMatricula.Text.Trim().Length < 1 || tbApellido.Text.Trim().Length < 1 || tbNombre.Text.Trim().Length < 1) {
                switch (MessageBox.Show("Campo(s) vacio(s).\nRellene todos campos.",
                                 "Campo vacio",
                                 MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error))
                {
                    case DialogResult.Retry:
                        Close();
                        AltaAlumnosForm form = new AltaAlumnosForm(controlEscolar, nombre, apellido);
                        form.ShowDialog();
                        break;
                    default:
                    case DialogResult.Cancel:
                        Close();
                        break;
                }
                return;
            }

            if(!controlEscolar.AltaAlumno(matricula, apellido, nombre))
            {
                switch (MessageBox.Show("Matrícula actualmente en uso.\nIngrese otra matrícula.",
                                 "Matricula existente",
                                 MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Exclamation))
                {
                    case DialogResult.Retry:
                        Close();
                        AltaAlumnosForm form = new AltaAlumnosForm(controlEscolar, nombre, apellido);
                        form.ShowDialog();
                        break;
                    default:
                    case DialogResult.Cancel:
                        Close();
                        break;
                }
            }
        }
    }
}
