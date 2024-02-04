namespace CS161_Practice6.Tutorials
{
    public partial class Modularizing_Input_Validation : Form
    {
        public Modularizing_Input_Validation()
        {
            InitializeComponent();
        }

        private const decimal CONTRIBUTE_RATE = 0.05m;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if(validateInput(ref grossPay, ref bonus))
            {
                contributions = (grossPay + bonus) * CONTRIBUTE_RATE;

                contributionLabel.Text = contributions.ToString("C");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateInput(ref decimal pay, ref decimal bonus)
        {
            bool valid = false;
            
            if(decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if(decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    valid = true;

                }
                else
                {
                    MessageBox.Show("Invalid input provided for bonus.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input provided for gross pay.");
            }

            return valid;
        }
        
    }
}
