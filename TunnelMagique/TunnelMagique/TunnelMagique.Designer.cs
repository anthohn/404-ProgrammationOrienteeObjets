namespace TunnelMagique
{
    partial class TunnelMagique
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
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PnlContainer
            // 
            this.PnlContainer.BackColor = System.Drawing.Color.White;
            this.PnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlContainer.Location = new System.Drawing.Point(28, 27);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(250, 250);
            this.PnlContainer.TabIndex = 0;
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(130, 310);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(50, 50);
            this.BtnUp.TabIndex = 1;
            this.BtnUp.Text = "Up";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(179, 359);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(50, 50);
            this.BtnRight.TabIndex = 2;
            this.BtnRight.Text = "Right";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(130, 408);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(50, 50);
            this.BtnDown.TabIndex = 3;
            this.BtnDown.Text = "Down";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(80, 359);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(50, 50);
            this.BtnLeft.TabIndex = 4;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // TunnelMagique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 481);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.PnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TunnelMagique";
            this.Text = "Tunnel Magique";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnLeft;
    }
}

