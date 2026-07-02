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
            feld22 = new feld();
            feld222 = new feld();
            feld111 = new feld();
            feld2 = new feld();
            feld11 = new feld();
            feld3 = new feld();
            feld333 = new feld();
            feld33 = new feld();
            SuspendLayout();
            // 
            // feld1
            // 
            feld1.BackColor = SystemColors.ButtonShadow;
            feld1.Location = new Point(27, 29);
            feld1.Margin = new Padding(3, 5, 3, 5);
            feld1.Name = "feld1";
            feld1.Size = new Size(184, 216);
            feld1.TabIndex = 0;
            feld1.Load += feld1_Load;
            // 
            // feld22
            // 
            feld22.BackColor = SystemColors.ButtonShadow;
            feld22.Location = new Point(241, 267);
            feld22.Margin = new Padding(3, 5, 3, 5);
            feld22.Name = "feld22";
            feld22.Size = new Size(184, 216);
            feld22.TabIndex = 1;
            // 
            // feld222
            // 
            feld222.BackColor = SystemColors.ButtonShadow;
            feld222.Location = new Point(449, 267);
            feld222.Margin = new Padding(3, 5, 3, 5);
            feld222.Name = "feld222";
            feld222.Size = new Size(184, 216);
            feld222.TabIndex = 2;
            // 
            // feld111
            // 
            feld111.BackColor = SystemColors.ButtonShadow;
            feld111.Location = new Point(449, 29);
            feld111.Margin = new Padding(3, 5, 3, 5);
            feld111.Name = "feld111";
            feld111.Size = new Size(184, 216);
            feld111.TabIndex = 3;
            // 
            // feld2
            // 
            feld2.BackColor = SystemColors.ButtonShadow;
            feld2.Location = new Point(27, 267);
            feld2.Margin = new Padding(3, 5, 3, 5);
            feld2.Name = "feld2";
            feld2.Size = new Size(184, 216);
            feld2.TabIndex = 4;
            // 
            // feld11
            // 
            feld11.BackColor = SystemColors.ButtonShadow;
            feld11.Location = new Point(241, 29);
            feld11.Margin = new Padding(3, 5, 3, 5);
            feld11.Name = "feld11";
            feld11.Size = new Size(184, 216);
            feld11.TabIndex = 5;
            // 
            // feld3
            // 
            feld3.BackColor = SystemColors.ButtonShadow;
            feld3.Location = new Point(27, 505);
            feld3.Margin = new Padding(3, 5, 3, 5);
            feld3.Name = "feld3";
            feld3.Size = new Size(184, 216);
            feld3.TabIndex = 8;
            // 
            // feld333
            // 
            feld333.BackColor = SystemColors.ButtonShadow;
            feld333.Location = new Point(449, 505);
            feld333.Margin = new Padding(3, 5, 3, 5);
            feld333.Name = "feld333";
            feld333.Size = new Size(184, 216);
            feld333.TabIndex = 7;
            // 
            // feld33
            // 
            feld33.BackColor = SystemColors.ButtonShadow;
            feld33.Location = new Point(241, 505);
            feld33.Margin = new Padding(3, 5, 3, 5);
            feld33.Name = "feld33";
            feld33.Size = new Size(184, 216);
            feld33.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 748);
            Controls.Add(feld3);
            Controls.Add(feld333);
            Controls.Add(feld33);
            Controls.Add(feld11);
            Controls.Add(feld2);
            Controls.Add(feld111);
            Controls.Add(feld222);
            Controls.Add(feld22);
            Controls.Add(feld1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private feld feld1;
        private feld feld22;
        private feld feld222;
        private feld feld111;
        private feld feld2;
        private feld feld11;
        private feld feld3;
        private feld feld333;
        private feld feld33;
    }
}
