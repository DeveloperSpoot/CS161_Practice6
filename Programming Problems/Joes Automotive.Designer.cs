namespace CS161_Practice6.Programming_Problems
{
    partial class Joes_Automotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lubeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transmissionCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tireCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.serviceLaborLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lubeCheckBox);
            this.panel1.Controls.Add(this.oilCheckBox);
            this.panel1.Location = new System.Drawing.Point(6, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 64);
            this.panel1.TabIndex = 0;
            // 
            // lubeCheckBox
            // 
            this.lubeCheckBox.AccessibleDescription = "40";
            this.lubeCheckBox.AutoSize = true;
            this.lubeCheckBox.Location = new System.Drawing.Point(7, 35);
            this.lubeCheckBox.Name = "lubeCheckBox";
            this.lubeCheckBox.Size = new System.Drawing.Size(119, 23);
            this.lubeCheckBox.TabIndex = 1;
            this.lubeCheckBox.Text = "Lube Job ($40)";
            this.lubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilCheckBox
            // 
            this.oilCheckBox.AccessibleDescription = "50";
            this.oilCheckBox.AutoSize = true;
            this.oilCheckBox.Location = new System.Drawing.Point(7, 7);
            this.oilCheckBox.Name = "oilCheckBox";
            this.oilCheckBox.Size = new System.Drawing.Size(157, 23);
            this.oilCheckBox.TabIndex = 0;
            this.oilCheckBox.Text = "Oil Change Job ($50)";
            this.oilCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.transmissionCheckBox);
            this.panel2.Controls.Add(this.radiatorCheckBox);
            this.panel2.Location = new System.Drawing.Point(7, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 64);
            this.panel2.TabIndex = 1;
            // 
            // transmissionCheckBox
            // 
            this.transmissionCheckBox.AccessibleDescription = "120";
            this.transmissionCheckBox.AutoSize = true;
            this.transmissionCheckBox.Location = new System.Drawing.Point(7, 35);
            this.transmissionCheckBox.Name = "transmissionCheckBox";
            this.transmissionCheckBox.Size = new System.Drawing.Size(186, 23);
            this.transmissionCheckBox.TabIndex = 1;
            this.transmissionCheckBox.Text = "Transmission Flush ($120)";
            this.transmissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorCheckBox
            // 
            this.radiatorCheckBox.AccessibleDescription = "100";
            this.radiatorCheckBox.AutoSize = true;
            this.radiatorCheckBox.Location = new System.Drawing.Point(7, 7);
            this.radiatorCheckBox.Name = "radiatorCheckBox";
            this.radiatorCheckBox.Size = new System.Drawing.Size(159, 23);
            this.radiatorCheckBox.TabIndex = 0;
            this.radiatorCheckBox.Text = "Radiator Flush ($100)";
            this.radiatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 128);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.tireCheckBox);
            this.panel3.Controls.Add(this.mufflerCheckBox);
            this.panel3.Controls.Add(this.inspectionCheckBox);
            this.panel3.Location = new System.Drawing.Point(6, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 95);
            this.panel3.TabIndex = 0;
            // 
            // tireCheckBox
            // 
            this.tireCheckBox.AccessibleDescription = "25";
            this.tireCheckBox.AutoSize = true;
            this.tireCheckBox.Location = new System.Drawing.Point(7, 64);
            this.tireCheckBox.Name = "tireCheckBox";
            this.tireCheckBox.Size = new System.Drawing.Size(137, 23);
            this.tireCheckBox.TabIndex = 2;
            this.tireCheckBox.Text = "Tire Roation ($25)";
            this.tireCheckBox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AccessibleDescription = "150";
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Location = new System.Drawing.Point(7, 35);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(166, 23);
            this.mufflerCheckBox.TabIndex = 1;
            this.mufflerCheckBox.Text = "Replace Muffler ($150)";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AccessibleDescription = "35";
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(7, 7);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(127, 23);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($35)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Location = new System.Drawing.Point(248, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 122);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.laborTextBox);
            this.panel4.Controls.Add(this.partsTextBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(6, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 89);
            this.panel4.TabIndex = 0;
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(112, 50);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(81, 26);
            this.laborTextBox.TabIndex = 3;
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(113, 16);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(81, 26);
            this.partsTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Labor (Hours):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel5);
            this.groupBox5.Location = new System.Drawing.Point(12, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(455, 198);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.totalLabel);
            this.panel5.Controls.Add(this.taxLabel);
            this.panel5.Controls.Add(this.partsLabel);
            this.panel5.Controls.Add(this.serviceLaborLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(9, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 165);
            this.panel5.TabIndex = 0;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalLabel.Location = new System.Drawing.Point(207, 128);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(150, 19);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = " ";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.SystemColors.Control;
            this.taxLabel.Location = new System.Drawing.Point(207, 92);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(150, 19);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = " ";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsLabel
            // 
            this.partsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.partsLabel.Location = new System.Drawing.Point(207, 56);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(150, 19);
            this.partsLabel.TabIndex = 9;
            this.partsLabel.Text = " ";
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceLaborLabel
            // 
            this.serviceLaborLabel.BackColor = System.Drawing.SystemColors.Control;
            this.serviceLaborLabel.Location = new System.Drawing.Point(207, 20);
            this.serviceLaborLabel.Name = "serviceLaborLabel";
            this.serviceLaborLabel.Size = new System.Drawing.Size(150, 19);
            this.serviceLaborLabel.TabIndex = 8;
            this.serviceLaborLabel.Text = " ";
            this.serviceLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Fees:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tax (on parts):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parts:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service and Labor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 452);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(219, 30);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(248, 452);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(219, 30);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Brown;
            this.exitButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.exitButton.Location = new System.Drawing.Point(12, 488);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(455, 30);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Joes_Automotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 531);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Joes_Automotive";
            this.Text = "Joes_Automotive";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private CheckBox lubeCheckBox;
        private CheckBox oilCheckBox;
        private GroupBox groupBox2;
        private Panel panel2;
        private CheckBox transmissionCheckBox;
        private CheckBox radiatorCheckBox;
        private GroupBox groupBox3;
        private Panel panel3;
        private CheckBox tireCheckBox;
        private CheckBox mufflerCheckBox;
        private CheckBox inspectionCheckBox;
        private GroupBox groupBox4;
        private Panel panel4;
        private TextBox laborTextBox;
        private TextBox partsTextBox;
        private Label label2;
        private Label label1;
        private GroupBox groupBox5;
        private Panel panel5;
        private Label totalLabel;
        private Label taxLabel;
        private Label partsLabel;
        private Label serviceLaborLabel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}