using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_Expression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += (s, a) => { Process.Start("notepad"); };

            Label label = new Label();
            label.Text = "OGO!";
            label.Location = new Point(20, 20);
            Controls.Add(label);

        }
    }
}
