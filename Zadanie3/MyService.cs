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
using System.Timers;

namespace Zadanie3
{
    partial class MyService : ServiceBase
    {
        Timer timer;
        public MyService()
        {
            InitializeComponent();
            timer = new Timer(1000);
            timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] line = new String[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\tmp\demo\file.txt", line);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
