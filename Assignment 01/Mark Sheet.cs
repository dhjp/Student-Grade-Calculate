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
    public partial class frmSummaryWindows : Form
    {
        public frmSummaryWindows(String StudentName, String Indext,String ModuleName, String ModuleCode, String Grade)
        {
            InitializeComponent();
            lblStudentName.Text = StudentName;
            lblIndextNumber.Text = Indext;
            lblModuleName.Text = ModuleName;
            lblModuleCode.Text = ModuleCode;
            lblGrade.Text = Grade;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSummaryWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
