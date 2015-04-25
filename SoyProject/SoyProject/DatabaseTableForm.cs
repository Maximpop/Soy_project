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

        public DatabaseTableForm()
        {
            InitializeComponent();

            DB.ConnectionToDatabase();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Hide();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }


        private void ReadDB()
        {
            LV_DBTable.Items.Clear();

            // Listinn sem lesinn er úr gagnagrunninum
            List<string> linur = new List<string>();

            // Fylki notað til að bæta við ListView
            string[] arr = new string[4];

            // Heldur utan um hlutina sem eru bætt við í hverja línu á ListView
            ListViewItem itm;

            try
            {
                linur = DB.ReadFromDatabase();

                foreach (string lina in linur)
                {
                    // Splitta línum frá gagnagrunninum
                    string[] lineFromDatabase = lina.Split(';');

                    string ID = lineFromDatabase[0];
                    string name = lineFromDatabase[1];
                    string bottles = lineFromDatabase[2];
                    string date = lineFromDatabase[3];

                    // Hefði líka verið hægt að gera þetta svona (arr[9] = lineFromDatabase[0])
                    arr[0] = ID;
                    arr[1] = name;
                    arr[2] = bottles;
                    arr[3] = date;

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
