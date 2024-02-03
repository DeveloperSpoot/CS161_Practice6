namespace CS161_Practice6.Tutorials
{
    public partial class Creating_and_Calling_Methods : Form
    {
        public Creating_and_Calling_Methods()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the go button method.");
            DisplayMessage();
            MessageBox.Show("Wow shocker... We're back in the go button method...");
        }

        private void DisplayMessage()
        {
            MessageBox.Show("Omg look at that! This message was triggered... Through another method... 😱");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
