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
        DatabaseTableForm DBTable = new DatabaseTableForm();

        public SoyForm()
        {
            InitializeComponent();

            DB.ConnectionToDatabase();
        }

        private void SoyForm_Load(object sender, EventArgs e)
        {
            #region employee fill
            List<string> employeeInfo = new List<string>();

            employeeInfo = DB.RetrieveEmployeeSSN();

            foreach (string s in employeeInfo)
            {
                CB_Employees.Items.Add(s);
            }
            #endregion
        }

        string name = null;
        string SSN = null;

        private void CB_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSN = CB_Employees.Text.ToString();

            name = DB.GetNameFromSSN(SSN);

            Lbl_Name.Text = name;
        }

        private void Btn_SendData_Click_1(object sender, EventArgs e)
        {
            try
            {
                int bottles = int.Parse(TxtBox_Quantity.Text);

                DB.LogWork(CB_Employees.Text, bottles);

                MessageBox.Show("Vinnuferill hefur verið skráður í kerfið.", "Vinnuferill skráður", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Villa! Veldu kennitölu og fjölda flaskna!", "Ónæg skilyrði", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ViewDB_Click(object sender, EventArgs e)
        {
            DBTable.Show();
        }

        public void PlayAlarm()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = "ALARM.wav";
            player.Play();
        }
        
    }
}
