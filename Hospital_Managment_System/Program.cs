using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MakeConnection();
            Application.Run(new LogIn());
        }
        public static SqlConnection sqlConnection;
        public static SqlDataAdapter SqlDataAdapter;
        public static DataSet DocData;
        public static DataSet NurData;
        static void MakeConnection()
        {
            sqlConnection = new SqlConnection("Data Source = DESKTOP-PVBF099\\SQLEXPRESS; Initial Catalog = Hospital; Integrated Security = True");
            SqlDataAdapter = new SqlDataAdapter("select * from Doctors", sqlConnection);
            DocData = new DataSet();
            SqlDataAdapter.Fill(DocData);
            DocData.Tables[0].Constraints.Add("doc_id", DocData.Tables[0].Columns[1], true);
            SqlDataAdapter = new SqlDataAdapter("select * from Nurses", sqlConnection);
            NurData = new DataSet();
            SqlDataAdapter.Fill(NurData);
            NurData.Tables[0].Constraints.Add("nur_id", NurData.Tables[0].Columns[1], true);
        }
        public static int tryParse(string number)
        {
            int ret;
            try
            {
                ret = int.Parse(number);
            }
            catch (Exception ex)
            {
                return -1;
            }
            return ret;
        }
        public static Image ConvertPhotoToRead(byte[] data)
        {
            byte[] photo = (byte[])data;
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        public static Boolean checkTime(string time)
        {
            if (time.Length != 8)
                return false;
            if (time[2] != ':' || time[5] != ':')
                return false;
            if (GetNum(time[0], time[1]) >= 24)
                return false;
            if (GetNum(time[3], time[4]) >= 60)
                return false;
            if (GetNum(time[6], time[7]) >= 100)
                return false;
            return true;
        }
        public static int GetNum(char a,char b)
        {
            int ret = 0;
            ret = (a - '0') * 10;
            ret += (b - '0');
            return ret;
        }
    }
}
