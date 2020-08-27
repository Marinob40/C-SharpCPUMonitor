using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace C_SharpCPUMonitor
{
    public partial class Form1 : Form
    {

        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemoryCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCPU.Text = "CPU:" + "  " + (int)perfCPUCounter.NextValue() + "  " + "%";
            lblMemory.Text = "Available Memory:" + "  " + (int)perfMemoryCounter.NextValue() + "  " + "MB";
            lblSystem.Text = "System Up Time:" + "  " + (int)perfSystemCounter.NextValue() / 60 /60 + "Hours";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
