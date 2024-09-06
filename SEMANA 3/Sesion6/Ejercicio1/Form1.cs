using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void agregar()
        {
            string nombre = tbNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("ERROR NO PUEDE QUEDAR VACIO");
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();

        }

        private void tbnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int cant = cmbNombres.Items.Count;
            for(int i = 0; i < cant; i++)
            {
                string nombre = cmbNombres.Items[i].ToString();
                cmbNombres2.Items.Add(nombre);
            }
        }
    }
}
