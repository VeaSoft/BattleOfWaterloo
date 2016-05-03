using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tictacktoe
{
    public partial class StartPage : Form
    {
        string[] status;
        public StartPage()
        {
            InitializeComponent();
            status = new string[10]{"initializing modules","loading modules","setting up battlefield","setting up computer opponent","finalizing battle formation","organizing strategies","organization almost complete","finalization of battlefield","finallization almost completed","initialization complete" };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 1000)
            {
                progressBar1.Increment(progressBar1.Step);
                statusLabel.Text=status[progressBar1.Value%100];

            }
            else
            {
                this.Hide();
            }
        }
    }
}
