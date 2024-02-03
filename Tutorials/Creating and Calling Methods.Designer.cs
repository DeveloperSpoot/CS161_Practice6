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
            exitButton = new Button();
            switchButton = new Button();
            statusLabel = new Label();
            lightPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)lightPictureBox).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(12, 320);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(258, 23);
            exitButton.TabIndex = 0;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // switchButton
            // 
            switchButton.BackColor = SystemColors.ButtonFace;
            switchButton.Location = new Point(12, 282);
            switchButton.Name = "switchButton";
            switchButton.Size = new Size(258, 23);
            switchButton.TabIndex = 1;
            switchButton.Text = "Switch Light";
            switchButton.UseVisualStyleBackColor = false;
            switchButton.Click += switchButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.BackColor = SystemColors.ControlLight;
            statusLabel.BorderStyle = BorderStyle.FixedSingle;
            statusLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(12, 246);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(258, 23);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "OFF";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lightPictureBox
            // 
            lightPictureBox.Image = Resource1.LightOff;
            lightPictureBox.Location = new Point(15, 14);
            lightPictureBox.Name = "lightPictureBox";
            lightPictureBox.Size = new Size(255, 218);
            lightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lightPictureBox.TabIndex = 3;
            lightPictureBox.TabStop = false;
            // 
            // Creating_and_Calling_Methods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 355);
            Controls.Add(lightPictureBox);
            Controls.Add(statusLabel);
            Controls.Add(switchButton);
            Controls.Add(exitButton);
            Name = "Creating_and_Calling_Methods";
            Text = "Creating_and_Calling_Methods";
            ((System.ComponentModel.ISupportInitialize)lightPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Button switchButton;
        private Label statusLabel;
        private PictureBox lightPictureBox;
    }
}