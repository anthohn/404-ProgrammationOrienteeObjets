///ETML
///Auteur : Anthony Höhn
///Date : 16.06.2021
///Description : Cavalier game
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cavalier : Form
    {
        int[,] array = new int[1, 2];

        private int _compteur = 0;

        //private bool _isClicked = true;

        /// The number of button
        private int _nbrButton = 8;

        /// The width of the labels
        private int _sizeButton = 50;

        //private Point _position = new Point(100, 100);
        Control currentLabel;

        /// <summary>
        /// Constructor
        /// </summary>
        public cavalier()
        {
            InitializeComponent();
            GenerateGame();
        }

        /// <summary>
        /// Grid buttons generations 
        /// </summary>
        private void GenerateGame()
        {
            lblCounterClick.Text = Convert.ToString(_compteur = 0);
            pnlContainer.Controls.Clear();
            //create labels in panel
            for (int i = 0; i < _nbrButton; i++)
            {
                for (int j = 0; j < _nbrButton; j++)
                {
                    Button btn = new Button();

                    btn.Width = _sizeButton;
                    btn.Height = _sizeButton;

                    btn.Location = new Point(i * _sizeButton, j * _sizeButton);

                    btn.MouseClick += new MouseEventHandler(ClickButton);

                    pnlContainer.Controls.Add(btn);
                }

            }
        }

        /// <summary>
        /// Set the clicked button in yellow
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void ClickButton(object sender, EventArgs e)
        {

            Point _position = new Point(200, 200);
            currentLabel = pnlContainer.GetChildAtPoint(_position);
            currentLabel.BackColor = Color.Yellow;


            Button btn = (Button)sender;

            btn.BackColor = Color.Red;
            lblCounterClick.Text = Convert.ToString(++_compteur);
        }

        /// <summary>
        /// Clear the buttons and sets the number of moves to 0
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            foreach (Button btn in pnlContainer.Controls)
            {
                btn.BackColor = Color.White;
            }

            lblCounterClick.Text = Convert.ToString(_compteur = 0);
        }

        /// <summary>
        /// Generate the game in 8x8
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void X8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sizeButton = 50;
            _nbrButton = 8;
            GenerateGame();
        }

        /// <summary>
        /// Generate the game in 16x16
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void X16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sizeButton = 25;
            _nbrButton = 16;
            GenerateGame();
        }

        /// <summary>
        /// Pop-up text d'aide
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void AideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voici l'aide ! LoL");
        }

        private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                MessageBox.Show("test");    
            }
        }
    }
}
