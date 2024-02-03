namespace CS161_Practice6.Tutorials
{
    public partial class Creating_and_Calling_Methods : Form
    {
        public Creating_and_Calling_Methods()
        {
            InitializeComponent();
        }

        bool lightOn = false;

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (!lightOn)
            {
                lightOn = !lightOn;
                setlightOn();
                return;
            }

            lightOn = !lightOn;
            setLightOff();

        }

        private void setlightOn()
        {
            lightOn = true;
            lightPictureBox.Image = CS161_Practice6.Resource1.LightOn;
            statusLabel.Text = "ON";
        }

        private void setLightOff()
        {
            lightOn = false;
            lightPictureBox.Image = CS161_Practice6.Resource1.LightOff;
            statusLabel.Text = "OFF";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
