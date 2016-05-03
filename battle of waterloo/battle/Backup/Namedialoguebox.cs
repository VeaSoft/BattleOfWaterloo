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
    public partial class Namedialoguebox : Form
    {
        public string playerName;
        public bool playfirst;
        public Namedialoguebox()
        {
            InitializeComponent();
            this.playfirst = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                playerName = textBox1.Text;
            }
            else
            {
                playerName = "new player";
                    
            }
            if (checkBox1.Checked == true)
            {
                playfirst = true;
            }
        }

        private void Namedialoguebox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text != "")
            {
                playerName = textBox1.Text;
            }
            else
            {
                playerName = "new player";

            }
            if (checkBox1.Checked == true)
            {
                playfirst = true;
            }
        }

        private void Namedialoguebox_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                playerName = textBox1.Text;
            }
            else
            {
                playerName = "new player";

            }
            if (checkBox1.Checked == true)
            {
                playfirst = true;
            }
        }
        

    }
}
