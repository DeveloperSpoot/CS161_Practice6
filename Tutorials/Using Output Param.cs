namespace CS161_Practice6.Tutorials
{
    public partial class Using_Output_Param : Form
    {
        public Using_Output_Param()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string filename;

            GetFileName(out filename);
            GetCountries(filename);
        }

        string selectedFile;
        private void GetFileName(out string selectedFile)
        {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = openFile.FileName;
                }else
                {
                    selectedFile = "";
                }
        }

        private void GetCountries(string filename)
        {
            try
            {

                StreamReader inputFile;

                inputFile = File.OpenText(filename);

                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    countriesListBox.Items.Add(inputFile.ReadLine());
                }

                inputFile.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
