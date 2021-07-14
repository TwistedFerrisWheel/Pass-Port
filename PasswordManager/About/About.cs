using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.About
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {

        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TwistedFerrisWheel");

        }

        private void youtubeButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCfSOnlyrjNG-Sj-P0CWRHVQ");
        }

        private void ngButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twistedferriswheel.newgrounds.com");
        }

        private void twitterButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/twistedferris");

        }
    }
}
