using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoNotShorShutdown
{
    public partial class Form1 : Form
    {
        protected override void WndProc(ref Message m)//перехват события винды, любого 
        {
            if (m.Msg==0x11)//определяем по идендификатору что за событие 
            {
                MessageBox.Show("НЕХОРОШО");//ну и что-то делаем
            }
            base.WndProc(ref m);    
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
