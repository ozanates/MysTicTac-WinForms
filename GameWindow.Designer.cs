namespace Mystictac
{
    partial class GameWindow
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
            this.buttonPlaygroundSize_minus = new System.Windows.Forms.Button();
            this.buttonPlaygroundSize_plus = new System.Windows.Forms.Button();
            this.PlaygroundSizeLabel = new System.Windows.Forms.Label();
            this.LabelPlaygroundSize = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ScorePlayer1 = new System.Windows.Forms.Button();
            this.ScorePlayer2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.Playboard = new System.Windows.Forms.Panel();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlaygroundSize_minus
            // 
            this.buttonPlaygroundSize_minus.Location = new System.Drawing.Point(846, 59);
            this.buttonPlaygroundSize_minus.Name = "buttonPlaygroundSize_minus";
            this.buttonPlaygroundSize_minus.Size = new System.Drawing.Size(23, 23);
            this.buttonPlaygroundSize_minus.TabIndex = 0;
            this.buttonPlaygroundSize_minus.Text = "-";
            this.buttonPlaygroundSize_minus.UseVisualStyleBackColor = true;
            this.buttonPlaygroundSize_minus.Click += new System.EventHandler(this.buttonPlaygroundSize_minus_Click);
            // 
            // buttonPlaygroundSize_plus
            // 
            this.buttonPlaygroundSize_plus.Location = new System.Drawing.Point(963, 59);
            this.buttonPlaygroundSize_plus.Name = "buttonPlaygroundSize_plus";
            this.buttonPlaygroundSize_plus.Size = new System.Drawing.Size(23, 23);
            this.buttonPlaygroundSize_plus.TabIndex = 1;
            this.buttonPlaygroundSize_plus.Text = "+";
            this.buttonPlaygroundSize_plus.UseVisualStyleBackColor = true;
            this.buttonPlaygroundSize_plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPlaygroundSize_plus_MouseClick);
            // 
            // PlaygroundSizeLabel
            // 
            this.PlaygroundSizeLabel.AutoSize = true;
            this.PlaygroundSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlaygroundSizeLabel.Location = new System.Drawing.Point(854, 25);
            this.PlaygroundSizeLabel.Name = "PlaygroundSizeLabel";
            this.PlaygroundSizeLabel.Size = new System.Drawing.Size(123, 20);
            this.PlaygroundSizeLabel.TabIndex = 2;
            this.PlaygroundSizeLabel.Text = "Playground Size";
            // 
            // LabelPlaygroundSize
            // 
            this.LabelPlaygroundSize.Location = new System.Drawing.Point(877, 59);
            this.LabelPlaygroundSize.Name = "LabelPlaygroundSize";
            this.LabelPlaygroundSize.Size = new System.Drawing.Size(79, 23);
            this.LabelPlaygroundSize.TabIndex = 3;
            this.LabelPlaygroundSize.Text = "3";
            this.LabelPlaygroundSize.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Location = new System.Drawing.Point(846, 113);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(140, 45);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseClick);
            // 
            // ScorePlayer1
            // 
            this.ScorePlayer1.Location = new System.Drawing.Point(871, 373);
            this.ScorePlayer1.Name = "ScorePlayer1";
            this.ScorePlayer1.Size = new System.Drawing.Size(115, 56);
            this.ScorePlayer1.TabIndex = 6;
            this.ScorePlayer1.Text = "0";
            this.ScorePlayer1.UseVisualStyleBackColor = true;
            // 
            // ScorePlayer2
            // 
            this.ScorePlayer2.Location = new System.Drawing.Point(871, 435);
            this.ScorePlayer2.Name = "ScorePlayer2";
            this.ScorePlayer2.Size = new System.Drawing.Size(115, 56);
            this.ScorePlayer2.TabIndex = 7;
            this.ScorePlayer2.Text = "0";
            this.ScorePlayer2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(895, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scores";
            // 
            // canvas
            // 
            this.canvas.Controls.Add(this.Playboard);
            this.canvas.Controls.Add(this.StartButton);
            this.canvas.Controls.Add(this.label1);
            this.canvas.Controls.Add(this.ScorePlayer2);
            this.canvas.Controls.Add(this.ScorePlayer1);
            this.canvas.Controls.Add(this.LabelPlaygroundSize);
            this.canvas.Controls.Add(this.PlaygroundSizeLabel);
            this.canvas.Controls.Add(this.buttonPlaygroundSize_plus);
            this.canvas.Controls.Add(this.buttonPlaygroundSize_minus);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1000, 800);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Playboard
            // 
            this.Playboard.Location = new System.Drawing.Point(0, 0);
            this.Playboard.Name = "Playboard";
            this.Playboard.Size = new System.Drawing.Size(831, 800);
            this.Playboard.TabIndex = 9;
            this.Playboard.Paint += new System.Windows.Forms.PaintEventHandler(this.Playboard_Paint);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.canvas);
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mystictac";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameWindow_Paint);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlaygroundSize_minus;
        private System.Windows.Forms.Button buttonPlaygroundSize_plus;
        private System.Windows.Forms.Label PlaygroundSizeLabel;
        private System.Windows.Forms.Button LabelPlaygroundSize;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ScorePlayer1;
        private System.Windows.Forms.Button ScorePlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel Playboard;
    }
}

