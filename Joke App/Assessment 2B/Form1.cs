using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //display the joke question
        private void btnsetup_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "What did one wall say to the other wall?";

//Read more at: http://www.ducksters.com/jokes/silly.php This text is Copyright © Ducksters."

        }

        //display the joke answer 
        private void btnPunchline_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "I'll meet you at the corner";

//Read more at: http://www.ducksters.com/jokes/silly.php This text is Copyright © Ducksters";
        }

        //Display the default question
        private void btnReset_Click(object sender, EventArgs e)
        {
            JokeLabel.Text = "Ready for a Joke?";
        }

        //exit the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
