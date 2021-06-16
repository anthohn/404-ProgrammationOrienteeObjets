///ETML
///Auteur : Anthony Höhn
///Date : 14.06.2021
///Description : Tunnel magique, grid made up of 25x25 labels.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TunnelMagique
{
    public partial class TunnelMagique : Form
    {
        /// <summary>
        /// Constant : The number of labels in axe x
        /// </summary>
        private const int PANEL_WIDTH = 5;

        /// <summary>
        /// Constant : The number of labels axe y
        /// </summary>
        private const int PANEL_HEIGHT = 5;

        /// <summary>
        /// Constant :  The width of the labels
        /// </summary>
        private const int LABEL_WIDTH_SIZE = 50;

        /// <summary>
        /// Constant : The height of the labels
        /// </summary>
        private const int LABEL_HEIGHT_SIZE = 50;

        public int CURSOR_POSITION_X = 100;
        public int CURSOR_POSITION_Y = 100;


        private Point position = new Point(100, 100);
        Control currentLabel;


        /// <summary>
        /// Constructor
        /// </summary>
        public TunnelMagique()
        {
            InitializeComponent();

            //create labels in panel
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    Label lbl = new Label();

                    lbl.Width = LABEL_WIDTH_SIZE;
                    lbl.Height = LABEL_HEIGHT_SIZE;

                    lbl.Location = new Point(i * LABEL_WIDTH_SIZE, j * LABEL_HEIGHT_SIZE);


                    //border labels red
                    if (lbl.Location.X == 0 || lbl.Location.X == 200 || lbl.Location.Y == 0 || lbl.Location.Y == 200)
                    {
                        lbl.BackColor = Color.Red;
                        lbl.Tag = "Red";

                    }

                    //midle white line
                    if (lbl.Location.X == 100 || lbl.Location.Y == 100)
                    {
                        lbl.BackColor = Color.White;

                    }

                    // Middle Cursor
                    if (lbl.Location.Y == 100 && lbl.Location.X == 100)
                    {
                        lbl.BackColor = Color.Yellow;
                    }
                    PnlContainer.Controls.Add(lbl);
                }
            }
        }


        /// <summary>
        /// move the yellow point Up
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void BtnUp_Click(object sender, EventArgs e)
        {
            currentLabel = PnlContainer.GetChildAtPoint(position);
            if (currentLabel.Location.Y > 0)
            {
                currentLabel.BackColor = Color.White;
                position.Y -= 50;
                currentLabel = PnlContainer.GetChildAtPoint(position);
                currentLabel.BackColor = Color.Yellow;
            }
        }

        /// <summary>
        /// move the yellow point Right
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void BtnRight_Click(object sender, EventArgs e)
        {
            currentLabel = PnlContainer.GetChildAtPoint(position);
            if (currentLabel.Location.X < 200)
            {
                currentLabel.BackColor = Color.White;
                position.X += 50;
                currentLabel = PnlContainer.GetChildAtPoint(position);
                currentLabel.BackColor = Color.Yellow;
            }
        }

        /// <summary>
        /// move the yellow point Down
        /// </summary>
        /// <param name="sender">object that causes the event</param>6
        /// <param name="e">event-related data</param>
        private void BtnDown_Click(object sender, EventArgs e)
        {
            currentLabel = PnlContainer.GetChildAtPoint(position);
            if (currentLabel.Location.Y < 200)
            {
                currentLabel.BackColor = Color.White;
                position.Y += 50;
                currentLabel = PnlContainer.GetChildAtPoint(position);
                currentLabel.BackColor = Color.Yellow;
            }
        }

        /// <summary>
        /// move the yellow point Left
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void BtnLeft_Click(object sender, EventArgs e)
        {

            currentLabel = PnlContainer.GetChildAtPoint(position);
            if (currentLabel.Location.X > 0)
            {
                currentLabel.BackColor = Color.White;
                position.X -= 50;
                currentLabel = PnlContainer.GetChildAtPoint(position);
                currentLabel.BackColor = Color.Yellow;
            }
        }
    }
}
