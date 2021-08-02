using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopTask
{
    public partial class Form1 : Form
    {
        bool need = true;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            label1.Click += (s, e) => { need = false; };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                while (need)
                {
                    label1.Text += "1";
                    await Task.Delay(200);
                }
            });
        }
    }
}
