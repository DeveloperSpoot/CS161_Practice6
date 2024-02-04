namespace CS161_Practice6.Programming_Problems
{
    public partial class Joes_Automotive : Form
    {
        public Joes_Automotive()
        {
            InitializeComponent();
        }

        const decimal PAYRATE = 75m; // $75/hour;
        const decimal TAX = .05m; // 5% tax on parts;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal parts = 0m, labor = 0m, serviceFees = 0m, partsTax = 0m;

            validateInputs(ref parts, ref labor);

            serviceFees = getServiceFees();
            labor = getLaborFees(labor);
            partsTax = getPartsTax(parts);

            decimal serviceNLabor = serviceFees + labor;
            decimal total = serviceNLabor + parts + partsTax;

            serviceLaborLabel.Text = serviceNLabor.ToString("c");
            partsLabel.Text = parts.ToString("c");
            taxLabel.Text = partsTax.ToString("c");
            totalLabel.Text = total.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            serviceLaborLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
            oilCheckBox.Checked = false;
            lubeCheckBox.Checked = false;
            radiatorCheckBox.Checked = false;
            transmissionCheckBox.Checked = false;
            inspectionCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireCheckBox.Checked = false;
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private decimal getLaborFees(decimal laborHours)
        {
            return laborHours * PAYRATE;
        }

        private decimal getPartsTax(decimal parts)
        {
            return parts * TAX;
        }

        private decimal getServiceFees()
        {
            decimal serviceFees = 0m;
            CheckBox[] services = {oilCheckBox, lubeCheckBox, radiatorCheckBox, transmissionCheckBox, inspectionCheckBox, mufflerCheckBox, tireCheckBox};
            foreach (CheckBox service in services)
            {
                if (service.Checked)
                {
                    serviceFees = serviceFees + decimal.Parse(service.AccessibleDescription);
                }
            }

            return serviceFees;
        }

        private bool validateInputs(ref decimal parts, ref decimal labor)
        {
            if (decimal.TryParse(partsTextBox.Text, out parts))
            {
                if (decimal.TryParse(laborTextBox.Text, out labor))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Input provided for labor is invalid.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Input provided for parts is invalid.");
                return false;
            }
        }

    }
}
