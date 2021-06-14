///ETML
///Auteur : Anthony Höhn
///Date : 14.06.2021
///Description : LabelShop Basique, permet de dessiner de plusieurs couleurs dans une grille composée de 32x32 labels 
///              ainsi qu'un bouton qui efface la grille.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelShop
{
    public partial class LabelShop : Form
    {

        //by default dosen't draw (false)
        private bool _isColorSelected = false;


        /// <summary>
        /// Constant : The number of labels in axe x
        /// </summary>
        private const int WIDTH = 32;


        /// Constant : The number of labels axe y
        private const int HEIGHT = 32;

        /// <summary>
        /// Constant :  The width of the labels
        /// </summary>
        private const int LABEL_WIDTH_SIZE = 10;

        /// <summary>
        /// Constant : The height of the labels
        /// </summary>
        private const int LABEL_HEIGHT_SIZE = 10;

        /// <summary>
        /// 
        /// </summary>
        public LabelShop()
        {
            InitializeComponent();

            //Color of the comboBox
            ComboBoxColor.Items.Add(Color.Green);
            ComboBoxColor.Items.Add(Color.Red);
            ComboBoxColor.Items.Add(Color.Blue);
            ComboBoxColor.Items.Add(Color.Black);
            ComboBoxColor.Items.Add(Color.White);
            ComboBoxColor.Items.Add(Color.Yellow);
            ComboBoxColor.Items.Add(Color.Purple);

            //default select 0 -> Green
            ComboBoxColor.SelectedIndex = 0;

            //create labels in panel
            for(int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    Label lbl = new Label();

                    lbl.Width = LABEL_WIDTH_SIZE;
                    lbl.Height = LABEL_HEIGHT_SIZE;

                    lbl.Location = new Point(i* LABEL_WIDTH_SIZE, j* LABEL_HEIGHT_SIZE);

                    lbl.BackColor = Color.White;

                    lbl.MouseMove += new MouseEventHandler(MouseMoveOnLabel);
                    lbl.MouseClick += new MouseEventHandler(MouseClickOnLabel);

                    pnlContainer.Controls.Add(lbl);

                }
            }

        }

        /// <summary>
        /// Color the labels by the selected color
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void MouseMoveOnLabel(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            if (_isColorSelected)
            {
                lbl.BackColor = (Color)ComboBoxColor.SelectedItem;
            }
        }

        /// <summary>
        /// invert drawing
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void MouseClickOnLabel(object sender, EventArgs e)
        {
            _isColorSelected = !_isColorSelected;
        }

        /// <summary>
        /// replace all colors of the labels to white
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void BtnNewGrid_Click(object sender, EventArgs e)
        {
            //browse the table and replace the label by white color
            foreach (Label lbl in this.pnlContainer.Controls)
            {
                lbl.BackColor = Color.White;
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
