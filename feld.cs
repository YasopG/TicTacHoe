using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacHoe
{

    public partial class feld : UserControl
    {
        // Aktueller Inhalt des Feldes
        public string value = "-";

        // Gibt den Text des Labels zurück
        public string FieldText
        {
            get { return lbl_field.Text; }
        }

        // Ermöglicht das Auslesen des Feldinhalts aus Form1
        public string Value
        {
            get { return lbl_field.Text; }
        }

        // Speichert, welcher Spieler als Nächstes dran ist
        static bool sX = true;

        public feld()
        {
            InitializeComponent();
            lbl_field.Text = "-";
        }

        private void lbl_field_Click(object sender, EventArgs e)
        {
            // Ein Feld darf nur einmal beschrieben werden
            if (lbl_field.Text == "-")
            {
                if (sX)
                {
                    lbl_field.Text = "X";
                }
                else
                {
                    lbl_field.Text = "O";
                }

                // Spieler wechseln
                sX = !sX;

                // Das Formular finden, auf dem das Feld liegt
                Form aktuellesFormular = this.FindForm();

                // Aktuelles Formular ist vom Typ "Form", unseres ist vom Typ "Form1", daher müssen wir es umwandeln
                // Von Form zu Form1 umwandeln
                Form1 spielFormular = (Form1)aktuellesFormular;

                // Gewinnbedingungen prüfen
                spielFormular.CheckWinner();
            }
        }

        public void ClearField()
        {
            // Feld zurücksetzen
            lbl_field.Text = "-";
        }
    }

}
