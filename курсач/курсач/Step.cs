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
    public partial class Step : Form
    {
        Form1 f1;
        public Step(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            f1.Index = 0;
            f1.Condition = "q1";
        }

        private void Step_Load(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (f1.Step() == false)
                Close();
            
        }
    }
}
