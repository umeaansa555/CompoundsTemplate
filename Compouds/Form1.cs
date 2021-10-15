using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compounds
{
    public partial class Form1 : Form
    {
        string suit = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void hurricaneButton_Click(object sender, EventArgs e)
        {
            //get the inputted category
            int category = Convert.ToInt32(categoryInput.Text);

            //check the inputted category with a switch block
            switch (category)
            {
                case 1:
                    categoryOutput.Text = "119-153 km/hr";
                    break;
                case 2:
                    categoryOutput.Text = "154-177 km/hr";
                    break;
                case 3:
                    categoryOutput.Text = "178-209 km/hr";
                    break;
                case 4:
                    categoryOutput.Text = "210-249 km/hr";
                    break;
                case 5:
                    categoryOutput.Text = "greater than 249 km/hr";
                    break;
            }
        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void clubButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void spadeButton_Click(object sender, EventArgs e)
        {
            //set suit value

            //set button colour to goldenrod, (other buttons black)
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to check what suit
            //has been selected and output the colour of the suit
        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
        }

        private void thatButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to give outputs based on 
            //if both colours are the same or different
        }
    }
}
