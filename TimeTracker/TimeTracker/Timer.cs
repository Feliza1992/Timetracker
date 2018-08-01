using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Timer : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        TextFileOperations ops = new TextFileOperations();
        DateTime StartTime = DateTime.Now;
        TimeSpan timeSpan;
        public Timer()
        {
            
            InitializeComponent();
            if (ops.CheckIfEmpty()) { tbTimer.Text = "00:00:00"; }
            else { tbTimer.Text=ops.ReadTime(); }
 
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void UpdateTimer()
        {
            timeSpan= DateTime.Now - StartTime;
            tbTimer.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnManuell_Click(object sender, EventArgs e)
        {
            ManuelleEingabe manuelleEingabe = new ManuelleEingabe();
            manuelleEingabe.Show();
        }

        private void btnWoche_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
    
            ops.InsertTime(tbTimer.Text);
        }
    }
}
