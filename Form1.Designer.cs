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
            SuspendLayout();
            // 
            // UxTestScoreTextBox
            // 
            UxTestScoreTextBox.Location = new Point(87, 187);
            UxTestScoreTextBox.Name = "UxTestScoreTextBox";
            UxTestScoreTextBox.Size = new Size(150, 31);
            UxTestScoreTextBox.TabIndex = 0;
            // 
            // UxGPATextBox
            // 
            UxGPATextBox.Location = new Point(87, 347);
            UxGPATextBox.Name = "UxGPATextBox";
            UxGPATextBox.Size = new Size(150, 31);
            UxGPATextBox.TabIndex = 1;
            // 
            // UxCheckEligibilityButton
            // 
            UxCheckEligibilityButton.Location = new Point(282, 254);
            UxCheckEligibilityButton.Name = "UxCheckEligibilityButton";
            UxCheckEligibilityButton.Size = new Size(106, 61);
            UxCheckEligibilityButton.TabIndex = 2;
            UxCheckEligibilityButton.Text = "Check Eligibility";
            UxCheckEligibilityButton.UseVisualStyleBackColor = true;
            // 
            // UxResultLabel
            // 
            UxResultLabel.AutoSize = true;
            UxResultLabel.Location = new Point(523, 139);
            UxResultLabel.Name = "UxResultLabel";
            UxResultLabel.Size = new Size(63, 25);
            UxResultLabel.TabIndex = 3;
            UxResultLabel.Text = "Result:";
            // 
            // UxTestScoreLabel
            // 
            UxTestScoreLabel.AutoSize = true;
            UxTestScoreLabel.Location = new Point(87, 139);
            UxTestScoreLabel.Name = "UxTestScoreLabel";
            UxTestScoreLabel.Size = new Size(95, 25);
            UxTestScoreLabel.TabIndex = 4;
            UxTestScoreLabel.Text = "Test Score:";
            // 
            // UxGPALabel
            // 
            UxGPALabel.AutoSize = true;
            UxGPALabel.Location = new Point(92, 304);
            UxGPALabel.Name = "UxGPALabel";
            UxGPALabel.Size = new Size(49, 25);
            UxGPALabel.TabIndex = 5;
            UxGPALabel.Text = "GPA:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
