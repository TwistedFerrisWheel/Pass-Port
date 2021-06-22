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
        protected char[] totalChars = new char[] {'a','b','c','d','e','f','g','h','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '?', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };

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
                charDistance = new int[] {0,60};

            //Upper Characters
            if (!lowerCheck.Checked && upperCheck.Checked && !specialCheck.Checked)
            {
                charDistance = new int[] { 26, 50 };
            }
            else if (!lowerCheck.Checked && upperCheck.Checked && specialCheck.Checked)
                charDistance = new int[] { 26, 60 };

            //Special Characters
            if (!lowerCheck.Checked && !upperCheck.Checked && specialCheck.Checked)
            {
                charDistance = new int[] { 51, 60 };
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(saveLocation, "accounts.dat");
            if (Directory.Exists(path))
            {
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader FileReader = new StreamReader(fStream);
                while (!FileReader.EndOfStream)
                {
                    string line = FileReader.ReadLine();

                }
                FileReader.Close();
            }

            lengthBar.Value = length;
            lengthLabel.Text = "Length: " + lengthBar.Value;
            length = lengthBar.Value;
        }

        private void lengthBar_ValueChanged(object sender, EventArgs e)
        {
            lengthLabel.Text = "Length: " + lengthBar.Value;
            length = lengthBar.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (accountBox.Text != "" && textBox2.Text != "")
            {
                var saveLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = Path.Combine(saveLocation, "accounts.dat");
                string[] lines = new string[] { accountBox.Text, textBox1.Text, textBox2.Text };
                string Message = "Account Name: " + lines[0] + "; Username:" + lines[1] + "; Password: " + lines[2];

                FileStream fStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter FileWriter = new StreamWriter(fStream);
                FileWriter.BaseStream.Seek(0, SeekOrigin.End);
                FileWriter.WriteLine(Message);
                FileWriter.Flush();
                FileWriter.Close();
                statusLabel.Text = "";

                Button accountButton = new Button();
                accountButton.Text = "Test";
                savedAccounts.Items.Add(accountButton);
            } else
            {
                statusLabel.Text = "Data was not Inputted Correctly: Please input a Account Name and Password";
            }
        }
    }
}
