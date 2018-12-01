using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            var left = textBox1.Text;
            var right = textBox2.Text;

            label1.Text = left + right;

            btn_calc.Text = "Calculated";
            btn_calc.BackColor = Color.Azure;
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            var txtBox = (TextBox)sender;
            try
            {
                int.Parse(txtBox.Text);
            }
            catch
            {
                txtBox.Text = txtBox.Text.Substring(0,txtBox.Text.Length-1);
                txtBox.SelectionStart = txtBox.Text.Length;
                txtBox.SelectionLength = 0;
            }
        }
    }
}
