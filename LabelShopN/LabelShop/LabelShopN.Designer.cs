namespace LabelShop
{
    partial class LabelShopN
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btn90 = new System.Windows.Forms.Button();
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
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Location = new System.Drawing.Point(186, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(320, 320);
            this.pnlContainer.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(33, 247);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(124, 33);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Ouvrir ...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(33, 208);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(124, 33);
            this.btnSaveAs.TabIndex = 5;
            this.btnSaveAs.Text = "Enregistrer sous ...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(33, 169);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(124, 33);
            this.btnVertical.TabIndex = 6;
            this.btnVertical.Text = "Symétrie verticale";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(33, 130);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(124, 33);
            this.btnHorizontal.TabIndex = 7;
            this.btnHorizontal.Text = "Symétrie horizontale";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btn90
            // 
            this.btn90.Location = new System.Drawing.Point(33, 89);
            this.btn90.Name = "btn90";
            this.btn90.Size = new System.Drawing.Size(124, 33);
            this.btn90.TabIndex = 8;
            this.btn90.Text = "Rotation de +90°";
            this.btn90.UseVisualStyleBackColor = true;
            this.btn90.Click += new System.EventHandler(this.btn90_Click);
            // 
            // LabelShopN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 344);
            this.Controls.Add(this.btn90);
            this.Controls.Add(this.btnHorizontal);
            this.Controls.Add(this.btnVertical);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.BtnNewGrid);
            this.Controls.Add(this.ComboBoxColor);
            this.Controls.Add(this.TxtColorChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabelShopN";
            this.Text = "LabelShop Basique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtColorChoice;
        private System.Windows.Forms.ComboBox ComboBoxColor;
        private System.Windows.Forms.Button BtnNewGrid;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btn90;
    }
}

