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
        Random rand = new Random();
        protected int length = 10;
        protected char[] totalChars = new char[] {'a','b','c','d','e','f','g','h','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '?', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')','1','2','3','4','5','6','7','8','9','0'};
        protected List<string> accountData = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        protected string GeneratePassword()
        {
            string password_string = "";
            int[] charDistance = new int[] {0,25};


            //Lower Characters
            if (lowerCheck.Checked && !upperCheck.Checked && !specialCheck.Checked)
            {
                charDistance = new int[] { 0, 25 };
            }
            else if (lowerCheck.Checked && upperCheck.Checked && !specialCheck.Checked)
            {
                charDistance = new int[] { 0, 50 };
            }
            else if (lowerCheck.Checked && upperCheck.Checked && specialCheck.Checked)
                charDistance = new int[] {0,69};

            //Upper Characters
            if (!lowerCheck.Checked && upperCheck.Checked && !specialCheck.Checked)
            {
                charDistance = new int[] { 26, 50 };
            }
            else if (!lowerCheck.Checked && upperCheck.Checked && specialCheck.Checked)
                charDistance = new int[] { 26, 69 };

            //Special Characters
            if (!lowerCheck.Checked && !upperCheck.Checked && specialCheck.Checked)
            {
                charDistance = new int[] { 51, 69 };
            }

            for (int chr = 0; chr < length; chr++)
            {
                password_string += totalChars[rand.Next(charDistance[0], charDistance[1])];
            }

            return password_string;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = GeneratePassword();
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
            savedAccounts.Sorted = true;
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

                savedAccounts.Sorted = true;

            } else
            {
                statusLabel.Text = "Data was not Inputted Correctly";
            }
        }

        private void savedAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(retrivePassword());
            
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (savedAccounts.SelectedIndex > -1)
            {
                var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = Path.Combine(saveLocation, "accounts.dat");
                List<string> linesList = File.ReadAllLines(path).ToList();

                linesList.RemoveAt(savedAccounts.SelectedIndex);

                File.WriteAllLines(path, linesList.ToArray());
                savedAccounts.Items.RemoveAt(savedAccounts.SelectedIndex);
                statusLabel.Text = "Account was Deleted!";
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
            DialogResult result = MessageBox.Show("This will redirect to HaveIBeenPwned/Passwords. Is this ok? ", "Redirect?",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
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

        private void loginButton_Click(object sender, EventArgs e)
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
                    line = Crypt.Decrypt(Crypt.encryptKey,FileReader.ReadLine());
                }
                FileReader.Close();

                if (line == masterTextBox.Text)
                {
                    panel1.Visible = false;
                    startup();
                }
                else
                    MessageBox.Show("Incorrect Master Password!", "Master Password Problem");
            } else
            {
                MessageBox.Show("Master Password Does not Exsist", "Master Password Problem");
            }

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
                } else
                {
                    MessageBox.Show("Master Password Already set!");
                }
            } else
            {
                MessageBox.Show("Make sure password is more than 12 characters", "Master Password Problem");
            }
        }
    }
}
