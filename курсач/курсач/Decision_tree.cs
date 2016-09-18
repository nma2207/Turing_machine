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
    public partial class Form1 : Form
    {
        class Node1
        {
            public string value ;
           public Node1 left;
           public Node1 right;
           public Node1(Node1 left,Node1 right,string value="*")
           {
               this.value = value;
               this.left = left;
               this.right = right;
           }

        }
        class Iterator1
        {
            Node1 element;
            public Iterator1(Node1 element)
            {
                this.element = element;
            }
            public void ToLeft()
            {
                element = element.left;
            }
            public void ToRight()
            {
                element = element.right;
            }
            public string Write()
            {
                return element.value;
            }
            public void Read(string new_value)
            {
                element.value = new_value;
            }
        }
        class Tape1
        {
            Node1 head;
        }
        class Turing_machine
        {
            List<Tape1> MT;
            string condition;
            List<Turing_machine> child;
            Turing_machine parent;

        }
        class Decision_tree
        {
            Turing_machine root;
        }
    }
}
