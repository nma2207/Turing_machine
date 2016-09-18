using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
    public partial class Wegcs : Form
    {
        Form1 f1;
        public Wegcs(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            Weg.Text = f1.library;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wegcs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.library = Weg.Text;
            Close();
        }
    }
}
