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
                    cardPictureBox.Image = (Bitmap)Resource1.ResourceManager.GetObject("Ace_Spades.png");
                    break;

                case "10 of Hearts":
                    cardPictureBox.Image = (Bitmap)Resource1.ResourceManager.GetObject("10_Hearts");
                    break;

                case "King of Clubs":
                    cardPictureBox.Image = (Bitmap)Resource1.ResourceManager.GetObject("King_Clubs");
                    break;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
