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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            listView1.LabelEdit = false;
            listView1.View = View.Details;
            listView1.Columns.Add("Name", -2);
            listView1.Columns.Add("X", -2);
            listView1.Columns.Add("Y", -2);
            listView1.Columns.Add("Colour", -2);
        }
        
        public void AddNodes()
        {
            MainForm parent = (MainForm)this.MdiParent;
            foreach (Point p in parent.model.points)
            {
                ListViewItem item = new ListViewItem(p.GetName());
                item.SubItems.Add(p.GetX().ToString());
                item.SubItems.Add(p.GetY().ToString());
                switch (p.GetColor())
                {
                    case colors.RED: item.SubItems.Add("Red");
                        break;
                    case colors.GREEN: item.SubItems.Add("Green");
                        break;
                    case colors.BLUE: item.SubItems.Add("Blue");
                        break;
                }
                listView1.Items.Add(item);
            }
        }

    }
}
