using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PasswordManager
{
    public partial class Form1 : Form
    {

        protected int length = 10;
        
        protected List<string> accountData = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Generator.generate(length);
            SFXHandler.play(Properties.Resources.act_generate);
            statusLabel.Text = "New Password was Generated";
        }

        protected void retriveUsernames()
        {
            for (int index = 0; index < accountData.Count; index++)
            {
                if (index % 3 == 0)
                    savedAccounts.Items.Add(accountData[index] + "/" + accountData[index + 1]);
            }
           

        }

        protected string retrivePassword()
        {

            for (int index = 0; index < accountData.Count; index++)
            {
                if (index % 3 == 0)
                {
                    if (savedAccounts.GetItemText(savedAccounts.SelectedItem) == accountData[index] + "/" + accountData[index+1])
                    {
                        return accountData[index + 2];
                    }
                }
            }

            return "Error Occured";
        }

        protected void loadData()
        {
            accountData.Clear();
            savedAccounts.Items.Clear();
            var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(saveLocation, "accounts.dat");
            if (File.Exists(path))
            {
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader FileReader = new StreamReader(fStream);
                while (!FileReader.EndOfStream)
                {
                    string line = Crypt.Decrypt(Crypt.encryptKey,FileReader.ReadLine());
                    string[] accountInfo = line.Split(';');
                    for (int index = 0; index < accountInfo.Length; index++)
                    {
                        accountData.Add(accountInfo[index]);
                    }
                }

                retriveUsernames();
                FileReader.Close();
            }
        }
        private void startup()
        {
            loadData();
            statusLabel.Text = "";
            lengthBar.Value = length;
            lengthLabel.Text = "Length: " + lengthBar.Value;
            length = lengthBar.Value;
            lengthBar.Maximum = 128;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lengthBar_ValueChanged(object sender, EventArgs e)
        {
            lengthLabel.Text = "Length: " + lengthBar.Value;
            length = lengthBar.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (accountBox.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = Path.Combine(saveLocation, "accounts.dat");
                string[] lines = new string[] {accountBox.Text, textBox1.Text, textBox2.Text };

                string Message = lines[0] + ";" + lines[1] + ";" + lines[2];

                FileStream fStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter FileWriter = new StreamWriter(fStream);
                FileWriter.BaseStream.Seek(0, SeekOrigin.End);
                FileWriter.WriteLine(Crypt.Encrypt(Crypt.encryptKey,Message));
                FileWriter.Flush();
                FileWriter.Close();
                statusLabel.Text = "";
                accountBox.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                loadData();

                SFXHandler.play(Properties.Resources.act_add);

            } else
            {
                statusLabel.Text = "Data was not Inputted Correctly";
            }
        }

        private void savedAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(retrivePassword());
            statusLabel.Text = "Password Copied";
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (savedAccounts.SelectedIndex > -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this account? It cannot be Retrived!", "Account Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    var path = Path.Combine(saveLocation, "accounts.dat");
                    List<string> linesList = File.ReadAllLines(path).ToList();

                    linesList.RemoveAt(savedAccounts.SelectedIndex);

                    File.WriteAllLines(path, linesList.ToArray());
                    savedAccounts.Items.RemoveAt(savedAccounts.SelectedIndex);
                    statusLabel.Text = "Account was Deleted!";
                    SFXHandler.play(Properties.Resources.act_delete);
                }
            } else
            {
                statusLabel.Text = "No Account Selected";
            }

        }

        private void lengthBar_Scroll(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will redirect to HaveIBeenPwned/Passwords and will copy the generated password To your clipboard. Is this ok? ", "Redirect?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (textBox2.Text.Length > 0)
                    Clipboard.SetText(textBox2.Text);
                System.Diagnostics.Process.Start("https://haveibeenpwned.com/Passwords");
            }
        }

        private void lowerCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void upperCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void specialCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(saveLocation, "MasterPass.enc");

            string line = "";
            if (File.Exists(path))
            {
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader FileReader = new StreamReader(fStream);
                while (!FileReader.EndOfStream)
                {
                    line = Crypt.Decrypt(Crypt.encryptKey, FileReader.ReadLine());
                }
                FileReader.Close();

                if (line == masterTextBox.Text)
                {
                    panel1.Visible = false;
                    startup();
                }
                else
                    MessageBox.Show("Incorrect Master Password!", "Master Password Problem");
            }
            else
            {
                MessageBox.Show("Master Password Does not Exsist", "Master Password Problem");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(saveLocation, "MasterPass.enc");


            if (masterTextBox.Text.Length > 10)
            {
                if (!File.Exists(path))
                {
                    FileStream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    StreamWriter FileWriter = new StreamWriter(fStream);
                    FileWriter.BaseStream.Seek(0, SeekOrigin.End);
                    FileWriter.WriteLine(Crypt.Encrypt(Crypt.encryptKey,masterTextBox.Text));
                    FileWriter.Flush();
                    FileWriter.Close();
                    MessageBox.Show("Master Password has now been set! Make sure to remember it", "Master Password Success",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    masterTextBox.Text = "";
                } else
                {
                    MessageBox.Show("Master Password Already set!","Master Password Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Make sure password is more than 12 characters", "Master Password Problem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void masterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
