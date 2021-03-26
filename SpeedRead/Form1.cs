using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Timers;

namespace SpeedRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"The average person reads 300 WPM, but this can be increased to 400 " + "\r\n" +
                "or even 500 by removing the need to move your eyes. That's where SpeedRead comes in." + "\r\n" +
"\r\n" + "Just copy and paste the text into the textbox below and it'll display each word allowing you to read faster.", "About this program.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string messageBox = textBox1.Text;

            string blankSpace = label2.Text;

            string[] split = messageBox.Split(' ');

            for (int i = 0; i < split.Length; i++)
            {
                    label2.Text = split[i];
                    Task.Delay(200).Wait();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void aboutTheCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"I created this program using C# and Visual Studio. Feel free to click on my LinkedIn button or my Github profile button for more details about myself.", "About George Tabet.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/george-tabet-programmer/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GeorgeT59");
        }
    }
}
