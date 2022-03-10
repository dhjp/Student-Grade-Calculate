using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class frmStudentGradeCalculator : Form
    {
        public frmStudentGradeCalculator()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int CAWeightage, FEmark, CAmark, FEWeightage,TotoalMarks,AttandancePercentage;
            string Grade = "INVALID GRADE ";
            //int.TryParse(txtWeightage.Text, out CAWeightage);
            //int.TryParse(txtFEMark.Text, out FEmark);
            //int.TryParse(txtCAMark.Text, out CAmark);

            CAWeightage = Convert.ToInt32(txtWeightage.Text);
            FEmark = Convert.ToInt32(txtFEMark.Text);
            CAmark = Convert.ToInt32(txtCAMark.Text);
            AttandancePercentage = Convert.ToInt32(txtAttandance.Text);

            if (CAWeightage >= 100 || CAWeightage < 0 && FEmark >= 100 || FEmark <=0 && CAmark >=100 || CAmark>=0 && AttandancePercentage >= 100 || AttandancePercentage <=0)
                
            {
                MessageBox.Show("Please Enter Valid Value \nPlease try again!", "Not a Valid",MessageBoxButtons.RetryCancel,MessageBoxIcon.Asterisk);
            }
            else
            {
                FEWeightage = 100 - CAWeightage;

                TotoalMarks = ((FEmark * FEWeightage) + (CAmark * CAWeightage)) / 100;
          
                if (TotoalMarks >= 85)
                {
                    Grade = "A";
                }
                else if (TotoalMarks >= 65)
                {
                    Grade = "B";
                }
                else if (TotoalMarks >= 50)
                {
                    Grade = "C";
                }
                else if (TotoalMarks >= 40)
                {
                    Grade = "D";
                }
                else
                {
                    Grade = "F";
                }
                if (AttandancePercentage < 80 &&  AttandancePercentage >= 60)
                {
                    if (TotoalMarks >= 65)
                    {
                        Grade = "C";
                    }                    
                }
                else if (AttandancePercentage < 60)
                {
                    Grade = "F";
                }
                MessageBox.Show("Grade :- " + Grade);

                // Frist we have to create an object from the window
                frmSummaryWindows frmSummary = new frmSummaryWindows(txtStudentName.Text,txtRegNo.Text ,txtModuleName.Text,txtModuleCode.Text,Grade);
                frmSummary.Show();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtModuleCode.Text="";
            txtStudentName.Text = "";
            txtAttandance.Text = "";
            txtWeightage.Text = "";
            txtRegNo.Text = "";
            txtFEMark.Text = "";
            txtCAMark.Text = "";
            txtModuleName.Text = "";
        }
    }
}
