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
    public partial class Save : Form
    {
        Form1 f;
        public Save(Form1 f)
        {
            InitializeComponent();
            this.f = f;
            if (f.Name_MT != "")
                name_textBox.Text = f.Name_MT;
        }

     

        private void save_button_Click(object sender, EventArgs e)
        {
            
           f.Save_library(name_textBox.Text);
            
            this.Close();
        }


    }
}
