using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManagerAddC : Form
    {
        public ManagerAddC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void writeToFile(string line)
        {
            StreamWriter sw = new StreamWriter("instructor.txt",true);
            sw.WriteLine(line);
            sw.Close();
        }
        private void addbut_Click(object sender, EventArgs e)
        {
            string id = idbox.Text;
            string pass = passbox.Text;
            string name = namebox.Text;
            string last = lastnbox.Text;
            string dep = depbox.Text;
            string cname = cnamebox.Text;
            string day = daybox.Text;
            string time = timebox.Text;
            char s = ' ';
            string line = (id+s+pass+s+name+s+last+s+dep+s+cname+s+day+s+time);
            writeToFile(line);
            lblero.Text = "added ☺";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
