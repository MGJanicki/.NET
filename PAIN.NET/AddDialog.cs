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
    public partial class AddDialog : Form
    {
        public AddDialog(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private MainForm mf;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            bool c1, c2, c3;
            int x = 0, y = 0;
            c1 = NameTextBox.Text != "";
            try
            {
                x = int.Parse(XTextBox.Text);
                c2 = true;
            }
            catch { c2 = false; }
            try
            {
                y = int.Parse(YTextBox.Text);
                c3 = true;
            }
            catch { c3 = false; }
            if (c1 && c2 && c3)
            {
                Point p = new Point(NameTextBox.Text, x, y, colors.GREEN);
                mf.model.Add(p);
                this.Close();
            }
        }

        private void NameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (NameTextBox.Text == "") ErrorProvider.SetError(NameTextBox, "Please enter point name");
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "") ErrorProvider.SetError(NameTextBox, "Please enter point name");
            else ErrorProvider.SetError(NameTextBox, "");
        }

        private void XtextBox_TextChanged(object sender, EventArgs e)
        {
            if (XTextBox.Text == "") ErrorProvider.SetError(XTextBox, "Please enter X coordinate");
            else
            {
                ErrorProvider.SetError(XTextBox, "");
                try
                {
                    int temp = int.Parse(XTextBox.Text);
                }
                catch { ErrorProvider.SetError(XTextBox, "Please give a number as coordinate"); }
            }
        }

        private void XtextBox_Validating(object sender, CancelEventArgs e)
        {
            if (XTextBox.Text == "") ErrorProvider.SetError(XTextBox, "Please enter X coordinate");
            else
            {
                ErrorProvider.SetError(XTextBox, "");
                try
                {
                    int temp = int.Parse(XTextBox.Text);
                }
                catch { ErrorProvider.SetError(XTextBox, "Please give a number as coordinate"); }
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            if (YTextBox.Text == "") ErrorProvider.SetError(YTextBox, "Please enter X coordinate");
            else
            {
                ErrorProvider.SetError(YTextBox, "");
                try
                {
                    int temp = int.Parse(YTextBox.Text);
                }
                catch { ErrorProvider.SetError(YTextBox, "Please give a number as coordinate"); }
            }
        }

        private void YTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (YTextBox.Text == "") ErrorProvider.SetError(YTextBox, "Please enter Y coordinate");
            else
            {
                ErrorProvider.SetError(YTextBox, "");
                try
                {
                    int temp = int.Parse(YTextBox.Text);
                }
                catch { ErrorProvider.SetError(YTextBox, "Please give a number as coordinate"); }
            }
        }
    }
}
