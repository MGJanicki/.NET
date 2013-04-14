using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAIN.NET
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
            
        }

        public void AddNodes()
        {
            MainForm parent = (MainForm)this.MdiParent;
            foreach (Point p in parent.model.points)
            {
                TreeNode t = new TreeNode(p.GetName());
                t.Nodes.Add(p.GetX().ToString());
                t.Nodes.Add(p.GetY().ToString());
                switch (p.GetColor())
                {
                    case colors.RED: t.Nodes.Add("Red");
                        break;
                    case colors.GREEN: t.Nodes.Add("Green");
                        break;
                    case colors.BLUE: t.Nodes.Add("Blue");
                        break;
                }
                treeView1.Nodes.Add(t);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.MdiParent;
            AddDialog ad = new AddDialog(parent);
            ad.ShowDialog();
        }
    }
}
