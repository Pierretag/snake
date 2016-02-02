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
         
            this.Grid_0x0 = new System.Windows.Forms.PictureBox();
            
            ((System.ComponentModel.ISupportInitialize)(this.Grid_0x0)).BeginInit();
            this.SuspendLayout();
            // 
            // Snake
            // 
            

                // 
                // Grid_0x0
                // 
                this.Grid_0x0.Location = new System.Drawing.Point(0, 0);
            this.Grid_0x0.Name = "Grid_0x0";
            this.Grid_0x0.Size = new System.Drawing.Size(10, 10);
            this.Grid_0x0.TabIndex = 0;
            this.Grid_0x0.TabStop = false;

           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 318);
            
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.Grid_0x0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Palne_Game;
        private System.Windows.Forms.PictureBox Grid_0x0;
        
        
        
    }
}

