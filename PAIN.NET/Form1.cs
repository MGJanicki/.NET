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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            model = Model.GetInstance();
        }

        public Model model;

        private void treeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeForm tf = new TreeForm();
            tf.MdiParent = this;
            tf.AddNodes();
            tf.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListForm lf = new ListForm();
            lf.MdiParent = this;
            lf.AddNodes();
            lf.Show();
        }
    }
}
