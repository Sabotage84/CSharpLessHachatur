using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAPI_2in1
{
    class RoundedButton:Button
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            IntPtr ptr = CreateRoundRectRgn(0, 0, Width, Height, 15, 15);
            Region = Region.FromHrgn(ptr);
        }
    }
}
