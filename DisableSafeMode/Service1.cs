using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace DisableSafeMode
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (SystemInformation.BootMode != BootMode.Normal)
            {
                Process.Start("shutdown.exe", "-r -f -t 0");
            }
            else
            {
                Thread thread = new Thread(new ThreadStart(StopInNormal));
                thread.Start();
            }
        }

        protected override void OnStop()
        {
        }

        public void StopInNormal()
        {
            Thread.Sleep(5000); 

            System.Environment.Exit(0);
        }
    }
}
