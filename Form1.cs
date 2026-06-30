namespace TicTacHoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen stiffy = new Pen(Color.Magenta, 4);
            stiffy.Width = 10;
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;


        }

        private void feld1_Load(object sender, EventArgs e)
        {
            
        }

        private void ResetGame()
        {
            // 1. Alle 9 Felder wieder auf "-" setzen
            feld1.ClearField();
            feld2.ClearField();
            feld3.ClearField();
            feld4.ClearField();
            feld5.ClearField();
            feld6.ClearField();
            feld7.ClearField();
            feld8.ClearField();
            feld9.ClearField();

            // 2. Optional: Wenn du möchtest, dass immer Spieler "X" ein neues Spiel beginnt,
            // müsstest du die Variable sX in deinem Steuerelement zurücksetzen. 
            // Für den Anfang reicht das Leeren der Felder aber völlig aus!
        }

        public void CheckForWinner()
        {
            string gewinner = "";

            // 1. Waagerechte Reihen prüfen
            if (feld1.FieldText == feld2.FieldText && feld2.FieldText == feld3.FieldText && feld1.FieldText != "-")
                gewinner = feld1.FieldText;
            else if (feld4.FieldText == feld5.FieldText && feld5.FieldText == feld6.FieldText && feld4.FieldText != "-")
                gewinner = feld4.FieldText;
            else if (feld7.FieldText == feld8.FieldText && feld8.FieldText == feld9.FieldText && feld7.FieldText != "-")
                gewinner = feld7.FieldText;

            // 2. Senkrechte Reihen prüfen
            else if (feld1.FieldText == feld4.FieldText && feld4.FieldText == feld7.FieldText && feld1.FieldText != "-")
                gewinner = feld1.FieldText;
            else if (feld2.FieldText == feld5.FieldText && feld5.FieldText == feld8.FieldText && feld2.FieldText != "-")
                gewinner = feld2.FieldText;
            else if (feld3.FieldText == feld6.FieldText && feld6.FieldText == feld9.FieldText && feld3.FieldText != "-")
                gewinner = feld3.FieldText;

            // 3. Diagonale Reihen prüfen
            else if (feld1.FieldText == feld5.FieldText && feld5.FieldText == feld9.FieldText && feld1.FieldText != "-")
                gewinner = feld1.FieldText;
            else if (feld3.FieldText == feld5.FieldText && feld5.FieldText == feld7.FieldText && feld3.FieldText != "-")
                gewinner = feld3.FieldText;

            // Wenn 'gewinner' nicht mehr leer ist, hat jemand gewonnen!
            if (gewinner != "")
            {
                MessageBox.Show($"Spieler {gewinner} hat gewonnen!", "Spiel vorbei", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
                return; // Methode beenden, damit kein Unentschieden geprüft wird
            }

            // 4. Unentschieden prüfen (wenn kein Feld mehr "-" ist)
            if (feld1.FieldText != "-" && feld2.FieldText != "-" && feld3.FieldText != "-" &&
                feld4.FieldText != "-" && feld5.FieldText != "-" && feld6.FieldText != "-" &&
                feld7.FieldText != "-" && feld8.FieldText != "-" && feld9.FieldText != "-")
            {
                MessageBox.Show("Unentschieden!", "Spiel vorbei", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetGame();
            }
        }
    }
}
