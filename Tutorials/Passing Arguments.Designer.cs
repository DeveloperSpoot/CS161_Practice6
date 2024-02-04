namespace CS161_Practice6.Tutorials
{
    partial class Passing_Arguments
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
            this.showCardButton = new System.Windows.Forms.Button();
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.cardPictureBox = new System.Windows.Forms.PictureBox();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.exitButton.Location = new System.Drawing.Point(209, 381);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 29);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // showCardButton
            // 
            this.showCardButton.Location = new System.Drawing.Point(117, 381);
            this.showCardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(86, 29);
            this.showCardButton.TabIndex = 6;
            this.showCardButton.Text = "Show Card";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.ItemHeight = 19;
            this.cardListBox.Items.AddRange(new object[] {
            "Ace of Spades",
            "10 of Hearts",
            "King of Clubs"});
            this.cardListBox.Location = new System.Drawing.Point(137, 238);
            this.cardListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(137, 118);
            this.cardListBox.TabIndex = 5;
            // 
            // cardPanel
            // 
            this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPanel.Controls.Add(this.cardPictureBox);
            this.cardPanel.Location = new System.Drawing.Point(14, 15);
            this.cardPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(385, 214);
            this.cardPanel.TabIndex = 4;
            // 
            // cardPictureBox
            // 
            this.cardPictureBox.Location = new System.Drawing.Point(134, 11);
            this.cardPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cardPictureBox.Name = "cardPictureBox";
            this.cardPictureBox.Size = new System.Drawing.Size(117, 190);
            this.cardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox.TabIndex = 0;
            this.cardPictureBox.TabStop = false;
            // 
            // Passing_Arguments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 426);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.cardListBox);
            this.Controls.Add(this.cardPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Passing_Arguments";
            this.Text = "Passing_Arguments";
            this.cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private Button showCardButton;
        private ListBox cardListBox;
        private Panel cardPanel;
        private PictureBox cardPictureBox;
    }
}