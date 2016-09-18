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
    public partial class ConditionsTree : Form
    {
       
        Tree t;
        Timer t1;
        List<Tape> listTape = new List<Tape>();
        string[,] protocol = new string[0, 0];
        Form1 f1;
        List<int> protocol_k = new List<int>();
        public ConditionsTree(Form1 f)
        {
            InitializeComponent();
            this.f1 = f;
            buttonStart.Location = new Point(Width / 2 - buttonStart.Width / 2, buttonStart.Location.Y);
            t1 = new Timer();
            t1.Interval = 1000;

            t1.Start();
            t1.Tick += t1_Tick;
            ConditionsTree_SizeChanged(new object(), new EventArgs());
            t = null;

      
        }

        void t1_Tick(object sender, EventArgs e)
        {
            ReadFromForm1(f1);
            t.Jobben();
            t1.Stop();
            
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Drawing();
            //if (t != null)
            //{
            //    //t.Clear();
            //    t.Jobben();
            //  //  t.Drawing();
            //}
            //else
            //{
            //    ReadFromForm1(f1);
            //}

        }

        private void ConditionsTree_Load(object sender, EventArgs e)
        {

        }


        private void panelTree_SizeChanged(object sender, EventArgs e)
        {


        }

        private void ConditionsTree_SizeChanged(object sender, EventArgs e)
        {
            panelTree.Controls.Clear();
            panelTree.Size = new Size(Width - 50, Height - 120);
            button1.Location = new Point(Width / 4 - button1.Width / 2, Height - 95);
            buttonStart.Location = new Point(Width * 3 / 4 - buttonStart.Width / 2, Height - 95);
            panelTree.Invalidate();

            if (t != null)
            {


                t.ReSize();
                t.Drawing();
            }


        }
        void ReadFromForm1(Form1 f)
        {
            
            for(int i=0;i<f.List_tape.Count;i++)
            {
                Tape p=new Tape(f.List_tape[i].Value(),f.List_tape[i].iterator.Number,f.List_tape[i].First_number);
                listTape.Add(p);
            }
            protocol = new string[f.ProtocolHeight, f.ProtocolWidth];
            for (int i = 0; i < protocol.GetLength(0); i++)
                for (int j = 0; j < protocol.GetLength(1); j++)
                {
                    
                    protocol[i, j] = f[i, j];
                }
            t = new Tree(this, listTape);

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Speed f = new Speed(f1,t.protocolRows());
            Close();
            Size = MinimumSize;
            f.ShowDialog();
            //this.WindowState = FormWindowState.Minimized;
            
            
        }

        private void panelTree_Scroll(object sender, ScrollEventArgs e)
        {
            t.Drawing();
        }
        public static bool ConditionsTreeEnabled = true;
    }
}