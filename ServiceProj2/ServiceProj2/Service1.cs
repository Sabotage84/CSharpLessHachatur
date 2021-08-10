using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProj2
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected async override void OnStart(string[] args)
        {
            while (true)
            {
                File.AppendAllText("Path", "SomeText");
                await Task.Delay(500);
            }
            
        }

        protected override void OnStop()
        {
        }
    }
}
