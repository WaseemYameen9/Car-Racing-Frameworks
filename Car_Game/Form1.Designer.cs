
namespace Car_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.PgBar = new System.Windows.Forms.ProgressBar();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loop
            // 
            this.Loop.Enabled = true;
            this.Loop.Interval = 50;
            this.Loop.Tick += new System.EventHandler(this.Loop_Tick);
            // 
            // PgBar
            // 
            this.PgBar.Location = new System.Drawing.Point(41, 12);
            this.PgBar.Name = "PgBar";
            this.PgBar.Size = new System.Drawing.Size(121, 23);
            this.PgBar.TabIndex = 0;
            this.PgBar.Value = 100;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblscore.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Yellow;
            this.lblscore.Location = new System.Drawing.Point(27, 55);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 27);
            this.lblscore.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Game.Properties.Resources.Untitled_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.PgBar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Loop;
        private System.Windows.Forms.ProgressBar PgBar;
        private System.Windows.Forms.Label lblscore;
    }
}

