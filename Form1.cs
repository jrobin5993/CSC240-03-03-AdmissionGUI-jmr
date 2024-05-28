/*
 * Author:          JaLeel Robinson
 * Date:            05/28/2024
 * Description:     CSC240-03-03-AdmissionGUI
 * Resource
 */

using System.Diagnostics.Eventing.Reader;

namespace CSC240_03_03_AdmissionGUI_jmr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UxCheckEligibilityButton_Click(object sender, EventArgs e)
        {
            double gpa;
            double testScore;
            if (double.TryParse(UxGPATextBox.Text, out gpa) && double.TryParse(UxTestScoreTextBox.Text, out testScore))
            {

                if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
                {

                    UxResultLabel.Text = "Accept";

                }
                else
                {

                    UxResultLabel.Text = "Reject";
                }
            }
            else
            {
                MessageBox.Show("Please enter valid GPA and Test Score");
            }

        }
    }

}