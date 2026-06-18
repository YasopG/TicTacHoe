namespace TicTacHoe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            feld1 = new feld();
            feld2 = new feld();
            feld3 = new feld();
            feld4 = new feld();
            feld5 = new feld();
            feld6 = new feld();
            feld7 = new feld();
            feld8 = new feld();
            feld9 = new feld();
            SuspendLayout();
            // 
            // feld1
            // 
            feld1.BackColor = SystemColors.ButtonShadow;
            feld1.Location = new Point(24, 22);
            feld1.Name = "feld1";
            feld1.Size = new Size(161, 162);
            feld1.TabIndex = 0;
            feld1.Load += feld1_Load;
            // 
            // feld2
            // 
            feld2.BackColor = SystemColors.ButtonShadow;
            feld2.Location = new Point(211, 200);
            feld2.Name = "feld2";
            feld2.Size = new Size(161, 162);
            feld2.TabIndex = 1;
            // 
            // feld3
            // 
            feld3.BackColor = SystemColors.ButtonShadow;
            feld3.Location = new Point(393, 200);
            feld3.Name = "feld3";
            feld3.Size = new Size(161, 162);
            feld3.TabIndex = 2;
            // 
            // feld4
            // 
            feld4.BackColor = SystemColors.ButtonShadow;
            feld4.Location = new Point(393, 22);
            feld4.Name = "feld4";
            feld4.Size = new Size(161, 162);
            feld4.TabIndex = 3;
            // 
            // feld5
            // 
            feld5.BackColor = SystemColors.ButtonShadow;
            feld5.Location = new Point(24, 200);
            feld5.Name = "feld5";
            feld5.Size = new Size(161, 162);
            feld5.TabIndex = 4;
            // 
            // feld6
            // 
            feld6.BackColor = SystemColors.ButtonShadow;
            feld6.Location = new Point(211, 22);
            feld6.Name = "feld6";
            feld6.Size = new Size(161, 162);
            feld6.TabIndex = 5;
            // 
            // feld7
            // 
            feld7.BackColor = SystemColors.ButtonShadow;
            feld7.Location = new Point(24, 379);
            feld7.Name = "feld7";
            feld7.Size = new Size(161, 162);
            feld7.TabIndex = 8;
            // 
            // feld8
            // 
            feld8.BackColor = SystemColors.ButtonShadow;
            feld8.Location = new Point(393, 379);
            feld8.Name = "feld8";
            feld8.Size = new Size(161, 162);
            feld8.TabIndex = 7;
            // 
            // feld9
            // 
            feld9.BackColor = SystemColors.ButtonShadow;
            feld9.Location = new Point(211, 379);
            feld9.Name = "feld9";
            feld9.Size = new Size(161, 162);
            feld9.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(feld7);
            Controls.Add(feld8);
            Controls.Add(feld9);
            Controls.Add(feld6);
            Controls.Add(feld5);
            Controls.Add(feld4);
            Controls.Add(feld3);
            Controls.Add(feld2);
            Controls.Add(feld1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private feld feld1;
        private feld feld2;
        private feld feld3;
        private feld feld4;
        private feld feld5;
        private feld feld6;
        private feld feld7;
        private feld feld8;
        private feld feld9;
    }
}
