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
    public partial class frmLogingWindow : Form
    {
        String Username = "e2140029";
        String Password = "200025103779";
        int NoOfLoginAttempts = (0);
        public frmLogingWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String UserEnterdUsername = txtUsename.Text;
            String UserEnterdPassword = txtPassword.Text;

            if (UserEnterdUsername.Equals(Username) && UserEnterdPassword.Equals(Password))
                {
                frmStudentGradeCalculator frm = new frmStudentGradeCalculator();
                frm.Show();
                this.Hide();
                }
            else
            {
                NoOfLoginAttempts = NoOfLoginAttempts + 1;
                if (NoOfLoginAttempts > 4)

                {
                    MessageBox.Show("You've have reached the maximum 5 attempts. \nThe Program will Close", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                MessageBox.Show("UserName or Password is incorrect. \nPlease try again!","Incorrect",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void frmLogingWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
