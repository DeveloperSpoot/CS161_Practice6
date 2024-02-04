namespace CS161_Practice6.Programming_Problems
{
    partial class Distance_Falling
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Brown;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(12, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(345, 33);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.distanceLabel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 67);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distance Fallen (Meters)";
            // 
            // distanceLabel
            // 
            this.distanceLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.distanceLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distanceLabel.Location = new System.Drawing.Point(9, 25);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(326, 31);
            this.distanceLabel.TabIndex = 0;
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(229, 18);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 55);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Distance";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Falling (Seconds)";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(6, 26);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(188, 22);
            this.timeTextBox.TabIndex = 0;
            // 
            // Distance_Falling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 204);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Distance_Falling";
            this.Text = "Distance_Falling";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private GroupBox groupBox3;
        private Label distanceLabel;
        private Button calculateButton;
        private GroupBox groupBox1;
        private TextBox timeTextBox;
    }
}