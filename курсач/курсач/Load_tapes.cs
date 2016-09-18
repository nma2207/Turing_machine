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
    public partial class Load_tapes : Form
    {
        Form1 f1;
        int x = 5, y0 = 0, dy = 0;
        int width = 150, height = 18;
        Label[] label_name;
        Label l;
        public Load_tapes(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            if (f1.Name_MT != "")
            {
                
                string[] name = f1.open_file(f1.library + "//" + f1.Name_MT+"//"+"Tapes");
                label_name = new Label[name.Length];
                for (int i = 0; i < label_name.Length; i++)
                {
                    label_name[i] = new Label();
                    label_name[i].Size = new Size(width, height);
                    label_name[i].Cursor = Cursors.Hand;
                    label_name[i].Location = new Point(x, y0 + (height + dy) * i);
                    label_name[i].Click += Load_tapes_Click;
                    label_name[i].Font = new Font("Arial", 10);
                    panel.Controls.Add(label_name[i]);
                    label_name[i].Text = name[i];

                }
            }
            else
            {
                l = new Label();
                l.Size = new Size(width, height);
                l.Location = new Point(x, y0);
                l.Font = new Font("Arial", 10);
                l.Text = "нет библиотек";
                panel.Controls.Add(l);
            }
            Load_tapes_Resize(new object(), new EventArgs());
        }

        void Load_tapes_Click(object sender, EventArgs e)
        {
            l = (Label)sender;
            for (int i = 0; i < label_name.Length; i++)
                label_name[i].BackColor = BackColor;
            l.BackColor = Color.DeepSkyBlue;
            //throw new NotImplementedException();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (l.Text == "нет библиотек")
                Close();
            else
            {
                f1.readTape(l.Text);
                Close();
            }
       }

        private void Load_tapes_Load(object sender, EventArgs e)
        {

        }

        private void button_no_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Load_tapes_Resize(object sender, EventArgs e)
        {
            panel.Size = new Size(ClientSize.Width - 12, ClientSize.Height - 68);
            button_ok.Location = new Point(Size.Width / 2 - button_ok.Size.Width - 10, ClientSize.Height - 50);
            button_no.Location = new Point(Size.Width / 2 + 10, ClientSize.Height - 50);
        }

    }
}
