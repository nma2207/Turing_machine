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
    public partial class Open : Form
    {
        Form1 f1;
        int x = 5, y0 = 0, dy = 0;
        int width = 50, height = 18;
        Label[] label_name;

        Label l;
        public Open(Form1 f)
        {
            InitializeComponent();
            f1 = f;
            string[] name = f1.open_list(f1.library);
             label_name= new Label[name.Length];
            for(int i=0;i<label_name.Length;i++)
            {
                
                label_name[i] = new Label();
                label_name[i].AutoSize = true;
                label_name[i].Cursor = Cursors.Hand;
                label_name[i].Location = new Point(x, y0 + (height + dy) * i);
                label_name[i].Click+=Open_Click;
                label_name[i].Font = new Font("Arial", 10);
                panel.Controls.Add(label_name[i]);
                label_name[i].Text = name[i];
             
            }
            Open_Resize(new object(), new EventArgs());
        }

        void Open_Click(object sender, EventArgs e)
        {
            l = (Label)sender;
            for (int i = 0; i < label_name.Length; i++)
                label_name[i].BackColor = panel.BackColor;
            l.BackColor = Color.DeepSkyBlue;
          //  f1.Read_library(l.Text);
           // Close();
            
        }
 
        private void Open_Load(object sender, EventArgs e)
        {
            
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            f1.Read_library(l.Text);
            Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_button_Click_1(object sender, EventArgs e)
        {
            f1.Read_library(l.Text);
            Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Open_Resize(object sender, EventArgs e)
        {
            panel.Size = new Size(ClientSize.Width - 12, ClientSize.Height-68);
            ok_button.Location = new Point(Size.Width / 2 - ok_button.Size.Width - 10, ClientSize.Height - 50);
            close_button.Location = new Point(Size.Width / 2 + 10, ClientSize.Height - 50);
        }
    }
}
