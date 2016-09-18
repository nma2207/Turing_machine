using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
namespace курсач
{
    
    public partial class Form1 : Form
    {



        public string Name_MT = "";
        int y = 0;
        public List<Tape> List_tape=new List<Tape>() ;
        int old_size_width;
        Timer t;//=new Timer();
        bool arbeit = false;
        ConditionsTree ConTree;
        public  List<int>ProtocolRowsNumbers;
        int condition_index = 0;
        public Form1()
        {

            InitializeComponent();

            List_tape.Add(new Tape(newABC.Text, ref y, tape_panel));
            new_Size();
            tape_count_TextChanged(new object(), new EventArgs());
            Directory.CreateDirectory(library);

        }

        void b_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Tape tap in List_tape)
            {
                tap.new_abc(newABC.Text);
            }
            int count = (Protocol.Columns.Count-2)/3;
            for(int i=0;i<count;i++)
            {
                DataGridViewComboBoxColumn c = ( DataGridViewComboBoxColumn)Protocol.Columns[3*i+1];
                c.Items.Clear();
                c.Items.AddRange(List_tape.Last().abc);
                c=( DataGridViewComboBoxColumn)Protocol.Columns[3*i+3];
                c.Items.Clear();
                c.Items.AddRange(List_tape.Last().abc);
                    
            }
       }

        
        private void butto_Click(object sender, EventArgs e)
        {
            Name_MT = "name";
            List_tape.Add(new Tape(newABC.Text,ref y, tape_panel));
            tape_count.Text = (Convert.ToInt32(tape_count.Text) + 1).ToString();
        }

        private void Algorithm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Form Info;
        
        private void button2_Click(object sender, EventArgs e)
        {
            Name_MT = "name";
            if(List_tape.Count>1)
            {
                Tape del = List_tape.Last();
                del.Tape_delete(ref y);
                List_tape.Remove(del);
                tape_count.Text = (Convert.ToInt32(tape_count.Text) - 1).ToString();
            }
            else
            {
                Notification.WriteNotification("Машина Тьюринга не может быть без лент");
            }
        }

        private void but_tape_count_Click(object sender, EventArgs e)
        {
            int new_count = Convert.ToInt32(tape_count.Text);
            while(List_tape.Count<new_count)
                List_tape.Add(new Tape(newABC.Text,ref y,tape_panel));
            while(List_tape.Count>new_count)
            {
                Tape del = List_tape.Last();
                del.Tape_delete(ref y);
                List_tape.Remove(del);
            }
        }


      

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info = new Form2();
            Info.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List_tape.Last().AddToRight();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            new_Size();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Protocol.Rows.Add();
        }
        public void new_Size()
        {
            panel_abc.Location = new Point(this.Size.Width - (old_size_width - panel_abc.Location.X), panel_abc.Location.Y);
            task.Size = new Size(this.Size.Width - old_size_width + task.Size.Width, task.Size.Height);
            tape_panel.Size = new Size(this.Size.Width - old_size_width + tape_panel.Size.Width, (this.Size.Height*2)/5);
            Protocol.Location = new Point(tape_panel.Location.X, tape_panel.Location.Y + tape_panel.Size.Height + 5);
            Protocol.Size = new Size(this.Size.Width*808/1166, this.Size.Height - Protocol.Location.Y - 45);

            foreach(Tape b in List_tape)
            {
                b.ToRight.Location = new Point(tape_panel.Size.Width - 52, b.ToRight.Location.Y);
            }
            comments.Location = new Point(Protocol.Location.X + Protocol.Size.Width + 10, tape_panel.Location.Y + tape_panel.Size.Height + 10);
            comments.Size = new Size(Size.Width - comments.Location.X - 10, Size.Height - comments.Location.Y - 10);
            
            old_size_width = this.Size.Width;
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
           panel_abc.Location = new Point(this.Size.Width - panel_abc.Width-25, panel_abc.Location.Y);
            task.Size = new Size(panel_abc.Location.X-10, task.Size.Height);
            tape_panel.Size = new Size(this.Size.Width-45, (this.Size.Height * 1) / 4);
            Protocol.Location = new Point(tape_panel.Location.X, tape_panel.Location.Y + tape_panel.Size.Height + 5);
            Protocol.Size = new Size(this.Size.Width * 808 / 1166, this.Size.Height - Protocol.Location.Y - 45);

            foreach (Tape b in List_tape)
            {
                b.My_panel.Size = new Size(tape_panel.Size.Width - 83, b.My_panel.Height);
                b.ToRight.Location = new Point(tape_panel.Size.Width - 52, b.ToRight.Location.Y);
            }
            comments.Location = new Point(Protocol.Location.X + Protocol.Size.Width + 5, tape_panel.Location.Y+ tape_panel.Size.Height + 5);
            comments.Size = new Size(tape_panel.Size.Width+5 - comments.Location.X , this.Size.Height - comments.Location.Y - 45);
            
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
           // new_Size();
        }

        public void tape_count_TextChanged(object sender, EventArgs e)
        {
            new_protocol(List_tape.Count);

        }
        string condition="q1";
        int old_k = -1;
        public void new_protocol(int count)
        {
            Protocol.Columns.Clear();

            DataGridViewTextBoxColumn start = new DataGridViewTextBoxColumn();
            start.HeaderText = "исходное состояние машины";
            DataGridViewTextBoxColumn finish = new DataGridViewTextBoxColumn();
            finish.HeaderText = "новое состояние машины";
            DataGridViewComboBoxColumn[] old_value = new DataGridViewComboBoxColumn[count];
            string[] ABC = List_tape.Last().abc;
            for (int i = 0; i < count; i++)
            {
                old_value[i] = new DataGridViewComboBoxColumn();
                old_value[i].Items.AddRange(ABC);
                old_value[i].HeaderText = "входящее значение с ленты №" + i;
                old_value[i].Name = "value";
            }
            DataGridViewComboBoxColumn[] new_value = new DataGridViewComboBoxColumn[count];
            for (int i = 0; i < count; i++)
            {
                new_value[i] = new DataGridViewComboBoxColumn();
                new_value[i].Items.AddRange(ABC);
                new_value[i].HeaderText = "новое значение на ленте №" + i;
                new_value[i].Name = "value";
            }
            DataGridViewComboBoxColumn[] direction = new DataGridViewComboBoxColumn[count];
            for (int i = 0; i < count; i++)
            {
                direction[i] = new DataGridViewComboBoxColumn();
                direction[i].Items.AddRange(new string[] { "*","->", "<-" });
                direction[i].HeaderText = "смещение головки на ленте №" + i;
            }
            Protocol.Columns.Add(start);
            for (int i = 0; i < count; i++)
            {
                Protocol.Columns.Add(old_value[i]);
                Protocol.Columns.Add(direction[i]);
                Protocol.Columns.Add(new_value[i]);

            }
            Protocol.Columns.Add(finish);
        }
        private void пахайToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            //if (arbeit == false)
            //{
            //    пахайToolStripMenuItem.Text = "Стоп";
            //    arbeit = true;
            task.Focus();
                ConditionsTree ConTree = new ConditionsTree(this);
                ConTree.ShowDialog();
            //}
            //else
            //{
            //    arbeit = false;
            //    condition = "my_stop";
            //    пахайToolStripMenuItem.Text = "Пуск";

            //}
            //t.Dispose();
        }

        public void Job(int interval)
        {

            condition = "q1";
            t = new Timer();
            old_k = -1;
            t.Interval = interval;
            t.Start();
            t.Tick += t_Tick;
            condition_index = 0;
           
        }
       
        void t_Tick(object sender, EventArgs e)
        {

            if(old_k!=-1)
            {
                Protocol.Rows[old_k].Cells[0].Style.BackColor = BackColor;
                Protocol.Rows[old_k].Cells[Protocol.ColumnCount - 1].Style.BackColor = BackColor;
            }
            if (condition_index<ProtocolRowsNumbers.Count || condition=="my_stop")
            {
                int k = ProtocolRowsNumbers[condition_index];
                condition_index++;
                Protocol.Rows[k].Cells[0].Style.BackColor = Color.Green;
                Protocol.Rows[k].Cells[Protocol.ColumnCount - 1].Style.BackColor = Color.Green;
                old_k = k;
                for (int i = 0; i < List_tape.Count; i++)
                {
                    List_tape[i].iterator.Write(Protocol.Rows[k].Cells[3 * i + 3].Value.ToString());
                    switch (Protocol.Rows[k].Cells[3 * i + 2].Value.ToString())
                    {
                        case "->": List_tape[i].iterator.ToRight(List_tape[i]); break;
                        case "<-": List_tape[i].iterator.ToLeft(List_tape[i]); break;
                        case "*": break;
                        default: MessageBox.Show("ERROR"); break;
                    }
                }
                condition = Protocol.Rows[k].Cells[Protocol.ColumnCount - 1].Value.ToString();

            }
            else
            {
                if (t != null)
                    t.Stop();
                switch (condition)
                {
                    case "stop": Notification.WriteNotification("Машина Тьюринга успешно закончила свою работу"); break;
                    case "my_stop": Notification.WriteNotification("Машина остановила работу по Вашему требованию"); break;
                    case "error":
                    default: Notification.WriteNotification("Машина встретила состояние, которое не описано в схеме работы"); break;
                    
                }
            }
                


            
            //if (condition == "stop" || condition=="error" || condition=="my_stop")
            //{
            //    пахайToolStripMenuItem.Text = "Пуск";
            //    t.Stop();
            //    arbeit = false;
                
                
            //    if (old_k != -1)
            //        for (int i = 0; i < Protocol.Columns.Count; i++)
            //            Protocol.Rows[old_k].Cells[i].Style.BackColor = BackColor;
            //    old_k = -1;
                
            //    switch(condition)
            //    {
            //        case "stop": WriteNotification("Машина Тьюринга успешно закончила свою работу"); break;
            //        case "error": WriteNotification("Машина встретила состояние, которое не описано в схеме работы"); break;
            //        case "my_stop": WriteNotification("Машина остановила работу по Вашему требованию"); break;
            //    }
            //    //ConTree.Show();
                


            //}
            //else
            //{
            //    if (old_k != -1)
            //    {
            //        for (int i = 0; i < Protocol.Columns.Count; i++)
            //            Protocol.Rows[old_k].Cells[i].Style.BackColor = BackColor;
            //    }
            //    string[] value = new string[List_tape.Count];
            //    for (int i = 0; i < List_tape.Count; i++)
            //    {
            //        value[i] = List_tape[i].iterator.Read();

            //    }


            //    int k = -1;

            //    for (int i = 0; i < Protocol.Rows.Count - 1; i++)
            //    {

            //        string[] new_value = new string[List_tape.Count];
            //        for (int j = 0; j < List_tape.Count; j++)
            //        {
            //            new_value[j] = Protocol.Rows[i].Cells[3 * j + 1].Value.ToString();

            //        }
            //        bool f = true;
            //        for (int j = 0; j < value.Length; j++)
            //            if (value[j] != new_value[j])
            //                f = false;
            //        if (condition != Protocol.Rows[i].Cells[0].Value.ToString())
            //            f = false;
            //        if (f)
            //            k = i;


            //    }

            //    if (k != -1)
            //    {
            //        Protocol.Rows[k].Cells[0].Style.BackColor = Color.Green;
            //        Protocol.Rows[k].Cells[Protocol.Columns.Count - 1].Style.BackColor = Color.Orange;
            //        for (int i = 0; i < List_tape.Count; i++)
            //        {

            //            Protocol.Rows[k].Cells[3 * i + 1].Style.BackColor = Color.Blue;

            //        }
            //        for (int i = 0; i < List_tape.Count; i++)
            //        {
            //            List_tape[i].iterator.Write(Protocol.Rows[k].Cells[3 * i + 3].Value.ToString());
            //            switch (Protocol.Rows[k].Cells[3 * i + 2].Value.ToString())
            //            {
            //                case "<-": { List_tape[i].iterator.ToLeft(List_tape[i]); break; }
            //                case "->": { List_tape[i].iterator.ToRight(List_tape[i]); break; }
            //                case "*": break;
            //            }

            //        }

            //        int last = Protocol.ColumnCount - 1;
            //        condition = Protocol.Rows[k].Cells[last].Value.ToString();

            //    }
            //    else
            //        condition = "error";
            //    old_k = k;
            //}
                      
            //throw new NotImplementedException();
        }
        public void MT_ToFile_Write( StreamWriter writer)
        {
            writer.WriteLine(List_tape.Count);
            foreach(Tape b in List_tape)
            {
                writer.WriteLine(b.First_number + " " + b.iterator.Number);
                string[] a = b.Value();
                foreach (string s in a)
                {
                    writer.Write(s + " ");
                  
                   
                }
                writer.WriteLine();
            }
        }
        public void protocol_to_file(StreamWriter writer)
        {
            writer.WriteLine(Protocol.Rows.Count + " " + Protocol.Columns.Count);
            for(int i=0;i<(Protocol.Rows.Count-1);i++)
            {
                for(int j=0;j<Protocol.Columns.Count;j++)
                {
                    writer.Write(Protocol.Rows[i].Cells[j].Value.ToString()+" ");
                }
                writer.WriteLine();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task.Focus();
            Wegcs weg = new Wegcs(this);
            weg.ShowDialog();
           Form f = new Save(this);
           f.ShowDialog();
        }
       public void Save_library(string Name)
        {
            Library.new_Library(this, Name);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wegcs weg = new Wegcs(this);
            weg.ShowDialog();
            Open f = new Open(this);
            f.ShowDialog();
            

            
        }

        public string[] open_list(string directory)
        {
            string[] name = Directory.GetDirectories(directory);
            
            for (int i = 0; i < name.Length; i++)
            {
                string[] temp = name[i].Split('\\');
                name[i] = temp[temp.Length - 1];
            }
            return name;
        }
        public string[] open_file(string directory)
        {
            string[] name = Directory.GetFiles(directory);
            for (int i = 0; i < name.Length; i++)
            {
                string[] temp = name[i].Split('\\');
                name[i] = temp[temp.Length - 1];
            }
            return name;
        }
        private void Protocol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public void read_protocol(string[,] a)
        {
            while (a.GetLength(0) > Protocol.Rows.Count-1)
                Protocol.Rows.Add();
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Protocol.Rows[i].Cells[j].Value = a[i, j];
            }
        }
        public void Read_library(string Name)
        {
            Library.Read(this, Name);
            button1_Click(new object(), new EventArgs());
        }

        private void очиститьЛентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Tape p in List_tape)
                p.Default_values();
        }
        public void readTape(string name)
        {
            Library.ReadTapes(this, name);
        }

        private void лентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void загрузитьДругуюЛентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            Load_tapes f = new Load_tapes(this);
            f.ShowDialog();
        }

        private void task_TextChanged(object sender, EventArgs e)
        {

        }


        public int ProtocolWidth
        {
            get { return Protocol.ColumnCount; }
        }
        public int ProtocolHeight
        {
            get
            {
                return Protocol.Rows.Count - 1;
            } 
        }
        public string this[int i,int j]
        {
            get
            {
                if (Protocol.Rows[i].Cells[j].Value == null)
                    MessageBox.Show(i.ToString() + " " + j.ToString());
                return Protocol.Rows[i].Cells[j].Value.ToString(); }
        }
        public Form1 getForm1
        {
            get { return this; }
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser webbrower = new WebBrowser();
            System.Diagnostics.Process.Start("instruction.mht+");
            

        }
        public int Index
        {
            get { return condition_index; }
            set { condition_index = value; }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        public bool Step()
        {

            if (condition == "stop" || condition == "my_stop" || condition == "error")
            {
                t_Tick(new object(), new EventArgs());
                return false;
            }
            else
            {
                t_Tick(new object(), new EventArgs());
                return true;
            }
        }

        private void task_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
