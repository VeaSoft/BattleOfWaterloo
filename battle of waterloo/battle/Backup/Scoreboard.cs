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
    public partial class Scoreboard : Form
    {
        private string playerName;
        private int TotalBattlesFought;
        private int TotalBattlesWon;
        private int TotalBattlesLost;
        private int TotalBattlesDrawn;
        public string Playername
        {
            get
            {
                return playerName;
                
            }
            set
            {
                playerName = value;
                Nametb.Text = Playername;
            }
        }
        public int tTotalBattlesFought
        {
            get
            {
                return TotalBattlesFought;
            }
            set
            {
                TotalBattlesFought = value;
                battlesfoughttb.Text =Convert.ToString(tTotalBattlesFought);
            }
        }
        public int tTotalBattlesWon
        {
            get
            {
                return TotalBattlesWon;
                
            }
            set
            {
                TotalBattlesWon = value;
                battleswontb.Text = Convert.ToString(tTotalBattlesWon);
            }
        }
        public int tTotalBattleslost
        {
            get
            {
                return TotalBattlesLost;
            }
            set
            {
                TotalBattlesLost = value;
                battleslosttb.Text = Convert.ToString(tTotalBattleslost);

            }
        }
        public int tTotalBattlesDrawn
        {
            get
            {
                return TotalBattlesDrawn;
            }
            set
            {
                TotalBattlesDrawn = value;
                battlesdrawntb.Text = Convert.ToString(tTotalBattlesDrawn);
            }
        }
        public Scoreboard()
        {
            InitializeComponent();
        }
        public void saveScores()
        {
            string scontent = Convert.ToString(tTotalBattlesWon);
            if (FileWriter.writetofile(@"C:\savescores.txt", scontent) == true)
            {
                MessageBox.Show("Score saving operation complete", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Score saving operation could not be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveScores();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            string printdoc="Player name: "+playerName+"\n"+"total battles fought: "+ tTotalBattlesFought+"\n"+"Total battles won: "+tTotalBattlesWon+"\n"+"total battles lost: "+TotalBattlesLost +"\n" +"total battles drawn: "+tTotalBattlesDrawn;
            e.Graphics.DrawString(printdoc, new Font(new FontFamily("Microsoft Sans Serif"), 20), Brushes.Gray, new PointF(40, 40));
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = printDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
