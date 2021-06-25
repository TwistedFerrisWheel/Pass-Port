
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.accountsGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.masterTextBox = new System.Windows.Forms.TextBox();
            this.masterPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lengthBar)).BeginInit();
            this.accountsGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(292, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(366, 70);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(85, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username/Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.passwordLabel.Location = new System.Drawing.Point(384, 127);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(292, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkButton.Location = new System.Drawing.Point(207, 134);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(79, 34);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.generateButton.Location = new System.Drawing.Point(534, 135);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 33);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // lowerCheck
            // 
            this.lowerCheck.AutoSize = true;
            this.lowerCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lowerCheck.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lowerCheck.Location = new System.Drawing.Point(292, 169);
            this.lowerCheck.Name = "lowerCheck";
            this.lowerCheck.Size = new System.Drawing.Size(109, 17);
            this.lowerCheck.TabIndex = 7;
            this.lowerCheck.Text = "Lower Characters";
            this.lowerCheck.UseVisualStyleBackColor = false;
            this.lowerCheck.CheckedChanged += new System.EventHandler(this.lowerCheck_CheckedChanged);
            // 
            // upperCheck
            // 
            this.upperCheck.AutoSize = true;
            this.upperCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.upperCheck.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.upperCheck.Location = new System.Drawing.Point(419, 169);
            this.upperCheck.Name = "upperCheck";
            this.upperCheck.Size = new System.Drawing.Size(109, 17);
            this.upperCheck.TabIndex = 8;
            this.upperCheck.Text = "Upper Characters";
            this.upperCheck.UseVisualStyleBackColor = false;
            this.upperCheck.CheckedChanged += new System.EventHandler(this.upperCheck_CheckedChanged);
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.specialCheck.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.specialCheck.Location = new System.Drawing.Point(352, 192);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(115, 17);
            this.specialCheck.TabIndex = 9;
            this.specialCheck.Text = "Special Characters";
            this.specialCheck.UseVisualStyleBackColor = false;
            this.specialCheck.CheckedChanged += new System.EventHandler(this.specialCheck_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Location = new System.Drawing.Point(12, 49);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(139, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Account";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lengthBar
            // 
            this.lengthBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lengthBar.Location = new System.Drawing.Point(75, 219);
            this.lengthBar.Maximum = 100;
            this.lengthBar.Minimum = 1;
            this.lengthBar.Name = "lengthBar";
            this.lengthBar.Size = new System.Drawing.Size(747, 45);
            this.lengthBar.TabIndex = 13;
            this.lengthBar.Value = 1;
            this.lengthBar.Scroll += new System.EventHandler(this.lengthBar_Scroll);
            this.lengthBar.ValueChanged += new System.EventHandler(this.lengthBar_ValueChanged);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lengthLabel.Location = new System.Drawing.Point(7, 226);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(46, 13);
            this.lengthLabel.TabIndex = 14;
            this.lengthLabel.Text = "Length: ";
            // 
            // accountBox
            // 
            this.accountBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.accountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.accountBox.Location = new System.Drawing.Point(292, 29);
            this.accountBox.Name = "accountBox";
            this.accountBox.Size = new System.Drawing.Size(236, 20);
            this.accountBox.TabIndex = 15;
            this.accountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accountBox.TextChanged += new System.EventHandler(this.accountBox_TextChanged);
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.accountNameLabel.Location = new System.Drawing.Point(373, 13);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(78, 13);
            this.accountNameLabel.TabIndex = 16;
            this.accountNameLabel.Text = "Account Name";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 23);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(61, 13);
            this.statusLabel.TabIndex = 17;
            this.statusLabel.Text = "dummyText";
            // 
            // savedAccounts
            // 
            this.savedAccounts.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.savedAccounts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.savedAccounts.FormattingEnabled = true;
            this.savedAccounts.Location = new System.Drawing.Point(187, 17);
            this.savedAccounts.Name = "savedAccounts";
            this.savedAccounts.Size = new System.Drawing.Size(533, 303);
            this.savedAccounts.TabIndex = 18;
            this.savedAccounts.SelectedIndexChanged += new System.EventHandler(this.savedAccounts_SelectedIndexChanged);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAccountButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteAccountButton.Location = new System.Drawing.Point(12, 78);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(96, 23);
            this.deleteAccountButton.TabIndex = 19;
            this.deleteAccountButton.Text = "Delete";
            this.deleteAccountButton.UseVisualStyleBackColor = false;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // accountsGroup
            // 
            this.accountsGroup.Controls.Add(this.savedAccounts);
            this.accountsGroup.Controls.Add(this.statusLabel);
            this.accountsGroup.Controls.Add(this.deleteAccountButton);
            this.accountsGroup.Controls.Add(this.saveButton);
            this.accountsGroup.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.accountsGroup.Location = new System.Drawing.Point(75, 271);
            this.accountsGroup.Name = "accountsGroup";
            this.accountsGroup.Size = new System.Drawing.Size(726, 326);
            this.accountsGroup.TabIndex = 20;
            this.accountsGroup.TabStop = false;
            this.accountsGroup.Text = "Accounts";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.masterTextBox);
            this.panel1.Controls.Add(this.masterPassLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 598);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(316, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(316, 245);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 49);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // masterTextBox
            // 
            this.masterTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.masterTextBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.masterTextBox.Location = new System.Drawing.Point(316, 219);
            this.masterTextBox.Name = "masterTextBox";
            this.masterTextBox.PasswordChar = '•';
            this.masterTextBox.Size = new System.Drawing.Size(181, 20);
            this.masterTextBox.TabIndex = 1;
            this.masterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // masterPassLabel
            // 
            this.masterPassLabel.AutoSize = true;
            this.masterPassLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.masterPassLabel.Location = new System.Drawing.Point(363, 196);
            this.masterPassLabel.Name = "masterPassLabel";
            this.masterPassLabel.Size = new System.Drawing.Size(88, 13);
            this.masterPassLabel.TabIndex = 0;
            this.masterPassLabel.Text = "Master Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(824, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountsGroup);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.accountBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthBar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthBar)).EndInit();
            this.accountsGroup.ResumeLayout(false);
            this.accountsGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.GroupBox accountsGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label masterPassLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox masterTextBox;
    }
}

