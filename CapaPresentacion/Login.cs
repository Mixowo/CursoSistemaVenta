using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();

            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_closing(object ssender, FormClosingEventArgs e)
        {
            txtnumdoc.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
