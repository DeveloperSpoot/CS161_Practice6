namespace CS161_Practice6.Tutorials
{
    partial class Value_Returning
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
            this.convertButton = new System.Windows.Forms.Button();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptorLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(170, 163);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 29);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(78, 163);
            this.convertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(86, 29);
            this.convertButton.TabIndex = 12;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // cupsTextBox
            // 
            this.cupsTextBox.Location = new System.Drawing.Point(160, 67);
            this.cupsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(114, 26);
            this.cupsTextBox.TabIndex = 11;
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Location = new System.Drawing.Point(160, 108);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(114, 29);
            this.ouncesLabel.TabIndex = 10;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptorLabel
            // 
            this.outputDescriptorLabel.AutoSize = true;
            this.outputDescriptorLabel.Location = new System.Drawing.Point(60, 115);
            this.outputDescriptorLabel.Name = "outputDescriptorLabel";
            this.outputDescriptorLabel.Size = new System.Drawing.Size(91, 19);
            this.outputDescriptorLabel.TabIndex = 9;
            this.outputDescriptorLabel.Text = "Fluid Ounces:";
            // 
            // cupsPromptLabel
            // 
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Location = new System.Drawing.Point(108, 72);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(43, 19);
            this.cupsPromptLabel.TabIndex = 8;
            this.cupsPromptLabel.Text = "Cups:";
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bannerLabel.Location = new System.Drawing.Point(25, 21);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(248, 21);
            this.bannerLabel.TabIndex = 7;
            this.bannerLabel.Text = "Cups to Fluid Ounces Converter";
            // 
            // Value_Returning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 226);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.outputDescriptorLabel);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Name = "Value_Returning";
            this.Text = "Value_Returning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitButton;
        private Button convertButton;
        private TextBox cupsTextBox;
        private Label ouncesLabel;
        private Label outputDescriptorLabel;
        private Label cupsPromptLabel;
        private Label bannerLabel;
    }
}