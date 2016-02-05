namespace snake
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Game_name = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_instr = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pseudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Game_name
            // 
            this.Game_name.AutoSize = true;
            this.Game_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_name.Location = new System.Drawing.Point(277, 63);
            this.Game_name.Name = "Game_name";
            this.Game_name.Size = new System.Drawing.Size(180, 63);
            this.Game_name.TabIndex = 0;
            this.Game_name.Text = "Snake";
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(124, 319);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(117, 69);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Jouer";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_instr
            // 
            this.btn_instr.Location = new System.Drawing.Point(461, 319);
            this.btn_instr.Name = "btn_instr";
            this.btn_instr.Size = new System.Drawing.Size(143, 69);
            this.btn_instr.TabIndex = 2;
            this.btn_instr.Text = "Instructions";
            this.btn_instr.UseVisualStyleBackColor = true;
            this.btn_instr.Click += new System.EventHandler(this.btn_instr_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_quit.Location = new System.Drawing.Point(288, 449);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(117, 69);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pseudo :";
            // 
            // txt_pseudo
            // 
            this.txt_pseudo.Location = new System.Drawing.Point(345, 221);
            this.txt_pseudo.Name = "txt_pseudo";
            this.txt_pseudo.Size = new System.Drawing.Size(176, 31);
            this.txt_pseudo.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 613);
            this.Controls.Add(this.txt_pseudo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_instr);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.Game_name);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Game_name;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_instr;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pseudo;
    }
}