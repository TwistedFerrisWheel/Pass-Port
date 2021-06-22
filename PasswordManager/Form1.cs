using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int length = 10;
        protected char[] totalChars = new char[] {'a','b','c','d','e','f','g','h','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '?', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };

        public Form1()
        {
            InitializeComponent();
        }

        string GeneratePassword()
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

                /*
                switch(lowerCheck.Checked)
                {
                    case true:
                        if (rand.Next(0, 5) == 0)
                        {
                            password_string += totalChars[rand.Next(0,25)];
                        }
                        break;
                }

                switch(upperCheck.Checked)
                {
                    case true:
                        if (rand.Next(0,5) == 0)
                            password_string += totalChars[rand.Next(26, 50)];
                        break;
                }

                switch(specialCheck.Checked)
                {
                    case true:
                        if (rand.Next(0,5) == 0)
                            password_string += totalChars[rand.Next(51, 60)];
                        break;
                }
                */
            }

            return password_string;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = GeneratePassword();
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
