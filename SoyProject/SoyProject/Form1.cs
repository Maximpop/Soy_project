using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoyProject
{
    public partial class SoyForm : Form
    {
        Gagnagrunnur DB = new Gagnagrunnur();

        public SoyForm()
        {
            InitializeComponent();

            DB.ConnectionToDatabase();
        }

        private void SoyForm_Load(object sender, EventArgs e)
        {
            #region employee fill
            //List<string> employees = new List<string>();
            List<string> employeeInfo = new List<string>();

            employeeInfo = DB.RetrieveEmployeeSSN();
            
            //info = DB.RetrieveEmployeeNames();

            foreach (string s in employeeInfo)
            {
                CB_Employees.Items.Add(s);
            }
            #endregion
        }

        string name = null;

        private void CB_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SSN = CB_Employees.SelectedItem.ToString();

            name = DB.GetNameFromSSN(SSN);

            Lbl_Name.Text = name;
        }
        
    }
}
