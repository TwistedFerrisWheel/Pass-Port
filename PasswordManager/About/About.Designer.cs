
namespace PasswordManager.About
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.githubButton = new System.Windows.Forms.Button();
            this.youtubeButton = new System.Windows.Forms.Button();
            this.ngButton = new System.Windows.Forms.Button();
            this.twitterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.aboutLabel.Location = new System.Drawing.Point(12, 9);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(79, 13);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Pass-Port v.0.1";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Created by TwistedFerrisWheel";
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.githubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.githubButton.Location = new System.Drawing.Point(12, 60);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(75, 42);
            this.githubButton.TabIndex = 23;
            this.githubButton.Text = "Github";
            this.githubButton.UseVisualStyleBackColor = false;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // youtubeButton
            // 
            this.youtubeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.youtubeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtubeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.youtubeButton.Location = new System.Drawing.Point(93, 60);
            this.youtubeButton.Name = "youtubeButton";
            this.youtubeButton.Size = new System.Drawing.Size(75, 42);
            this.youtubeButton.TabIndex = 24;
            this.youtubeButton.Text = "Youtube";
            this.youtubeButton.UseVisualStyleBackColor = false;
            this.youtubeButton.Click += new System.EventHandler(this.youtubeButton_Click);
            // 
            // ngButton
            // 
            this.ngButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ngButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ngButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.ngButton.Location = new System.Drawing.Point(174, 60);
            this.ngButton.Name = "ngButton";
            this.ngButton.Size = new System.Drawing.Size(75, 42);
            this.ngButton.TabIndex = 25;
            this.ngButton.Text = "Newgrounds";
            this.ngButton.UseVisualStyleBackColor = false;
            this.ngButton.Click += new System.EventHandler(this.ngButton_Click);
            // 
            // twitterButton
            // 
            this.twitterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.twitterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.twitterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.twitterButton.Location = new System.Drawing.Point(255, 60);
            this.twitterButton.Name = "twitterButton";
            this.twitterButton.Size = new System.Drawing.Size(75, 42);
            this.twitterButton.TabIndex = 26;
            this.twitterButton.Text = "Twitter";
            this.twitterButton.UseVisualStyleBackColor = false;
            this.twitterButton.Click += new System.EventHandler(this.twitterButton_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(362, 112);
            this.Controls.Add(this.twitterButton);
            this.Controls.Add(this.ngButton);
            this.Controls.Add(this.youtubeButton);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Button youtubeButton;
        private System.Windows.Forms.Button ngButton;
        private System.Windows.Forms.Button twitterButton;
    }
}