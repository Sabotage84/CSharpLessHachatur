using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace GetPCSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\cimv2","select * from win32_videocontroller");
            ManagementObjectCollection moc = mos.Get();
            foreach (var item in moc)
            {
                label1.Text = item.GetPropertyValue("Name").ToString();
            }
        }
    }
}
