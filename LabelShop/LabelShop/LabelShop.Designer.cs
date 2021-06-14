namespace LabelShop
{
    partial class LabelShop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtColorChoice = new System.Windows.Forms.Label();
            this.ComboBoxColor = new System.Windows.Forms.ComboBox();
            this.BtnNewGrid = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TxtColorChoice
            // 
            this.TxtColorChoice.AutoSize = true;
            this.TxtColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColorChoice.Location = new System.Drawing.Point(30, 27);
            this.TxtColorChoice.Name = "TxtColorChoice";
            this.TxtColorChoice.Size = new System.Drawing.Size(127, 16);
            this.TxtColorChoice.TabIndex = 0;
            this.TxtColorChoice.Text = "Choix des couleurs :";
            // 
            // ComboBoxColor
            // 
            this.ComboBoxColor.FormattingEnabled = true;
            this.ComboBoxColor.Location = new System.Drawing.Point(33, 62);
            this.ComboBoxColor.Name = "ComboBoxColor";
            this.ComboBoxColor.Size = new System.Drawing.Size(124, 21);
            this.ComboBoxColor.TabIndex = 1;
            this.ComboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnNewGrid
            // 
            this.BtnNewGrid.Location = new System.Drawing.Point(33, 286);
            this.BtnNewGrid.Name = "BtnNewGrid";
            this.BtnNewGrid.Size = new System.Drawing.Size(124, 36);
            this.BtnNewGrid.TabIndex = 2;
            this.BtnNewGrid.Text = "Nouvelle Grille";
            this.BtnNewGrid.UseVisualStyleBackColor = true;
            this.BtnNewGrid.Click += new System.EventHandler(this.BtnNewGrid_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Location = new System.Drawing.Point(186, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(320, 320);
            this.pnlContainer.TabIndex = 3;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // LabelShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 344);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.BtnNewGrid);
            this.Controls.Add(this.ComboBoxColor);
            this.Controls.Add(this.TxtColorChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelShop";
            this.Text = "LabelShop Basique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtColorChoice;
        private System.Windows.Forms.ComboBox ComboBoxColor;
        private System.Windows.Forms.Button BtnNewGrid;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

