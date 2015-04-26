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
        Gagnagrunnur DB = new Gagnagrunnur();
        FilterDatabaseView filter = new FilterDatabaseView();

        public DatabaseTableForm()
        {
            InitializeComponent();

            DB.ConnectionToDatabase();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            else if (keyData == (Keys.Control | Keys.F))
                MessageBox.Show("Ctrl + F");
            else if (keyData == Keys.F2)
                filter.Show(); this.Close();

            bool res = base.ProcessCmdKey(ref msg, keyData);

            return res;
        }


        private void ReadDB()
        {
            LV_DBTable.Items.Clear();

            List<string> linur = new List<string>();
            string[] arr = new string[4];
            ListViewItem itm;
            
            try
            {
                linur = DB.ReadFromDatabase();

                foreach (string lina in linur)
                {
                    // Splitta línum frá gagnagrunninum
                    string[] lineFromDatabase = lina.Split(';');

                    // Hefði líka verið hægt að gera þetta svona (arr[9] = lineFromDatabase[0])
                    arr[0] = lineFromDatabase[0];// ID
                    arr[1] = lineFromDatabase[1];// Name
                    arr[2] = lineFromDatabase[2];// Bottles
                    arr[3] = lineFromDatabase[3];// Date
                    
                    // Set inn í ListView hlutinn og bæti svo inn í ListView hólfin
                    itm = new ListViewItem(arr);
                    LV_DBTable.Items.Add(itm);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Villa: " + exc);
            }
        }

        public void FilterDB(string kt = null, string date = null)
        {
            LV_DBTable.Items.Clear();
            
            List<string> linur = new List<string>();
            string[] arr = new string[4];
            ListViewItem itm;
            
            try
            {
                linur = DB.FilterDatabase(kt, date);

                foreach (string lina in linur)
                {
                    // Splitta línum frá gagnagrunninum
                    string[] lineFromDatabase = lina.Split(';');

                    // Hefði líka verið hægt að gera þetta svona (arr[0] = lineFromDatabase[0])
                    arr[0] = lineFromDatabase[0];// ID
                    arr[1] = lineFromDatabase[1];// Name
                    arr[2] = lineFromDatabase[2];// Bottles
                    arr[3] = lineFromDatabase[3];// Date
                    
                    // Set inn í ListView hlutinn og bæti svo inn í ListView hólfin
                    itm = new ListViewItem(arr);
                    LV_DBTable.Items.Add(itm);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Villa: " + exc);
            }
        }
        
        private void DatabaseTableForm_Load(object sender, EventArgs e)
        {
            LV_DBTable.Columns.Add("#", 90);
            LV_DBTable.Columns.Add("Nafn", 400);
            LV_DBTable.Columns.Add("Flöskur", 110);
            LV_DBTable.Columns.Add("Dagsetning", 270);

            ReadDB();
        }

    }
}
