namespace CS161_Practice6.Tutorials
{
    public partial class Value_Returning : Form
    {
        public Value_Returning()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups, ounces;

            try
            {
               
                cups = double.Parse(cupsTextBox.Text);
                ounces = cupsToOunces(cups);

                ouncesLabel.Text = ounces.ToString();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double cupsToOunces(double cups)
        {
            return cups * 8.0;
        }

    }
}
