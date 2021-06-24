using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace Faculty
{
    public partial class MainForm : Form
    {
        public SQLiteConn conn;

        public MainForm()
        {
            InitializeComponent();
            conn = new SQLiteConn("faculty.db",true);
            // accesos...
            conn.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAlumnosForm form = new MostrarAlumnosForm();
            form.ShowDialog();
        }
    }
}
