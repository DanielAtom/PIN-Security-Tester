using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Diagnostics;

namespace Password_Security_Tester___Bruteforce
{
    public partial class Form1 : Form
    {
        bool stop = false;
        Random rd = new Random();
        int lenght = 1;
        BigInteger lenghtn = 9;
        BigInteger triedpin;
        int lenghtnn = 1;
        int number = 0;
        int seconds = 0;
        int pins = 0;
        BigInteger corrpin;
        public Form1()
        {
            InitializeComponent();
            Utils.Main.ActivateUtils(1234);
            Utils.Controls.Corners.Set_BorderLess(this, 15);
        }

        private void utilsLabel1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void utilsLabel2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        delegate void SetTextCallback(string text);
        void AppendRich(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AppendRich);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.AppendText(text);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(stop == false)
            {
                pins++;
                string smk = lenghtn.ToString();
                triedpin = rd.Next(lenghtnn, Int32.Parse(smk));
                AppendRich("Tried pin: " + triedpin + Environment.NewLine);
                if (triedpin == corrpin)
                {
                    MessageBox.Show("PIN found! Bruteforce elasped in " + seconds + " seconds. " + pins + " tried.");
                    timer1.Stop();
                    stop = true;
                }
            }
        }

        private void utilsFlatButton2_Click(object sender, EventArgs e)
        {
            stop = true;
            timer1.Stop();
            pins = 0;
            seconds = 0;
            MessageBox.Show("PIN not found! Bruteforce elasped in " + seconds + " seconds. " + pins + " tried.");
        }

        private void utilsFlatButton1_Click(object sender, EventArgs e)
        {
            lenght = Int32.Parse(textBox1.Text);
            corrpin = BigInteger.Parse(textBox3.Text);
            for (int i = 1; i < lenght; i++)
            {
                lenghtn = (lenghtn * 10) + 9;
                lenghtnn = lenghtnn * 10;
            }
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionStart = richTextBox1.Text.Length;
            this.richTextBox1.ScrollToCaret();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DanielBence");
        }
    }
}
