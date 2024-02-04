namespace CS161_Practice6.Programming_Problems
{
    public partial class Kinetic_Energy : Form
    {
        public Kinetic_Energy()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal objMass = 0m, objVelocity = 0m, objKineticEnergy = 0m;
            if (validateInputs(ref objMass, ref objVelocity))
            {
                objKineticEnergy = calculateKineticEnergy(objMass, objVelocity);
                kineticEnergyLabel .Text = objKineticEnergy.ToString("f");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateInputs(ref decimal mass, ref decimal velocity)
        {
            if (decimal.TryParse(massTextBox.Text, out mass))
            {
                if (decimal.TryParse(velocityTextBox.Text, out velocity))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Input provided for markup percentage is invalid.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Input provided for wholesale cost is invalid.");
                return false;
            }
        }

        private decimal calculateKineticEnergy(decimal mass, decimal velocity)
        {
            return (1.00m / 2.00m) * mass * (velocity * velocity);
        }
    }
}
