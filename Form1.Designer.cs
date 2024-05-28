namespace CSC240_03_03_AdmissionGUI_jmr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UxTestScoreTextBox = new TextBox();
            UxGPATextBox = new TextBox();
            UxCheckEligibilityButton = new Button();
            UxResultLabel = new Label();
            UxTestScoreLabel = new Label();
            UxGPALabel = new Label();
            UxUniversityEligibilityLabel = new Label();
            SuspendLayout();
            // 
            // UxTestScoreTextBox
            // 
            UxTestScoreTextBox.Location = new Point(43, 195);
            UxTestScoreTextBox.Name = "UxTestScoreTextBox";
            UxTestScoreTextBox.Size = new Size(150, 31);
            UxTestScoreTextBox.TabIndex = 0;
            // 
            // UxGPATextBox
            // 
            UxGPATextBox.Location = new Point(43, 309);
            UxGPATextBox.Name = "UxGPATextBox";
            UxGPATextBox.Size = new Size(150, 31);
            UxGPATextBox.TabIndex = 1;
            // 
            // UxCheckEligibilityButton
            // 
            UxCheckEligibilityButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxCheckEligibilityButton.Location = new Point(296, 218);
            UxCheckEligibilityButton.Name = "UxCheckEligibilityButton";
            UxCheckEligibilityButton.Size = new Size(106, 61);
            UxCheckEligibilityButton.TabIndex = 2;
            UxCheckEligibilityButton.Text = "Check Eligibility";
            UxCheckEligibilityButton.UseVisualStyleBackColor = true;
            UxCheckEligibilityButton.Click += UxCheckEligibilityButton_Click;
            // 
            // UxResultLabel
            // 
            UxResultLabel.AutoSize = true;
            UxResultLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxResultLabel.Location = new Point(493, 162);
            UxResultLabel.Name = "UxResultLabel";
            UxResultLabel.Size = new Size(93, 29);
            UxResultLabel.TabIndex = 3;
            UxResultLabel.Text = "Result:";
            // 
            // UxTestScoreLabel
            // 
            UxTestScoreLabel.AutoSize = true;
            UxTestScoreLabel.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxTestScoreLabel.Location = new Point(54, 150);
            UxTestScoreLabel.Name = "UxTestScoreLabel";
            UxTestScoreLabel.Size = new Size(98, 24);
            UxTestScoreLabel.TabIndex = 4;
            UxTestScoreLabel.Text = "Test Score:";
            // 
            // UxGPALabel
            // 
            UxGPALabel.AutoSize = true;
            UxGPALabel.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxGPALabel.Location = new Point(54, 255);
            UxGPALabel.Name = "UxGPALabel";
            UxGPALabel.Size = new Size(50, 24);
            UxGPALabel.TabIndex = 5;
            UxGPALabel.Text = "GPA:";
            // 
            // UxUniversityEligibilityLabel
            // 
            UxUniversityEligibilityLabel.AutoSize = true;
            UxUniversityEligibilityLabel.Font = new Font("Palatino Linotype", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxUniversityEligibilityLabel.Location = new Point(209, 40);
            UxUniversityEligibilityLabel.Name = "UxUniversityEligibilityLabel";
            UxUniversityEligibilityLabel.Size = new Size(326, 44);
            UxUniversityEligibilityLabel.TabIndex = 6;
            UxUniversityEligibilityLabel.Text = "University Eligibility";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UxUniversityEligibilityLabel);
            Controls.Add(UxGPALabel);
            Controls.Add(UxTestScoreLabel);
            Controls.Add(UxResultLabel);
            Controls.Add(UxCheckEligibilityButton);
            Controls.Add(UxGPATextBox);
            Controls.Add(UxTestScoreTextBox);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "College Admissions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UxTestScoreTextBox;
        private TextBox UxGPATextBox;
        private Button UxCheckEligibilityButton;
        private Label UxResultLabel;
        private Label UxTestScoreLabel;
        private Label UxGPALabel;
        private Label UxUniversityEligibilityLabel;
    }
}
