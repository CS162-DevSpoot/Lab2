namespace CS162_Lab2.Apps
{
    partial class MostFrequent
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
            groupBox1 = new GroupBox();
            inputTextBox = new TextBox();
            groupBox2 = new GroupBox();
            displayLabel = new Label();
            calculateButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inputTextBox);
            groupBox1.Location = new Point(7, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 67);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter Your Text:";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(5, 27);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(429, 23);
            inputTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(displayLabel);
            groupBox2.Location = new Point(7, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 60);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Most Frequent Character:";
            // 
            // displayLabel
            // 
            displayLabel.BackColor = SystemColors.ControlLight;
            displayLabel.Location = new Point(6, 19);
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(429, 34);
            displayLabel.TabIndex = 0;
            displayLabel.Text = "I can see you";
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.ForestGreen;
            calculateButton.ForeColor = SystemColors.ControlLightLight;
            calculateButton.Location = new Point(7, 149);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(441, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButtonClicked;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(7, 178);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(441, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButtonClicked;
            // 
            // MostFrequent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 213);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MostFrequent";
            Text = "MostFrequent";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox inputTextBox;
        private GroupBox groupBox2;
        private Label displayLabel;
        private Button calculateButton;
        private Button exitButton;
    }
}