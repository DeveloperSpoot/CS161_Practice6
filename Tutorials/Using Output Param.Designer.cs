namespace CS161_Practice6.Tutorials
{
    partial class Using_Output_Param
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(158, 211);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 57);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Location = new System.Drawing.Point(65, 211);
            this.getCountriesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(86, 57);
            this.getCountriesButton.TabIndex = 6;
            this.getCountriesButton.Text = "Get Countries";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 19;
            this.countriesListBox.Location = new System.Drawing.Point(39, 52);
            this.countriesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(231, 137);
            this.countriesListBox.TabIndex = 5;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(28, 9);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(251, 21);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "The Countries of North America";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // Using_Output_Param
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 283);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Name = "Using_Output_Param";
            this.Text = "Using_Output_Param";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitButton;
        private Button getCountriesButton;
        private ListBox countriesListBox;
        private Label outputDescriptionLabel;
        private OpenFileDialog openFile;
    }
}