namespace CS161_Practice6.Programming_Problems
{
    public partial class Retail_Price_Calculator : Form
    {
        public Retail_Price_Calculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal wholeSaleCost = 0m, markupPercent = 0m, retailPrice = 0m;
            if(validateInputs(ref wholeSaleCost, ref markupPercent))
            {
                retailPrice = calculateRetailPrice(wholeSaleCost, markupPercent);
                retailPriceLabel.Text = retailPrice.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateInputs(ref decimal wholesaleCost, ref decimal markupPrecent)
        {
            if(decimal.TryParse(wholesaleTextBox.Text, out wholesaleCost))
            {
                if(decimal.TryParse(markupTextBox.Text, out markupPrecent))
                {
                    return true;
                }else
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
       
        private decimal calculateRetailPrice(decimal wholeSale, decimal markup)
        {
            return wholeSale + (wholeSale * (markup/100));
        }

    }
}
