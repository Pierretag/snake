using System.Collections.Generic;
namespace snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Grid_0x0 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.Grid_0x0)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_0x0
            // 
            this.Grid_0x0.Location = new System.Drawing.Point(0, 0);
            this.Grid_0x0.Name = "Grid_0x0";
            this.Grid_0x0.Size = new System.Drawing.Size(10, 10);
            this.Grid_0x0.TabIndex = 0;
            this.Grid_0x0.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GamePanel.Location = new System.Drawing.Point(10, 90);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(350, 220);
            this.GamePanel.TabIndex = 1;
            // 
            // timer2
            // 
         
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 318);
            this.Controls.Add(this.GamePanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_0x0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.PictureBox Grid_0x0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel GamePanel;
        
        
        
        
    }
}

