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
        
        class Tape
        {
            public class TapeNode
            {

                public TapeNode left, right;
                public string value;
                public int number;
                
                public TapeNode(string value, TapeNode left, TapeNode right,int number)
                {
                    this.number = number;
                    this.left = left;
                    this.right = right;
                    this.value = value;
                }
            }
            public class iterator
            {
                TapeNode element;
                public iterator(TapeNode element)
                {
                    this.element = element;
                }
                 public void Write(string value)
                {
                    element.value = value;
                }
                 public string Read()
                {
                    return element.value;
                }
                 public  void ToLeft(Tape t)
                {
                    if (element.left == null)
                        t.AddToLeft();
                    element = element.left;
                }
                 public void ToRight(Tape t)
                {
                    if (element.right == null)
                        t.AddToRight();
                    element = element.right;
                }

                public int Number
                 {
                     get { return element.number; }
                 }
            }
            TapeNode head;
            public iterator Iterator;
            static string defaultValue="*";
            public Tape() { head = null; }
            public Tape(string[]values,int iteratorNumber,int firstNumber)
            {
                
                head = new TapeNode(values[0], null, null,firstNumber);
                firstNumber++;
                TapeNode p = head;
                for(int i=1;i<values.Length;i++)
                {
                    p.right = new TapeNode(values[i], p, null,firstNumber);
                    firstNumber++;
                    p = p.right;
                }
                p=head;
                for (; p.number != iteratorNumber; p = p.right)
                    ;
                Iterator = new iterator(p);

            }
            public Tape(Tape b)
            {
                head = new TapeNode(b.head.value, null, null, b.head.number);

                for (TapeNode p = head, p1 = b.head.right; p1 != null; p1 = p1.right, p = p.right)
                {
                    p.right = new TapeNode(p1.value, p, null, p1.number);
                }
                TapeNode m = head;
                for (; m.number != b.Iterator.Number; m = m.right)
                    ;
                Iterator = new iterator(m);

                
            }
            public void AddToLeft()
            {
                
                head.left = new TapeNode(defaultValue, null, head, head.number - 1);
                head = head.left;
            }
            public void AddToRight()
            {
                TapeNode p = head;
                while (p.right != null)
                    p = p.right;
                p.right = new TapeNode(defaultValue, p, null, p.number + 1);
            }
            
            
        }
        class Tree
        {

            class TreeNode
            {
                int k;
                string conditions;
                List<Tape> Tapes;
                TreeNode parent;
                List<TreeNode> childs;
                int x0 = 0, dy = 50;
                //int width = 30, height = 30;
                int my_width;
                Label labelNode;
                ConditionsTree form;
                public static TreeNode prev = null;
                public static bool STOP = false;
                public TreeNode(ConditionsTree form, string conditions, TreeNode parent, List<Tape> list,int k=-1)
                {
                    this.k = k;
                    Tapes = new List<Tape>();
                    for (int i = 0; i < list.Count;i++ )
                    {
                        Tapes.Add(new Tape(list[i]));
                    }
                        this.form = form;
                    this.conditions = conditions;
                    this.parent = parent;

                    childs = new List<TreeNode>();


                }
                void draw()
                {
                    if (labelNode == null)
                    {
                        labelNode = new Label();
                        labelNode.AutoSize = true;
                        labelNode.Text = conditions;
                        labelNode.Font = new Font("Arial", 10);
                        labelNode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        labelNode.Cursor = Cursors.Hand;
                        labelNode.BorderStyle = BorderStyle.FixedSingle;
                        labelNode.Click += labelNode_Click;
                        form.panelTree.Controls.Add(labelNode);


                        if (parent == null)
                        {
                            labelNode.Location = new Point(form.Width / 2 - labelNode.Width / 2, 20);
                            x0 = 0;
                            my_width = form.Width;
                        }
                        else
                        {
                            labelNode.Location = new Point(x0 + my_width / 2 - labelNode.Width / 2, parent.labelNode.Location.Y + dy);
                        }
                    }
                    if (labelNode.BackColor == Color.Green)
                    {
                        DrawLine(Color.Red);
                    }
                    else
                    {
                        DrawLine(Color.Black);
                    }


                    if (childs.Count != 0)
                    {
                        int child_width = my_width / childs.Count;
                        for (int i = 0; i < childs.Count; i++)
                        {
                            childs[i].x0 = x0 + child_width * i;
                            childs[i].my_width = child_width;
                        }
                    }
                }
                void Clear()
                {

                    if (parent != null)
                    {
                        labelNode.Location = new Point(x0 + my_width / 2 - labelNode.Width / 2, parent.labelNode.Location.Y + dy);
                    }
                    DrawLine(form.panelTree.BackColor);

                    form.panelTree.Controls.Remove(labelNode);
                }
                public void add_child(TreeNode child)
                {
                    childs.Add(child);
                    child.parent = this;
                }
                void DrawLine(Color color)
                {
                    if (parent != null)
                    {
                        Pen pen = new Pen(color, 3);
                        Graphics g = form.panelTree.CreateGraphics();
                        g.DrawLine(pen, new Point(parent.labelNode.Location.X + parent.labelNode.Width / 2, parent.labelNode.Location.Y + parent.labelNode.Height / 2), new Point(labelNode.Location.X + labelNode.Width / 2, labelNode.Location.Y + labelNode.Height / 2));
                    }
                }
                void labelNode_Click(object sender, EventArgs e)
                {
                    if (TreeNode.prev != null)
                    {
                        TreeNode p1 = prev;
                        while (p1 != null)
                        {
                            p1.labelNode.BackColor = p1.form.panelTree.BackColor;
                            p1.DrawLine(Color.Black);
                            p1 = p1.parent;
                        }
                    }
                    TreeNode p = this;
                    prev = this;
                    while (p != null)
                    {
                        p.labelNode.BackColor = Color.Green;
                        p.DrawLine(Color.Red);
                        p = p.parent;

                    }
                    form.buttonStart.Enabled = true;
                }

                public void draw_tree()
                {
                    draw();
                    if (childs.Count != 0)
                    {
                        for (int i = 0; i < childs.Count; i++)
                            childs[i].draw_tree();
                    }
                }
                public void clear_tree()
                {

                    if (childs.Count != 0)
                        for (int i = 0; i < childs.Count; i++)
                            childs[i].Clear();
                    Clear();
                }
                public void Jobben()
                {
                    
                    if (conditions != "stop" && conditions != "error" && TreeNode.STOP==false)
                    {
                        string[] oldValues = new string[Tapes.Count];
                        for (int i = 0; i < oldValues.Length; i++)
                        {
                            oldValues[i] = Tapes[i].Iterator.Read();
                        }
                        List<int> k = new List<int>();
                        for (int i = 0; i < form.protocol.GetLength(0); i++)
                        {
                            if (conditions == form.protocol[i, 0])
                            {
                                bool f = true;
                                for (int j = 0; j < oldValues.Length && f==true; j++)
                                {
                                    if (oldValues[j] != form.protocol[i, 3 * j + 1])
                                        f = false;
                                }
                                if(f==true)
                                    k.Add(i);
                            }
                        }
                        if (k.Count > 0)
                        {
                            for (int i = 0; i < k.Count; i++)
                            {
                                TreeNode child = new TreeNode(form, form.protocol[k[i], form.protocol.GetLength(1) - 1], this, this.Tapes, k[i]);
                                for (int j = 0; j < child.Tapes.Count; j++)
                                {
                                    child.Tapes[j].Iterator.Write(form.protocol[k[i], 3 * j + 3]);
                                    switch (form.protocol[k[i], 3 * j + 2])
                                    {
                                        case "<-": child.Tapes[j].Iterator.ToLeft(child.Tapes[j]); break;
                                        case "->": child.Tapes[j].Iterator.ToRight(child.Tapes[j]); break;
                                        case "*": break;
                                        default: MessageBox.Show("ERROR!!!!!!!!!!"); break;
                                    }

                                }
                                add_child(child);
                            }
                        }
                        else
                        {

                            add_child(new TreeNode(form, "error", this, this.Tapes));
                        }
                    }
                    else
                    {
                        
                        TreeNode.STOP = true;
                    }
                    draw();
                }
                public int ChildsCount
                {
                    get { return childs.Count; }
                }
                public TreeNode Child_i(int i)
                {
                    return childs[i];
                }
                public List<int>ProtocolRows()
                {
                    List<int> result = new List<int>();
                    if (prev.conditions == "error")
                        prev = prev.parent;
                    for(TreeNode p=TreeNode.prev;p.parent!=null;p=p.parent)
                    {
                        result.Insert(0,p.k);
                    }
                    return result;
                }
                public void Resize()
                {
                    form.panelTree.Controls.Remove(labelNode);
                
                        if (parent == null)
                        {
                            labelNode.Location = new Point(form.Width / 2 - labelNode.Width / 2, 20);
                            x0 = 0;
                            my_width = form.Width;
                        }
                        else
                        {
                            if (labelNode != null)
                                labelNode.Location = new Point(x0 + my_width / 2 - labelNode.Width / 2, parent.labelNode.Location.Y + dy);

                        }

                        form.panelTree.Controls.Add(labelNode);
                        if (parent != null)
                        {
                            if (labelNode.BackColor == Color.Green)
                            {
                                DrawLine(Color.Red);
                            }
                            else
                                DrawLine(Color.Black);
                        }
                        if (ChildsCount > 0)
                        {
                            int childwidth = my_width / ChildsCount;
                            for (int i = 0; i < ChildsCount; i++)
                            {
                                childs[i].my_width = childwidth;
                                childs[i].x0 = x0 + i * childwidth;
                            }
                        }

                    }
                
                public void Resize_Tree()
                {
                    Resize();
                    for (int i = 0; i < ChildsCount; i++)
                        childs[i].Resize_Tree();

                }
            }
            TreeNode root;
            bool draw = false;
            public Tree(ConditionsTree form,List<Tape> l)
            {
                
                
                root = new TreeNode(form,"q1",null,l);
                draw = false;
               TreeNode.STOP = false;


            } 

            public void Drawing()
            {
                root.draw_tree();
                draw = true;
            }
            public void Clear()
            {
                if (draw == true)
                    root.clear_tree();
            }
            public void Jobben()
            {


                ConditionsTree.ConditionsTreeEnabled = false;
                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Count > 0) 
                {
                    TreeNode Node = q.Dequeue();
                    Node.Jobben();
                    if (Node.ChildsCount > 0)
                        for (int i = 0; i < Node.ChildsCount; i++)
                            q.Enqueue(Node.Child_i(i));

                }
                ConditionsTree.ConditionsTreeEnabled = true;

            }
            public List<int> protocolRows()
            {
                return root.ProtocolRows();
            }
            public void ReSize()
            {
                root.Resize_Tree();
            }
        }
    }
    
}
