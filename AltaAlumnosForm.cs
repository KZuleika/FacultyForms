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

        public AltaAlumnosForm(ControlEscolar controlEscolar, int matricula, string nombre, string apellido)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
            tbMatricula.Text = matricula.ToString();
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

            if (tbMatricula.Text.Trim().Length > 0) matricula = Convert.ToInt32(tbMatricula.Text.Trim());

            //revisa que los campos estan vacios
            if (tbMatricula.Text.Trim().Length < 1 || tbApellido.Text.Trim().Length < 1 || tbNombre.Text.Trim().Length < 1) {
                switch (MessageBox.Show("Campo(s) vacio(s).\nRellene todos campos.",
                                 "Campo(s) vacio(s)",
                                 MessageBoxButtons.RetryCancel,
                                 MessageBoxIcon.Error))
                {
                    case DialogResult.Retry:
                        Close();
                        AltaAlumnosForm form = new AltaAlumnosForm(controlEscolar, matricula, nombre, apellido);
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
                        AltaAlumnosForm form = new AltaAlumnosForm(controlEscolar, matricula, nombre, apellido);
                        form.ShowDialog();
                        //break;
                        return;
                    default:
                    case DialogResult.Cancel:
                        Close();
                        //break;
                        return;
                }
            }
            MessageBox.Show("Alumno ingresado con éxito",
                                 "Alta exitosa",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void tbMatricula_TextChanged(object sender, EventArgs e)
        {
            if (tbMatricula.Text.Trim().Length > 3) btnGuardar.Enabled = true;
            else btnGuardar.Enabled = false;
        }

        private void tbMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }
    }
}
