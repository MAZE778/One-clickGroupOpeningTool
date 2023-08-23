using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace One_clickGroupOpeningToolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://maze778.github.io/disclaimer.html");
        }

        private bool stopLoop = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mianzeshengming_CheckedChanged(object sender, EventArgs e)
        {
            if (mianzeshengming.Checked == true)
            {
                kaituan.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                kaituan.Enabled = false;
                button1.Enabled = false;
            }
        }
        bool on = false;
        private async void kaituan_Click(object sender, EventArgs e)
        {
            int jiange = (int)numericUpDown3.Value;
            mianzeshengming.Enabled = false;
            double cishu = (double)numericUpDown1.Value;
            int yanshi = ((int)numericUpDown2.Value) * 1000;
            int xianchengnum = (int)num5.Value;
            double result = Math.Round(cishu / xianchengnum);
            on = true;
            numericUpDown4.Value = 0;

            await Task.Delay(yanshi);
            for (int i = 0; i < xianchengnum; i++)
            {
                if (on)
                {
                    await Task.Run(async () =>
                    {
                        for (int j = 0; j < (int)result; j++)
                        {
                            this.Invoke(new MethodInvoker(() => SendKeys.SendWait("^v")));
                            this.Invoke(new MethodInvoker(() => SendKeys.SendWait("{ENTER}")));
                            this.Invoke(new MethodInvoker(() => numericUpDown4.Value += 1));
                            await Task.Delay(jiange);
                        }
                    });
                }
            }
            mianzeshengming.Enabled = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            while (on)
            {
                on = false;
            }
            mianzeshengming.Enabled = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            while (on)
            {
                on = false;
            }
        }
    }
}
