namespace CS161_Practice6.Programming_Problems
{
    public partial class Distance_Falling : Form
    {
        public Distance_Falling()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int seconds = 0;

            if (validateInputs(ref seconds))
            {
                decimal distance = calculateDistance(seconds);
                distanceLabel.Text = $"{distance.ToString("f")} meters";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateInputs(ref int seconds)
        {
            if (int.TryParse(timeTextBox.Text, out seconds))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Input provided for time fel invalid.");
                return false;
            }
        }

        private decimal calculateDistance(int seconds)
        {
            return (1.00m / 2.00m) * (9.80m * (decimal)(seconds*seconds));
        }

    }
}
