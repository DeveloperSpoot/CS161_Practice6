using CS161_Practice6.Tutorials;

namespace CS161_Practice6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void creatingCallingMethodsButton_Click(object sender, EventArgs e)
        {
            Creating_and_Calling_Methods form = new Creating_and_Calling_Methods();
            form.Show();
        }

        private void passingArgumentMethod_Click(object sender, EventArgs e)
        {
            Passing_Arguments form = new Passing_Arguments();
            form.Show();
        }

        private void outputPraramButton_Click(object sender, EventArgs e)
        {
            Using_Output_Param form = new Using_Output_Param();
            form.Show();
        }

        private void valueReturningButton_Click(object sender, EventArgs e)
        {
            Value_Returning form = new Value_Returning();
            form.Show();
        }

        private void modularizingInputValidationButton_Click(object sender, EventArgs e)
        {
            Modularizing_Input_Validation form = new Modularizing_Input_Validation();
            form.Show();
        }
        private void stepIntoCmdButton_Click(object sender, EventArgs e)
        {
            Step_Into_Cmd form = new Step_Into_Cmd();
            form.Show();
        }

        private void stepOverCmdButton_Click(object sender, EventArgs e)
        {

        }

        private void stepOutCmdButton_Click(object sender, EventArgs e)
        {

        }

        private void retailPriceCalcButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kineticEnergyButton_Click(object sender, EventArgs e)
        {

        }

        private void joesAutoButton_Click(object sender, EventArgs e)
        {

        }

    }
}
