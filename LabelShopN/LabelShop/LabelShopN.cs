///ETML
///Auteur : Anthony Höhn
///Date : 14.06.2021
///Description : LabelShop BasiqueN, allows you to draw several colors in a grid made up of 32x32 labels.
///              as well a button that clears the grid. In addition it allows to make horizontal, vertical and 90 ° rotation of the drawing
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelShop
{
    public partial class LabelShopN : Form
    {
        //by default dosen't draw (false)
        private bool _isColorSelected = false;

        /// <summary>
        /// Constant : The number of labels in axe x
        /// </summary>
        private const int PANEL_WIDTH = 32;

        /// <summary>
        /// Constant : The number of labels axe y
        /// </summary>
        private const int PANEL_HEIGHT = 32;

        /// <summary>
        /// Constant :  The width of the labels
        /// </summary>
        private const int LABEL_WIDTH_SIZE = 10;

        /// <summary>
        /// Constant : The height of the labels
        /// </summary>
        private const int LABEL_HEIGHT_SIZE = 10;

        /// <summary>
        /// Constructor
        /// </summary>
        public LabelShopN()
        {
            InitializeComponent();

            //disabled button
            btn90.Enabled = false;
            btnHorizontal.Enabled = false;
            btnVertical.Enabled = false;
            btnSaveAs.Enabled = false;

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
            for (int i = 0; i < PANEL_WIDTH; i++)
            {
                for (int j = 0; j < PANEL_HEIGHT; j++)
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
        /// Invert drawing
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void MouseClickOnLabel(object sender, EventArgs e)
        {
            _isColorSelected = !_isColorSelected;
            btn90.Enabled = true;
            btnHorizontal.Enabled = true;
            btnVertical.Enabled = true;
            btnSaveAs.Enabled = true;
        }

        /// <summary>
        /// Replace all colors of the labels to white
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void BtnNewGrid_Click(object sender, EventArgs e)
        {
            //browse the table and replace the label by white color
            foreach (Label lbl in pnlContainer.Controls)
            {
                lbl.BackColor = Color.White;
            }

            //disabled button
            btn90.Enabled = false;
            btnHorizontal.Enabled = false;
            btnVertical.Enabled = false;
            btnSaveAs.Enabled = false;
        }

        /// <summary>
        /// Horizontal symmetry of the draw
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            foreach (Label lbl in pnlContainer.Controls)
            {
                lbl.Location = new Point(lbl.Location.X , pnlContainer.Height - lbl.Location.Y - lbl.Height);
            }
        }

        /// <summary>
        /// Vertical symmetry of the draw
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void btnVertical_Click(object sender, EventArgs e)
        {
            foreach (Label lbl in pnlContainer.Controls)
            {
                lbl.Location = new Point(pnlContainer.Width - lbl.Location.X - lbl.Height, lbl.Location.Y);
            }
        }

        /// <summary>
        /// 90° rotation of the draw
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void btn90_Click(object sender, EventArgs e)
        {
            foreach (Label lbl in pnlContainer.Controls)
            {
                lbl.Location = new Point(pnlContainer.Width - lbl.Location.Y - lbl.Height, lbl.Location.X);
            }

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
