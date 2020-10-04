using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        SqlDataAdapter LogInDataAdabter;
        DataSet LogInDataSet;
        private void LogIn_Load(object sender, EventArgs e)
        {
            loadData();
            DocID.Select();
        }

        private void loadData()
        {
            LogInDataAdabter = new SqlDataAdapter("select * from Doctors", Program.sqlConnection);
            LogInDataSet = new DataSet();
            LogInDataAdabter.Fill(LogInDataSet, "Doctors");
            LogInDataSet.Tables[0].Constraints.Add("Doc_id", LogInDataSet.Tables[0].Columns[1], true);
        }
        private Boolean CheckLogInInfo(string DocID,string password)
        {
            int id = Program.tryParse(DocID);
            if (id == -1)
                return false;
            DataRow dataRow = LogInDataSet.Tables[0].Rows.Find(id);
            if (dataRow == null)
                return false;
            if (dataRow[3].ToString() == password)
                return true;
            return false;
        }
        

        private void log_in_Click(object sender, EventArgs e)
        {
            if (CheckLogInInfo(DocID.Text,DocPass.Text)==true)
            {

                doc_page doc_Page = new doc_page(int.Parse(DocID.Text));
                doc_Page.Show();
                this.Hide();
            }
            else
            {
                InValid.Visible = true;
            }
        }
         
        private void Ok(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                log_in.PerformClick();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
