using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelShop
{
    public partial class LabelShop : Form
    {

        //by default do not draw
        private bool isColorSelected = false;


        /// <summary>
        /// Constant : The number of labels in axe x
        /// </summary>
        private const int WIDTH = 32;

        /// <summary>
        /// Constant : The number of labels axe y
        /// </summary>
        private const int HEIGHT = 32;

        /// <summary>
        /// Constant :  The width of the labels
        /// </summary>
        private const int LABEL_WIDTH_SIZE = 10;

        /// <summary>
        /// Constant : The width of the labels
        /// </summary>
        private const int LABEL_HEIGHT_SIZE = 10;



        public LabelShop()
        {
            InitializeComponent();

            ComboBoxColor.Items.Add(Color.Green);
            ComboBoxColor.Items.Add(Color.Red);
            ComboBoxColor.Items.Add(Color.Blue);
            ComboBoxColor.Items.Add(Color.Black);
            ComboBoxColor.Items.Add(Color.White);
            ComboBoxColor.Items.Add(Color.Yellow);
            ComboBoxColor.Items.Add(Color.Purple);

            ComboBoxColor.SelectedIndex = 0;



            
            for(int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    Label lbl = new Label();

                    lbl.Width = LABEL_WIDTH_SIZE;
                    lbl.Height = LABEL_HEIGHT_SIZE;

                    lbl.Location = new Point(i* LABEL_WIDTH_SIZE, j* LABEL_HEIGHT_SIZE);

                    lbl.BackColor = Color.White;

                    lbl.MouseMove += new MouseEventHandler(MouseMoveOnLabl);
                    lbl.MouseClick += new MouseEventHandler(MouseClickOnLabel);

                    pnlContainer.Controls.Add(lbl);

                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">object that causes the event</param>
        /// <param name="e">event-related data</param>
        private void MouseMoveOnLabl(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            if (isColorSelected)
            {
                lbl.BackColor = (Color)ComboBoxColor.SelectedItem;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseClickOnLabel(object sender, EventArgs e)
        {
            isColorSelected = !isColorSelected;
        }

        private void PanelSize(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNewGrid_Click(object sender, EventArgs e)
        {
            //browse the table and replace the label by white color
            foreach(Label lbl in this.pnlContainer.Controls)
            {
                lbl.BackColor = Color.White;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
