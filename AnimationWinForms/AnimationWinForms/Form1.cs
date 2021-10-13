using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationWinForms
{
    public partial class Form1 : Form
    {
        bool expectation;
        bool old;
        public Form1()
        {
            InitializeComponent();
            panel2.MouseEnter += async(s, a) =>
            {
                while (!expectation && panel2.Location.X > panel1.Location.X + 10)
                {
                    expectation = true;
                    await Task.Delay(1);
                    panel2.Location = old? new Point(panel2.Location.X - 10, panel2.Location.Y):
                    new Point(panel2.Location.X - panel2.Location.X/10, panel2.Location.Y);
                    expectation = false;
                }
            };

            panel1.MouseEnter += async (s, a) =>
            {
                while (!expectation && panel2.Location.X < panel1.Width)
                {
                    expectation = true;
                    await Task.Delay(1);
                    panel2.Location = old? new Point(panel2.Location.X + 10, panel2.Location.Y):
                    new Point(panel2.Location.X + (panel2.Width- panel2.Location.X)/8+2 , panel2.Location.Y);
                    expectation = false;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            old = !old;
        }
    }
}
