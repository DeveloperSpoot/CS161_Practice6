namespace CS161_Practice6.Tutorials
{
    partial class Creating_and_Calling_Methods
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
            goButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // goButton
            // 
            goButton.Location = new Point(9, 10);
            goButton.Name = "goButton";
            goButton.Size = new Size(262, 34);
            goButton.TabIndex = 0;
            goButton.Text = "GO";
            goButton.UseVisualStyleBackColor = true;
            goButton.Click += goButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(9, 59);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(262, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Creating_and_Calling_Methods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 104);
            Controls.Add(exitButton);
            Controls.Add(goButton);
            Name = "Creating_and_Calling_Methods";
            Text = "Creating_and_Calling_Methods";
            ResumeLayout(false);
        }

        #endregion

        private Button goButton;
        private Button exitButton;
    }
}