namespace CS162_Lab2.Apps
{
    partial class PigLatin
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
            translateButton = new Button();
            groupBox2 = new GroupBox();
            displayLabel = new Label();
            groupBox1 = new GroupBox();
            inputTextBox = new TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(12, 180);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(441, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButtonClicked;
            // 
            // translateButton
            // 
            translateButton.BackColor = Color.ForestGreen;
            translateButton.ForeColor = SystemColors.ControlLightLight;
            translateButton.Location = new Point(12, 151);
            translateButton.Name = "translateButton";
            translateButton.Size = new Size(441, 23);
            translateButton.TabIndex = 6;
            translateButton.Text = "Translate";
            translateButton.UseVisualStyleBackColor = false;
            translateButton.Click += translateButtonClicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(displayLabel);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(441, 60);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pig Latin";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(inputTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 67);
            groupBox1.TabIndex = 4;
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
            // PigLatin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 215);
            Controls.Add(exitButton);
            Controls.Add(translateButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PigLatin";
            Text = "PigLatin";
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Button translateButton;
        private GroupBox groupBox2;
        private Label displayLabel;
        private GroupBox groupBox1;
        private TextBox inputTextBox;
    }
}