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
            exitButton = new Button();
            showCardButton = new Button();
            cardListBox = new ListBox();
            cardPanel = new Panel();
            cardPictureBox = new PictureBox();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.RosyBrown;
            exitButton.Location = new Point(183, 301);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // showCardButton
            // 
            showCardButton.Location = new Point(102, 301);
            showCardButton.Name = "showCardButton";
            showCardButton.Size = new Size(75, 23);
            showCardButton.TabIndex = 6;
            showCardButton.Text = "Show Card";
            showCardButton.UseVisualStyleBackColor = true;
            showCardButton.Click += showCardButton_Click;
            // 
            // cardListBox
            // 
            cardListBox.FormattingEnabled = true;
            cardListBox.ItemHeight = 15;
            cardListBox.Items.AddRange(new object[] { "Ace of Spades", "10 of Hearts", "King of Clubs" });
            cardListBox.Location = new Point(120, 188);
            cardListBox.Name = "cardListBox";
            cardListBox.Size = new Size(120, 94);
            cardListBox.TabIndex = 5;
            // 
            // cardPanel
            // 
            cardPanel.BorderStyle = BorderStyle.Fixed3D;
            cardPanel.Controls.Add(cardPictureBox);
            cardPanel.Location = new Point(12, 12);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(337, 170);
            cardPanel.TabIndex = 4;
            // 
            // cardPictureBox
            // 
            cardPictureBox.Location = new Point(117, 9);
            cardPictureBox.Name = "cardPictureBox";
            cardPictureBox.Size = new Size(102, 150);
            cardPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardPictureBox.TabIndex = 0;
            cardPictureBox.TabStop = false;
            cardPictureBox.Visible = false;
            // 
            // Passing_Arguments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 336);
            Controls.Add(exitButton);
            Controls.Add(showCardButton);
            Controls.Add(cardListBox);
            Controls.Add(cardPanel);
            Name = "Passing_Arguments";
            Text = "Passing_Arguments";
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Button showCardButton;
        private ListBox cardListBox;
        private Panel cardPanel;
        private PictureBox cardPictureBox;
    }
}