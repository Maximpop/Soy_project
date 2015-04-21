using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOR2B2U_Timaverkefni_7_8
{
    public partial class SQL_Grunnur : Form
    {
        Gagnagrunnur DB = new Gagnagrunnur();

        public SQL_Grunnur()
        {
            InitializeComponent();
            DB.ConnectionToDatabase();
        }

        
        private void ReadDB()
        {
            LV_Output.Items.Clear();

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
                    string[] lineFromDatabase = lina.Split(':');

                    string ID = lineFromDatabase[0];
                    string nafn = lineFromDatabase[1];
                    string netfang = lineFromDatabase[2];
                    string simanumer = lineFromDatabase[3];

                    // Hefði líka verið hægt að gera þetta svona (arr[9] = lineFromDatabase[0])
                    arr[0] = ID;
                    arr[1] = nafn;
                    arr[2] = netfang;
                    arr[3] = simanumer;

                    // Set inn í ListView hlutinn og bæti svo inn í ListView hólfin
                    itm = new ListViewItem(arr);
                    LV_Output.Items.Add(itm);

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Villa: " + exc);
            }
        }


        private void SQL_Grunnur_Load(object sender, EventArgs e)
        {
            LV_Output.Columns.Add("ID", 167);
            LV_Output.Columns.Add("Nafn", 167);
            LV_Output.Columns.Add("Netfang", 167);
            LV_Output.Columns.Add("Simanumer", 165);

            ReadDB();
        }



        private void Btn_ViewTable_Click(object sender, EventArgs e)
        {
            ReadDB();
        }

        private void Btn_RegisterToTable_Click(object sender, EventArgs e)
        {
            string KT = TB_Skra_Kt.Text;
            string nafn = TB_Skra_Name.Text;
            string netfang = TB_Skra_Email.Text;
            string simi = TB_Skra_Simi.Text;

            try
            {
                DB.InsertIntoTable(KT, nafn, netfang, simi);

                MessageBox.Show("Nafn hefur verið skráð í töflu!");

                TB_Skra_Kt.Clear();
                TB_Skra_Name.Clear();
                TB_Skra_Email.Clear();
                TB_Skra_Simi.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ekki tókst að Skrá í töflu." + exc);
            }
        }

        private void Btn_Breyta_Leita_Click(object sender, EventArgs e)
        {
            string[] output = DB.FindMember(TB_Breyta_Kt.Text).Split(':');

            string name = output[0];
            string email = output[1];
            string cell = output[2];

            TB_Breyta_Name.Text = name;
            TB_Breyta_Email.Text = email;
            TB_Breyta_Simi.Text = cell;
        }

        private void Btn_Breyta_Update_Click(object sender, EventArgs e)
        {
            DB.Update(TB_Breyta_Kt.Text, TB_Breyta_Name.Text, TB_Breyta_Email.Text, TB_Breyta_Simi.Text);
        }

        private void Btn_Find_Name_Click(object sender, EventArgs e)
        {
            string[] findArray = DB.FindSpecificAndReturn(TB__Find_Kennitala.Text);

            TB_Breyta_Kt.Text = findArray[0];
            TB_Breyta_Name.Text = findArray[1];
            TB_Breyta_Email.Text = findArray[2];
            TB_Breyta_Simi.Text = findArray[3];
        }

        private void Btn_Find_Erase_Click(object sender, EventArgs e)
        {
            DB.Erase(TB__Find_Kennitala.Text);
        }

        private void LV_Output_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_Output.SelectedIndices.Count <= 0)
                return;

            int intSelectIndex = LV_Output.SelectedIndices[0];

            if (intSelectIndex >= 0)
            {
                string kennitala = LV_Output.SelectedItems[0].SubItems[0].Text;
                string nafn = LV_Output.SelectedItems[0].SubItems[1].Text;
                string email = LV_Output.SelectedItems[0].SubItems[2].Text;
                string cell = LV_Output.SelectedItems[0].SubItems[3].Text;

                TB_Breyta_Kt.Text = kennitala;
                TB_Breyta_Name.Text = nafn;
                TB_Breyta_Email.Text = email;
                TB_Breyta_Simi.Text = cell;
            }
            

            //char[] split = { ':' };
        }

        
    }
}
