
namespace PasswordManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.lowerCheck = new System.Windows.Forms.CheckBox();
            this.upperCheck = new System.Windows.Forms.CheckBox();
            this.specialCheck = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.savedAccounts = new System.Windows.Forms.GroupBox();
            this.seePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Type Username Here...";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 51);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username/Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 108);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 4;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(266, 95);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(79, 34);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(351, 96);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 33);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // lowerCheck
            // 
            this.lowerCheck.AutoSize = true;
            this.lowerCheck.Location = new System.Drawing.Point(432, 105);
            this.lowerCheck.Name = "lowerCheck";
            this.lowerCheck.Size = new System.Drawing.Size(109, 17);
            this.lowerCheck.TabIndex = 7;
            this.lowerCheck.Text = "Lower Characters";
            this.lowerCheck.UseVisualStyleBackColor = true;
            // 
            // upperCheck
            // 
            this.upperCheck.AutoSize = true;
            this.upperCheck.Location = new System.Drawing.Point(547, 105);
            this.upperCheck.Name = "upperCheck";
            this.upperCheck.Size = new System.Drawing.Size(109, 17);
            this.upperCheck.TabIndex = 8;
            this.upperCheck.Text = "Upper Characters";
            this.upperCheck.UseVisualStyleBackColor = true;
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Location = new System.Drawing.Point(662, 105);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(61, 17);
            this.specialCheck.TabIndex = 9;
            this.specialCheck.Text = "Special";
            this.specialCheck.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(18, 198);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(185, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Account";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // savedAccounts
            // 
            this.savedAccounts.Location = new System.Drawing.Point(18, 227);
            this.savedAccounts.Name = "savedAccounts";
            this.savedAccounts.Size = new System.Drawing.Size(709, 235);
            this.savedAccounts.TabIndex = 11;
            this.savedAccounts.TabStop = false;
            this.savedAccounts.Text = "Saved Accounts";
            // 
            // seePassword
            // 
            this.seePassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.seePassword.AutoSize = true;
            this.seePassword.Location = new System.Drawing.Point(308, 135);
            this.seePassword.Name = "seePassword";
            this.seePassword.Size = new System.Drawing.Size(85, 23);
            this.seePassword.TabIndex = 12;
            this.seePassword.Text = "See Password";
            this.seePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seePassword.UseVisualStyleBackColor = true;
            this.seePassword.CheckedChanged += new System.EventHandler(this.seePassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 474);
            this.Controls.Add(this.seePassword);
            this.Controls.Add(this.savedAccounts);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.specialCheck);
            this.Controls.Add(this.upperCheck);
            this.Controls.Add(this.lowerCheck);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.CheckBox lowerCheck;
        private System.Windows.Forms.CheckBox upperCheck;
        private System.Windows.Forms.CheckBox specialCheck;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox savedAccounts;
        private System.Windows.Forms.CheckBox seePassword;
    }
}

