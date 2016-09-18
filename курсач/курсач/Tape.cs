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
    public partial class Form1:Form
   {
        public class Node
        {
            public int width = 35, height = 20;
            public int y=20, dx = 0, x0 = 0;
            public Node right, left;
            public ComboBox value;
            public int number;
            public string default_value="*";
            //public static Control c = new Control();
            public Node(string[] a, Panel pan, Node l = null, Node r = null)
            {
               value = new ComboBox();
                if (l != null)
                {
                    number = l.number + 1;
                    value.Location=new Point(l.value.Location.X+width,y);
                }
                else
                    if (r != null)
                    {
                        number = r.number - 1;
                        value.Location = new Point( r.value.Location.X - width, y);
                    }
                    else
                    {
                        number = 0;
                        value.Location = new Point(x0, y);
                    }

                
                value.Items.AddRange(a);
                right = r;
                left = l;
                value.Size = new Size(width, height);
                
                value.Text = default_value;
                pan.Controls.Add(value);

            }
        };
        public class Iterator
        {
            Node element;

            //public Rectangle rect;
            public PictureBox arrow;
            public Iterator(Node el)
            {
                element = el;

                //rect = new Rectangle();


            }

            public void draw(Panel p)
            {
                /*rect.X = element.value.Location.X;
                 rect.Y = element.value.Location.Y - 20;
                 rect.Size = element.value.Size;
                 SolidBrush pen = new SolidBrush(color);*/
                arrow = new PictureBox();
                arrow.Size = new Size(element.value.Size.Width, element.value.Size.Height);
                arrow.Location = new Point(element.value.Location.X, element.value.Location.Y - arrow.Size.Height);
                arrow.Image = global::курсач.Properties.Resources.arrow;
                p.Controls.Add(arrow);
                /*Graphics g = Graphics.FromHwnd(p.Handle);
                g.FillRectangle(pen, rect);*/
            }
            public void Write(string value)
            {
                element.value.Text = value;
            }
            public string Read()
            {
                return element.value.Text;
            }
           public void ToRight(Tape t)
            {
                if (element.right == null)
                    t.AddToRight();
                else
                {
                    t.My_panel.Controls.Remove(arrow);
                    element = element.right;
                    draw(t.My_panel);
                }
                
            }
            public void ToLeft(Tape t)
            {

                if (element.left == null)
                {
                    t.AddToLeft();
                }
                else
                {
                    t.My_panel.Controls.Remove(arrow);
                    element = element.left;
                    draw(t.My_panel);
                }
            }
            public int Number
            {
                get { return element.number; }
            }



        }

    public class Tape
    {
        Button toLeft, toRight;
        Node head;
        public Iterator iterator;
        int count;
        string[] ABC;
        Panel panel_tape;
        Panel my_panel;
        int x0 = 30, height = 55;
        public string[] abc
        {
            get { return ABC; }
        }
        string[] toABC(string abc)
        {
            string[] a = new string[1 + abc.Length];
            a[0] = "*";
            for (int i = 0; i < abc.Length; i++)
                a[i + 1] = abc[i].ToString();
            return a;
        }
        public Tape(string a, ref int y, Panel panel)
        {
            panel_tape = panel;
            //
            //my_panel
            //
             my_panel = new Panel();
             my_panel.AutoScroll = true;
              my_panel.Location = new Point(x0, y);
              my_panel.Size=new Size(panel_tape.Size.Width-2*x0-23,height+2);
              my_panel.BackColor=panel.BackColor;
              panel_tape.Controls.Add(my_panel);
            toLeft = new Button();
            toLeft.Size = new Size(29, 20);
            toLeft.Location = new Point(0, y+20);
            toLeft.Cursor = Cursors.Hand;
            toLeft.Click += toLeft_Click;

            toLeft.Image = global::курсач.Properties.Resources.toleft;
            panel_tape.Controls.Add(toLeft);
            toRight = new Button();
            toRight.Size = new Size(29, 20);
            toRight.Location = new Point(panel_tape.Width - 52, y+20);
            toRight.Cursor = Cursors.Hand;
            toRight.Image = global::курсач.Properties.Resources.toright;
            toRight.Click += toRight_Click;
            // toRight.Click += new EventHandler(toRigth_Click);
            panel_tape.Controls.Add(toRight);
            count = 30;

            ABC = toABC(a);
            head = new Node(ABC, my_panel);
            Node p = head;
            for (int i = 1; i < count; i++, p = p.right)
            {
                p.right = new Node(ABC, my_panel, p);


            }
            p = head;
            for (int i = 0; p.right != null && i < count / 2; i++, p = p.right)
                ;
           iterator = new Iterator(p);
            iterator.draw(my_panel);
            y += 60;

        }

        void toRight_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            iterator.ToRight(this);
        }

        void toLeft_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            iterator.ToLeft(this);
        }
        public void new_abc(string abc)
        {
            ABC = toABC(abc);
            for (Node p = head; p != null; p = p.right)
            {
                p.value.Items.Clear();
               p.value.Items.AddRange(ABC);
            }
        }

        public void Tape_delete(ref int y)
        {
            
            panel_tape.Controls.Remove(toLeft);
            panel_tape.Controls.Remove(toRight);
            panel_tape.Controls.Remove(my_panel);
            y -= 50;
            //panel_tape.Controls.Remove(my_panel);

        }
       public void AddToLeft()
        {
            
            for (Node p = head; p != null; p = p.right)
                p.value.Location = new Point(p.value.Location.X + p.value.Size.Width, p.value.Location.Y);
            head.left = new Node(ABC, my_panel, null, head);
            head = head.left;
            count++;
            iterator.ToLeft(this);
           // panel_tape.Controls.Remove(iterator.arrow);
           // iterator.draw(panel_tape);
           

        }
        public void AddToRight()
       {
           Node tail = head;
           for (; tail.right != null; tail = tail.right) 
               ;

               //for (Node p = tail; p != null; p = p.left)
                 //  p.value.Location = new Point(p.value.Location.X - p.value.Size.Width, p.value.Location.Y);
               tail.right = new Node(ABC, my_panel, tail, null);
               count++;
               iterator.ToRight( this);
           //panel_tape.Controls.Remove(iterator.arrow);
           //iterator.draw(panel_tape);

       }
        public Panel My_panel
        {
            get { return my_panel; }
        }
        public Button ToLeft
        {
            get { return toLeft; }
        }
        public Button ToRight
        {
            get { return toRight; }
        }
        public int Count
        {
            get { return count; }
        }
        public int First_number
        {
            get { return head.number; }
        }
        public string[] Value()
        {
            string[] value = new string[count];
            int i=0;
            for (Node p = head; p != null; p = p.right)
            {
                value[i] = p.value.Text;
                i++;
            }
            return value;
        }
        public void Read(string[] value,int iterator_number,int first_number)
        {
            while (head.number  >  first_number)
                AddToLeft();
            while (Count < value.Length)
                AddToRight();
            int i = 0;
            for(Node p=head;i<value.Length;i++,p=p.right)
            {
                p.value.Text = value[i];
            }
            Node p1 = head;
            for (; p1.number != iterator_number; p1 = p1.right)
                ;
            my_panel.Controls.Remove(iterator.arrow);
            iterator = new Iterator(p1);
            iterator.draw(my_panel);
        }
        public void Default_values()
        {
            for (Node p = head; p != null; p = p.right)
                p.value.Text = p.default_value;
        }
    }
}
}
