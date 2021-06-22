
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
            this.lengthBar = new System.Windows.Forms.TrackBar();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.accountBox = new System.Windows.Forms.TextBox();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.savedAccounts = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(15, 67);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username/Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 100);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 4;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(266, 90);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(79, 34);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(351, 91);
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
            this.lowerCheck.Location = new System.Drawing.Point(432, 100);
            this.lowerCheck.Name = "lowerCheck";
            this.lowerCheck.Size = new System.Drawing.Size(109, 17);
            this.lowerCheck.TabIndex = 7;
            this.lowerCheck.Text = "Lower Characters";
            this.lowerCheck.UseVisualStyleBackColor = true;
            // 
            // upperCheck
            // 
            this.upperCheck.AutoSize = true;
            this.upperCheck.Location = new System.Drawing.Point(547, 100);
            this.upperCheck.Name = "upperCheck";
            this.upperCheck.Size = new System.Drawing.Size(109, 17);
            this.upperCheck.TabIndex = 8;
            this.upperCheck.Text = "Upper Characters";
            this.upperCheck.UseVisualStyleBackColor = true;
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Location = new System.Drawing.Point(662, 100);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(115, 17);
            this.specialCheck.TabIndex = 9;
            this.specialCheck.Text = "Special Characters";
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
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lengthBar
            // 
            this.lengthBar.Location = new System.Drawing.Point(75, 147);
            this.lengthBar.Maximum = 100;
            this.lengthBar.Minimum = 1;
            this.lengthBar.Name = "lengthBar";
            this.lengthBar.Size = new System.Drawing.Size(747, 45);
            this.lengthBar.TabIndex = 13;
            this.lengthBar.Value = 1;
            this.lengthBar.ValueChanged += new System.EventHandler(this.lengthBar_ValueChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 158);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(46, 13);
            this.lengthLabel.TabIndex = 14;
            this.lengthLabel.Text = "Length: ";
            // 
            // accountBox
            // 
            this.accountBox.Location = new System.Drawing.Point(99, 33);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(236, 20);
            this.accountBox.TabIndex = 15;
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(15, 36);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(78, 13);
            this.accountNameLabel.TabIndex = 16;
            this.accountNameLabel.Text = "Account Name";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(209, 203);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 17;
            // 
            // savedAccounts
            // 
            this.savedAccounts.FormattingEnabled = true;
            this.savedAccounts.Location = new System.Drawing.Point(19, 236);
            this.savedAccounts.Name = "savedAccounts";
            this.savedAccounts.Size = new System.Drawing.Size(803, 368);
            this.savedAccounts.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 609);
            this.Controls.Add(this.savedAccounts);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthBar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TrackBar lengthBar;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox accountBox;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListBox savedAccounts;
    }
}

