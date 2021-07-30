using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Guid g1 = Guid.NewGuid();
            //label2.Text = g1.ToString();
            //label1.Text = g1.ToString().Remove(5);

            Guid g2 = Guid.NewGuid();
            var t1 = Encoding.UTF8.GetBytes(g2.ToString());
            string s1 = Convert.ToBase64String(t1);
            label1.Text = s1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
