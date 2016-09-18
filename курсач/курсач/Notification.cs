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
    public partial class Notification : Form
    {
        public Notification(string NotificationText)
        {
            InitializeComponent();
            label1.Font = new Font("Arial",9);
            label1.Text = NotificationText;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Notification_SizeChanged(object sender, EventArgs e)
        {
            label1.Location = new Point(Size.Width / 2 - label1.Size.Width / 2, label1.Location.Y);
            button1.Location = new Point(Size.Width / 2 - button1.Size.Width / 2, button1.Location.Y);
        }
        public static void WriteNotification(string NotificationText)
        {
            Notification Notif = new Notification(NotificationText);
            Notif.ShowDialog();
        }
    }
}
