using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measurement
{
    public partial class Form1 : Form
    {
        TextBox lastOne = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var my_file = "mytext.txt";
            StreamWriter write = new StreamWriter(my_file, append: true);
            if (lastOne.Name == "txt_cm")
            {
                txt_dm.Text = (decimal.Parse(lastOne.Text) / 10).ToString();
                txt_m.Text = (decimal.Parse(lastOne.Text) / 100).ToString();
                write.WriteLine("cm entered:" +lastOne.Text+  "  answer dm:  " +txt_dm.Text+ "  answer m:  " +txt_m.Text);
               
            }
            else if (lastOne.Name == "txt_dm")
            {
                txt_cm.Text = (decimal.Parse(lastOne.Text) * 10).ToString();
                txt_m.Text = (decimal.Parse(lastOne.Text) / 10).ToString();
                write.WriteLine("dm entered:" + lastOne.Text +  "  answer cm:  " + txt_cm.Text + "  answer m:  " + txt_m.Text);

            }
            else
            {
                txt_cm.Text = (decimal.Parse(lastOne.Text) * 100).ToString();
                txt_dm.Text = (decimal.Parse(lastOne.Text) * 10).ToString();
                write.WriteLine("m entered:" + lastOne.Text + "  answer cm:  " + txt_cm.Text  + "  answer dm:  " + txt_dm.Text);

            }
            write.Close();
               
        }        

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            lastOne = (TextBox)sender;
            var data = this.Controls.OfType<TextBox>().Where(w => w.Name != lastOne.Name).ToList();
            foreach (TextBox txt in data)
            {
                txt.Text = "";
            }
            lbl_answer.Text = "";
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("mytext.txt");
            var t = sr.ReadToEnd();
            lbl_answer.Text = t;
            sr.Close();
        }
    }
}
