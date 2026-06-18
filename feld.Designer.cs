namespace TicTacHoe
{
    partial class feld
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_field = new Label();
            SuspendLayout();
            // 
            // lbl_field
            // 
            lbl_field.Location = new Point(0, 0);
            lbl_field.Name = "lbl_field";
            lbl_field.Size = new Size(150, 150);
            lbl_field.TabIndex = 0;
            lbl_field.Click += lbl_field_Click;
            // 
            // feld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(lbl_field);
            Name = "feld";
            Load += feld_Load;
            BackColorChanged += feld_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_field;
    }
}
