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
            //Длинный вариант получаем видяху
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from win32_videocontroller");
            ManagementObjectCollection moc = mos.Get();
            foreach (var item in moc)
            {
                label1.Text = item.GetPropertyValue("Name").ToString();
            }

            label1.Text += "\n";

            //Покороче получаем мать
            foreach (var mo in new ManagementObjectSearcher("select * from win32_baseboard").Get())
            {
                label1.Text += $"{(string)mo["manufacturer"]} {(string)mo["product"]}";
            }
            label1.Text += "\n";

            //Получаем монитор проверить на большом компе
            foreach (var item in new ManagementObjectSearcher("root\\wmi", "select * from WmiMonitorID").Get())
            {
                foreach (var mo in (ushort[])item["UserFriendlyName"])
                {
                    label1.Text += (char)mo;
                }

            }
        }
    }
}
