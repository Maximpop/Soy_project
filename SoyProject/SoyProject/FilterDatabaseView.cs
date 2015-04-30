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
    public partial class FilterDatabaseView : Form
    {
        Gagnagrunnur DB = new Gagnagrunnur();

        public FilterDatabaseView()
        {
            InitializeComponent();

            DB.ConnectionToDatabase();
        }

        private void FilterDatabaseView_Load(object sender, EventArgs e)
        {
            List<string> employeeInfo = new List<string>();

            employeeInfo = DB.RetrieveEmployeeSSN();

            foreach (string s in employeeInfo)
            {
                CB_Employees.Items.Add(s);
            }
        }

        string SSN = null;
        string name = null;

        private void CB_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSN = CB_Employees.Text.ToString();

            name = DB.GetNameFromSSN(SSN);

            Lbl_Name.Text = name;
        }

        private void Btn_FilterData_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CB_Employees.Text))
            {
                DatabaseTableForm dbtf = new DatabaseTableForm();
                
                string sqlDate = DTP_Date.Value.ToString("yyyy/MM/dd").Replace('.', '-');
                
                dbtf.Show();
                this.Hide();
                
                if (ChBox_UseDate.Checked)
                    dbtf.FilterDB(SSN, sqlDate);
                else
                    dbtf.FilterDB(SSN);
            }
            else
            {
                MessageBox.Show("Veldu starfsmann", "Veldu kennitölu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            /*
            DateTime date;
            date = DTP_Date.Value;
            */

            //MessageBox.Show(sqlDate);
            //MessageBox.Show(date.ToString("yyyy-MM-dd"));
        }

        private void ChBox_UseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBox_UseDate.Checked)
                DTP_Date.Enabled = true;
            else
                DTP_Date.Enabled = false;
        }
    }
}