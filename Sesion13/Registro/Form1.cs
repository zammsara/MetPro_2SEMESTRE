using Registro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = tbName.Text;
            person.LastName = tbLastName.Text;
            person.BirthDate =
                dtpBirthDate.Value;
            persons.Add(person);
            ShowPersons();
            Cleartb();
        }

        private void ShowPersons() 
        {
            dgvPersons.DataSource = null;
            dgvPersons.DataSource = persons;
        }

        private void Cleartb() 
        { 
            tbName.Clear(); 
            tbLastName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            tbName.Focus();
        }
    }
}
