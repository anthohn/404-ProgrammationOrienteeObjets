using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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




        public TunnelMagique()
        {
            InitializeComponent();

            //create labels in panel
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Label lbl = new Label();

                    lbl.Width = LABEL_WIDTH_SIZE;
                    lbl.Height = LABEL_HEIGHT_SIZE;

                    lbl.Location = new Point(i * LABEL_WIDTH_SIZE, j * LABEL_HEIGHT_SIZE);

                    lbl.BackColor = Color.Red;
                    //j--;
                    //lbl.MouseMove += new MouseEventHandler(MouseMoveOnLabel);
                    //lbl.MouseClick += new MouseEventHandler(MouseClickOnLabel);

                    pnlContainer.Controls.Add(lbl);

                }

            }

            //create yellow label
            for (int i = 2; i < 3; i++)
            {

                for (int j = 2; j < 3; j++)
                {
                    Label lbl = new Label();

                    lbl.Width = LABEL_WIDTH_SIZE;
                    lbl.Height = LABEL_HEIGHT_SIZE;

                    lbl.Location = new Point(i * LABEL_WIDTH_SIZE, j * LABEL_HEIGHT_SIZE);

                    lbl.BackColor = Color.Yellow;

                    //lbl.MouseMove += new MouseEventHandler(MouseMoveOnLabel);
                    //lbl.MouseClick += new MouseEventHandler(MouseClickOnLabel);

                    pnlContainer.Controls.Add(lbl);

                }
            }
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
