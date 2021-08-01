using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressDar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async void button1_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Stark\Desktop\123", "*.txt");
            int qt = files.Length;
            progressBar1.Maximum = qt;
            for (int i = qt; i > 0; i--)
            {
                label1.Text = files[i-1];
                progressBar1.Value++;
                await Task.Delay(500);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadProgressChanged += (s, a) => progressBar1.Value = a.ProgressPercentage;
                wc.DownloadFileAsync(new Uri(@"https://download.virtualbox.org/virtualbox/6.1.26/VirtualBox-6.1.26-145957-Win.exe"),
                    @"C:\Users\Stark\Desktop\VirtualBox6.exe");
            }
        }
    }
}
