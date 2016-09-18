using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace курсач
{

    public partial class Form1 : Form
    {

        public string library = "library";
        public static class Library
        {

            static string Task = "task.txt";
            static string Tapes = "Tapes";
            static string Protocol = "protocol.txt";
            static string Comments = "comments.txt";
            static string ABC = "abc.txt";
            public static void new_Library(Form1 f, string Name)
            {
                f.Name_MT = Name;
                string[] kod = f.open_list(f.library);
                bool is_kod = false;
                foreach (string s in kod)
                {

                    if (s.Equals(Name))
                        is_kod = true;
                }
                if (is_kod)
                {
                    string[] tapes_arr = Directory.GetFiles(f.library + "//" + Name + "//" + Tapes);
                    string[] name = new string[tapes_arr.Length];
                    for (int i = 0; i < name.Length; i++)
                    {
                        string[] buf = tapes_arr[i].Split('\\');
                        name[i] = buf.Last();
                    }
                    StreamWriter tape_writer = new StreamWriter(f.library + "//" + Name + "//" + Tapes + "//" + (Convert.ToInt32(name.Last().Split('.')[0]) + 1).ToString()+".txt");
                    f.MT_ToFile_Write(tape_writer);
                    tape_writer.Close();


                }
                else
                {
                    Directory.CreateDirectory(f.library + "//" + Name);
                    Directory.CreateDirectory(f.library + "//" + Name + "//" + Tapes);
                     StreamWriter tapes_write = new StreamWriter(f.library + "//" + Name + "//" + Tapes+"//"+"0.txt");
                    f.MT_ToFile_Write(tapes_write);
                    tapes_write.Close();
                }

                StreamWriter task_write = new StreamWriter(f.library + "//" + Name + "//" + Task);
                task_write.WriteLine(f.task.Text);
                task_write.Close();
                StreamWriter comments_write = new StreamWriter(f.library + "//" + Name + "//" + Comments);
                comments_write.Write(f.comments.Text);
                comments_write.Close();
                 
                StreamWriter protocol_writer = new StreamWriter(f.library + "//" + Name + "//" + Protocol);
                f.protocol_to_file(protocol_writer);
                protocol_writer.Close();
                StreamWriter abc_writer = new StreamWriter(f.library + "//" + Name + "//" + ABC);
                abc_writer.WriteLine(f.newABC.Text);
                abc_writer.Close();
                

            }
            public static void Read(Form1 f, string Name)
            {
                f.Name_MT = Name;
                StreamReader task_reader = new StreamReader(f.library + "//" + Name + "//" + Task);
                f.task.Text = task_reader.ReadToEnd().Trim();
                task_reader.Close();
                StreamReader abc_reader = new StreamReader(f.library + "//" + Name + "//" + ABC);
                f.newABC.Text = abc_reader.ReadToEnd().Trim();
                abc_reader.Close();
                
                StreamReader tapes_reader = new StreamReader(f.library + "//" + Name + "//" + Tapes+"//"+"0.txt");
                int count = Convert.ToInt32(tapes_reader.ReadLine().Trim());
                
                while (f.List_tape.Count < count)
                    f.List_tape.Add(new Tape(f.newABC.Text, ref f.y, f.tape_panel));
                for (int i = 0; i < count; i++)
                {
                    int first_number;
                    int iterator_number;
                    string[] a = tapes_reader.ReadLine().Trim().Split(' ');
                    first_number = Convert.ToInt32(a[0]);
                    iterator_number = Convert.ToInt32(a[1]);
                    string[] value = tapes_reader.ReadLine().Trim().Split(' ');
                    f.List_tape[i].Read(value, iterator_number, first_number);
                }
                tapes_reader.Close();
                f.tape_count.Text = count.ToString();
                f.but_tape_count_Click(new object(), new EventArgs());
                f.new_protocol(count);
                StreamReader protocol_reader = new StreamReader(f.library + "//" + Name + "//" + Protocol);
                int n, m;
                string[] len = protocol_reader.ReadLine().Trim().Split(' ');
                n = Convert.ToInt32(len[0]) - 1;
                m = Convert.ToInt32(len[1]);
                string[,] protocol_table = new string[n, m];
                for (int i = 0; i < n; i++)
                {
                    string[] a = protocol_reader.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < m; j++)
                        protocol_table[i, j] = a[j];
                }
                f.read_protocol(protocol_table);
                protocol_reader.Close();
                StreamReader comments_reader = new StreamReader(f.library + "//" + Name + "//" + Comments);
                f.comments.Text = comments_reader.ReadToEnd().Trim();
                comments_reader.Close();
            }
            public static void ReadTapes(Form1 f,string name)
            {
                StreamReader tapes_reader = new StreamReader(f.library + "//" + f.Name_MT + "//" + Tapes + "//" + name);
                int count = Convert.ToInt32(tapes_reader.ReadLine().Trim());
                for (int i = 0; i < count; i++)
                {
                    int first_number;
                    int iterator_number;
                    string[] a = tapes_reader.ReadLine().Trim().Split(' ');
                    first_number = Convert.ToInt32(a[0]);
                    iterator_number = Convert.ToInt32(a[1]);
                    string[] value = tapes_reader.ReadLine().Trim().Split(' ');
                    f.List_tape[i].Read(value, iterator_number, first_number);
                }
                tapes_reader.Close();
            }

        }
    }
}