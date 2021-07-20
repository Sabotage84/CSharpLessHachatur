using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSysWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(@"C:\Users\Stark\Desktop\",@"123.txt");
            watcher.EnableRaisingEvents = true;
            watcher.SynchronizingObject = this;

            watcher.Created += new FileSystemEventHandler(Watcher_Handler);
            watcher.Deleted += new FileSystemEventHandler(Watcher_Handler_Deleted);
            watcher.Renamed += new RenamedEventHandler(Watcher_Handler_Renamed);
        }

        private void Watcher_Handler_Renamed(object sender, FileSystemEventArgs e)
        {
            label1.Text += $"Переименован!{DateTime.Now}\n";
        }

        private void Watcher_Handler_Deleted(object sender, FileSystemEventArgs e)
        {
            label1.Text += $"Удален!{DateTime.Now}\n";
        }

        void Watcher_Handler(object sender, FileSystemEventArgs e)
        {
            label1.Text += $"Создан!{DateTime.Now}\n";
        }
    }
}
