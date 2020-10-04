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
    public partial class Patiant_page_4doc : Form
    {
        private Patiant_page_4doc()
        {
            InitializeComponent();
        }
        SqlDataAdapter sqlDataAdapter;
        BindingSource bindingSource;
        DataTable DT;
        static int PID, DID;
        private static Patiant_page_4doc instance = null;
        public static Patiant_page_4doc getInstance(int pID,int dID)
        {
            if (instance == null)
            {
                instance = new Patiant_page_4doc();
                DID = dID;
                PID = pID;
            }
            return instance;
        }
        private void Patiant_page_4doc_Load(object sender, EventArgs e)
        {
            loadData();
            ShowData();
        }
        private void loadData()
        {
            SqlCommand cmd = new SqlCommand("select * from Patiants where doc_id=@DID", Program.sqlConnection);
            cmd.Parameters.AddWithValue("@DID", DID);
            sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            sqlCommandBuilder.DataAdapter = sqlDataAdapter;
        }
        private void ShowData()
        {
            DT = new DataTable();
            sqlDataAdapter.Fill(DT);
            bindingSource = new BindingSource();
            bindingSource.DataSource = DT;

            BV.BindingSource = bindingSource;
            bindingSource.Position = bindingSource.Find("patiant_id", PID);

            Pat_name.DataBindings.Add("text", bindingSource, "patiant_name");
            pat_id.DataBindings.Add("text", bindingSource, "patiant_id");
            pat_state.DataBindings.Add("text", bindingSource, "patiant_state");
            tasks.DataBindings.Add("text", bindingSource, "doc_notes");
        }

        private void update_Click(object sender, EventArgs e)
        {
            sqlDataAdapter.Update(DT);
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
