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
    public partial class Speed : Form
    {
        Form1 f1;
        public Speed(Form1 f1,List<int>l)
        {
            InitializeComponent();
            f1.ProtocolRowsNumbers = new List<int>();
            f1.ProtocolRowsNumbers = l;
            this.f1 = f1;
        }

        private void buttonArbeiten_Click(object sender, EventArgs e)
        {

            
            f1.Job(2010-trackBarSpeed.Value);
            
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Speed_Load(object sender, EventArgs e)
        {

        }

        private void step_Click(object sender, EventArgs e)
        {
            Close();
            Size = MinimumSize;
            Step step = new Step(f1);
            
            step.ShowDialog();
            
        }


    }
}
