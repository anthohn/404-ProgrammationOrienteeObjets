namespace WindowsFormsApp1
{
    partial class cavalier
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblCounterClick = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tailleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTxtCount = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(41, 470);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(120, 27);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Nouvelle partie";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // lblCounterClick
            // 
            this.lblCounterClick.AutoSize = true;
            this.lblCounterClick.Location = new System.Drawing.Point(400, 470);
            this.lblCounterClick.Name = "lblCounterClick";
            this.lblCounterClick.Size = new System.Drawing.Size(13, 13);
            this.lblCounterClick.TabIndex = 2;
            this.lblCounterClick.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tailleToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ToolStripMenuItem.Text = "Options";
            // 
            // tailleToolStripMenuItem
            // 
            this.tailleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x8ToolStripMenuItem,
            this.x16ToolStripMenuItem});
            this.tailleToolStripMenuItem.Name = "tailleToolStripMenuItem";
            this.tailleToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.tailleToolStripMenuItem.Text = "Taille";
            // 
            // x8ToolStripMenuItem
            // 
            this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
            this.x8ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.x8ToolStripMenuItem.Text = "8x8";
            this.x8ToolStripMenuItem.Click += new System.EventHandler(this.X8ToolStripMenuItem_Click);
            // 
            // x16ToolStripMenuItem
            // 
            this.x16ToolStripMenuItem.Name = "x16ToolStripMenuItem";
            this.x16ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.x16ToolStripMenuItem.Text = "16x16";
            this.x16ToolStripMenuItem.Click += new System.EventHandler(this.X16ToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.AideToolStripMenuItem_Click);
            // 
            // lblTxtCount
            // 
            this.lblTxtCount.AutoSize = true;
            this.lblTxtCount.Location = new System.Drawing.Point(303, 470);
            this.lblTxtCount.Name = "lblTxtCount";
            this.lblTxtCount.Size = new System.Drawing.Size(91, 13);
            this.lblTxtCount.TabIndex = 4;
            this.lblTxtCount.Text = "Nombre de coups";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(41, 45);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(400, 400);
            this.pnlContainer.TabIndex = 0;
            // 
            // cavalier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 521);
            this.Controls.Add(this.lblTxtCount);
            this.Controls.Add(this.lblCounterClick);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cavalier";
            this.Text = "Cavaliotche";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblCounterClick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tailleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Label lblTxtCount;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

