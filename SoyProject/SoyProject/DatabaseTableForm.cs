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
    public partial class DatabaseTableForm : Form
    {
        public DatabaseTableForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Hide();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void DatabaseTableForm_Load(object sender, EventArgs e)
        {
            LV_DBTable.Items.Add("ID", 200);
            LV_DBTable.Items.Add("employeeSSN", 200);
        }
    }
}
