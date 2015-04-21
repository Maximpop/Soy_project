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
            List<string> employees = new List<string>();

            employees = DB.RetrieveEmployeeNames();

            foreach (string s in employees)
            {
                CB_Employees.Items.Add(s);
            }
        }

        
    }
}
