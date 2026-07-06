namespace TicTacHoe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Prüft, ob ein Spieler gewonnen hat
        public void CheckWinner()
        {
            // Zeilen prüfen
            if (feld1.Value != "-" &&
                feld1.Value == feld11.Value &&
                feld11.Value == feld111.Value)
            {
                MessageBox.Show(feld1.Value + " hat gewonnen!");
                return;
            }

            if (feld2.Value != "-" &&
                feld2.Value == feld22.Value &&
                feld22.Value == feld222.Value)
            {
                MessageBox.Show(feld2.Value + " hat gewonnen!");
                return;
            }

            if (feld3.Value != "-" &&
                feld3.Value == feld33.Value &&
                feld33.Value == feld333.Value)
            {
                MessageBox.Show(feld3.Value + " hat gewonnen!");
                return;
            }

            // Spalten prüfen
            if (feld1.Value != "-" &&
                feld1.Value == feld2.Value &&
                feld2.Value == feld3.Value)
            {
                MessageBox.Show(feld1.Value + " hat gewonnen!");
                return;
            }

            if (feld11.Value != "-" &&
                feld11.Value == feld22.Value &&
                feld22.Value == feld33.Value)
            {
                MessageBox.Show(feld11.Value + " hat gewonnen!");
                return;
            }

            if (feld111.Value != "-" &&
                feld111.Value == feld222.Value &&
                feld222.Value == feld333.Value)
            {
                MessageBox.Show(feld111.Value + " hat gewonnen!");
                return;
            }

            // Diagonalen prüfen
            if (feld1.Value != "-" &&
                feld1.Value == feld22.Value &&
                feld22.Value == feld333.Value)
            {
                MessageBox.Show(feld1.Value + " hat gewonnen!");
                return;
            }

            if (feld111.Value != "-" &&
                feld111.Value == feld22.Value &&
                feld22.Value == feld3.Value)
            {
                MessageBox.Show(feld111.Value + " hat gewonnen!");
                return;
            }
        }

    }

}
