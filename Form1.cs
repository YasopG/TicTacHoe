namespace TicTacHoe
{
    public partial class Form1 : Form
    {
        public feld[,] felder = new feld[3, 3];



        public Form1()
        {
            InitializeComponent();
            feld1 = new feld();
            feld22 = new feld();
            feld222 = new feld();
            feld111 = new feld();
            feld2 = new feld();
            feld11 = new feld();
            feld3 = new feld();
            feld333 = new feld();
            feld33 = new feld();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void feld1_Load(object sender, EventArgs e)
        {

        }

        private void ResetGame()
        {
            // 1. Alle 9 Felder wieder auf "-" setzen
            felder = new feld[3, 3];

            // 2. Optional: Wenn du möchtest, dass immer Spieler "X" ein neues Spiel beginnt,
            // müsstest du die Variable sX in deinem Steuerelement zurücksetzen. 
            // Für den Anfang reicht das Leeren der Felder aber völlig aus!
        }

        public static void CheckWinner()
        {
            if (feld1.value == 0) { }
            //1. Zeile prüfen
            if (felder[0,0].Value != "-" &&
             felder[0,0].Value == felder[0,1].Value &&
             felder[0,1].Value == felder[0,2].Value)
            {
                MessageBox.Show(felder[0,0].Value + " hat gewonnen!");
            }

            //weitere Gewinnkonstellationen ergänzen
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
