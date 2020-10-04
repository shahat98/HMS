using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class Doc_patiants : Form
    {
        private Doc_patiants()
        {
            InitializeComponent();
        }
        SqlCommand sqlCommand;
        SqlDataAdapter PatData;
        SqlCommandBuilder commandBuilder;
        DataTable DT;
        DataSet DS;
        private static Doc_patiants instance = null;
        static int DID;
        public static Doc_patiants GetInstance(int DocID)
        {
            if (instance == null)
            {
                instance = new Doc_patiants();
                DID = DocID;
            }
            return instance;
        }
        private void Doc_patiants_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            sqlCommand = new SqlCommand("select * from Patiants where doc_id = @DID", Program.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@DID", DID);
            PatData = new SqlDataAdapter(sqlCommand);
            commandBuilder = new SqlCommandBuilder(PatData);
            DS = new DataSet();
            DT = new DataTable();
            PatData.Fill(DS);
            DT = DS.Tables[0];
            Patiants.DataSource = DS.Tables[0];
            Patiants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BeforeClose(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            PatData.Update(DT);
        }

        private void selectPat(object sender, EventArgs e)
        {
            if (!CheckSelection())
                return;
            int PatID = int.Parse(Patiants.SelectedRows[0].Cells[1].Value.ToString());
            pID.Text = PatID.ToString();
        }
        private Boolean CheckSelection()
        {
            if (Patiants.SelectedRows.Count == 1)
                return true;
            return false;
        }
        private void del_pat_Click(object sender, EventArgs e)
        {
            if (CheckSelection())
                Patiants.Rows.Remove(Patiants.SelectedRows[0]);
        }

        private void view_pat_Click(object sender, EventArgs e)
        {
            Patiant_page_4doc Pat = Patiant_page_4doc.getInstance(int.Parse(pID.Text),DID);
            Pat.Show();
        }
    }
}
