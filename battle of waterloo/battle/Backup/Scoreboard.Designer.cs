namespace tictacktoe
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.battlesdrawntb = new System.Windows.Forms.TextBox();
            this.battleslosttb = new System.Windows.Forms.TextBox();
            this.battleswontb = new System.Windows.Forms.TextBox();
            this.battlesfoughttb = new System.Windows.Forms.TextBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 455);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.battlesdrawntb);
            this.panel2.Controls.Add(this.battleslosttb);
            this.panel2.Controls.Add(this.battleswontb);
            this.panel2.Controls.Add(this.battlesfoughttb);
            this.panel2.Controls.Add(this.Nametb);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 367);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Print Scores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save Scores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // battlesdrawntb
            // 
            this.battlesdrawntb.ForeColor = System.Drawing.Color.Blue;
            this.battlesdrawntb.Location = new System.Drawing.Point(262, 195);
            this.battlesdrawntb.Name = "battlesdrawntb";
            this.battlesdrawntb.ReadOnly = true;
            this.battlesdrawntb.Size = new System.Drawing.Size(91, 20);
            this.battlesdrawntb.TabIndex = 9;
            this.battlesdrawntb.Text = "0";
            // 
            // battleslosttb
            // 
            this.battleslosttb.ForeColor = System.Drawing.Color.Blue;
            this.battleslosttb.Location = new System.Drawing.Point(262, 153);
            this.battleslosttb.Name = "battleslosttb";
            this.battleslosttb.ReadOnly = true;
            this.battleslosttb.Size = new System.Drawing.Size(91, 20);
            this.battleslosttb.TabIndex = 8;
            this.battleslosttb.Text = "0";
            // 
            // battleswontb
            // 
            this.battleswontb.ForeColor = System.Drawing.Color.Blue;
            this.battleswontb.Location = new System.Drawing.Point(262, 114);
            this.battleswontb.Name = "battleswontb";
            this.battleswontb.ReadOnly = true;
            this.battleswontb.Size = new System.Drawing.Size(91, 20);
            this.battleswontb.TabIndex = 7;
            this.battleswontb.Text = "0";
            // 
            // battlesfoughttb
            // 
            this.battlesfoughttb.ForeColor = System.Drawing.Color.Blue;
            this.battlesfoughttb.Location = new System.Drawing.Point(262, 73);
            this.battlesfoughttb.Name = "battlesfoughttb";
            this.battlesfoughttb.ReadOnly = true;
            this.battlesfoughttb.Size = new System.Drawing.Size(91, 20);
            this.battlesfoughttb.TabIndex = 6;
            this.battlesfoughttb.Text = "0";
            // 
            // Nametb
            // 
            this.Nametb.ForeColor = System.Drawing.Color.Blue;
            this.Nametb.Location = new System.Drawing.Point(198, 35);
            this.Nametb.Name = "Nametb";
            this.Nametb.ReadOnly = true;
            this.Nametb.Size = new System.Drawing.Size(155, 20);
            this.Nametb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(3, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Numbers Of Battles Drawn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numbers Of Battles Lost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numbers Of Battles Won:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numbers Of Battles Fought:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of Player:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scoreboard";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 455);
            this.Controls.Add(this.panel1);
            this.Name = "Scoreboard";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scoreboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox battlesdrawntb;
        private System.Windows.Forms.TextBox battleslosttb;
        private System.Windows.Forms.TextBox battleswontb;
        private System.Windows.Forms.TextBox battlesfoughttb;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}