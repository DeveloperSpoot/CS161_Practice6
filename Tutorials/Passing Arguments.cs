using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_Practice6.Tutorials
{
    public partial class Passing_Arguments : Form
    {
        public Passing_Arguments()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            ShowCard(cardListBox.SelectedItem.ToString());
        }

        private void  ShowCard(string card)
        {
            switch(card)
            {
                case "Ace of Spades":
                    cardPictureBox.Image = Resource1.Ace_Spades;
                    break;

                case "10 of Hearts":
                    cardPictureBox.Image = Resource1._10_Hearts;
                    break;

                case "King of Clubs":
                    cardPictureBox.Image = Resource1.King_Clubs;
                    break;
            }

        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
