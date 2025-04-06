namespace tictactoe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label playerWinsLabel;
        private System.Windows.Forms.Label computerWinsLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.computerWinsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Tag = "play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.playerClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.Tag = "play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.playerClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 2;
            this.button3.Tag = "play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.playerClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 3;
            this.button4.Tag = "play";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.playerClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 131);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 4;
            this.button5.Tag = "play";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.playerClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 131);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 5;
            this.button6.Tag = "play";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.playerClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 212);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 6;
            this.button7.Tag = "play";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.playerClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 7;
            this.button8.Tag = "play";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.playerClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(174, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 8;
            this.button9.Tag = "play";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.playerClick);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 293);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(237, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset Game";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.restartGame);
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.AutoSize = true;
            this.playerWinsLabel.Location = new System.Drawing.Point(12, 9);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(89, 20);
            this.playerWinsLabel.TabIndex = 10;
            this.playerWinsLabel.Text = "Player Wins: 0";
            // 
            // computerWinsLabel
            // 
            this.computerWinsLabel.AutoSize = true;
            this.computerWinsLabel.Location = new System.Drawing.Point(160, 9);
            this.computerWinsLabel.Name = "computerWinsLabel";
            this.computerWinsLabel.Size = new System.Drawing.Size(89, 20);
            this.computerWinsLabel.TabIndex = 11;
            this.computerWinsLabel.Text = "Computer Wins: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.computerWinsLabel);
            this.Controls.Add(this.playerWinsLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}