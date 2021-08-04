using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetCommandLineArgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Environment.GetCommandLineArgs().ToList().ForEach(x=>
            {
                if (x.EndsWith(@"/key"))
                    BackColor=Color.Red;
            }
            );
        }
    }
}
