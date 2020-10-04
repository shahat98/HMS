using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Managment_System
{
    public partial class doc_page : Form
    {
        public doc_page(int Doc_ID)
        {
            InitializeComponent();
            DocID = Doc_ID;
        }
        SqlCommand sqlCommand;
        DataRow DocInfo;
        int DocID;
        Doctor doctor;
        Boolean createPage = false;
        private void doc_page_Load(object sender, EventArgs e)
        {
            doctor = new Doctor(DocID);
            ShowData();
        }

        private void ShowData()
        {
            doc_name.Text = doctor.Name;
            doc_phone.Text = doctor.Phone.ToString();
            doc_spec.Text = doctor.Spec;
            doc_pic.Image = doctor.Photo;
            doc_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            editPassword.Text = doctor.Password;
            time_from.Text = doctor.Time_from;
            time_to.Text = doctor.Time_to;
        }
        private void edit_docINFO_Click(object sender, EventArgs e)
        {
            editInfo(true);
        }

        private void editInfo(Boolean flag)
        {
            doc_name.ReadOnly = !flag;
            doc_phone.ReadOnly = !flag;
            doc_spec.ReadOnly = !flag;
            time_from.ReadOnly = !flag;
            time_to.ReadOnly = !flag;
            Browes.Visible = flag;
            editPassword.Visible = flag;
            passLable.Visible = flag;
            updateInfo.Visible = flag;
        }
        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void updateInfo_Click(object sender, EventArgs e)
        {
            int flag = doctor.UpdateInfo(doc_name.Text, doc_spec.Text, editPassword.Text, doc_phone.Text, doc_pic.Image, time_from.Text, time_to.Text);
            if (flag == -1)
            {
                InValidNumber.Visible = true;
                InValidTime.Visible = false;
                return;
            }
            else if (flag == -2)
            { 
                InValidTime.Visible = true;
                InValidNumber.Visible = false;
                return;
            }
            else if (flag == -3)
            {
                InValidNumber.Visible = true; InValidTime.Visible = true;
                return;
            }
            InValidTime.Visible = false;
            InValidNumber.Visible = false;
            MessageBox.Show("Done!");
            editInfo(false);
        }

        private void Browes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeg|*.jpg|png|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                doc_pic.Image = Image.FromFile(openFileDialog.FileName);
                doc_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void doc_patiants_Click(object sender, EventArgs e)
        {

                Doc_patiants Doc_pats = Doc_patiants.GetInstance(DocID);
                Doc_pats.Show();
        }
    }
    public class Doctor 
    {
        private int DocID;
        public string Name;
        public string Spec;
        public int Phone;
        public string Time_from;
        public string Time_to;
        public string Password;
        public Image Photo;
        SqlCommand sqlCommand;
        public Doctor(int ID)
        {
            DocID = ID;
            LoadDocData();
        }
        private void LoadDocData()
        {
            DataRow DocInfo = Program.DocData.Tables[0].Rows.Find(DocID);
            Name = DocInfo[0].ToString();
            Spec = DocInfo[2].ToString();
            Password = DocInfo[3].ToString();
            Phone = int.Parse(DocInfo[4].ToString());
            if (DocInfo[5] != System.DBNull.Value)
                Photo = Program.ConvertPhotoToRead((byte[])DocInfo[5]);
            Time_from= DocInfo[6].ToString();
            Time_to = DocInfo[7].ToString();
            
        }
        public int UpdateInfo(string name,string spec,string password,string phone,Image photo,string time_from,string time_to)
        {
            Name = name;
            Spec = spec;
            Password = password;
            int flag = 0;
            if (Program.tryParse(phone) == -1)
                flag -= 1;
            if (!Program.checkTime(time_from) || !Program.checkTime(time_to))
                flag -= 2;
            if (flag != 0)
                return flag;
            Phone = int.Parse(phone);
            Time_from = time_from;
            Time_to = time_to;
            Photo = photo;
            UpdateDB();
            return 1;
        }
        private void UpdateDB()
        {
            sqlCommand = new SqlCommand("update Doctors set doc_Name=@name , doc_spec=@spec, doc_pass=@pass, doc_phone=@phone, wt_from=@from, wt_to=@to where doc_id=@id", Program.sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", Name);
            sqlCommand.Parameters.AddWithValue("@spec", Spec);
            sqlCommand.Parameters.AddWithValue("@pass", Password);
            sqlCommand.Parameters.AddWithValue("@phone",Phone);
            sqlCommand.Parameters.AddWithValue("@from", Time_from);
            sqlCommand.Parameters.AddWithValue("@to", Time_to);
            sqlCommand.Parameters.AddWithValue("@id", DocID);
            Program.sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            if (Photo != null)
            {
                MemoryStream ms = new MemoryStream();
                Photo.Save(ms, ImageFormat.Jpeg);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);
                sqlCommand = new SqlCommand("update Doctors set doc_photo=@photo where doc_id=@id", Program.sqlConnection);
                sqlCommand.Parameters.AddWithValue("@photo", photo);
                sqlCommand.Parameters.AddWithValue("@id", DocID);
                sqlCommand.ExecuteNonQuery();
            }

            Program.sqlConnection.Close();
        }
    }
}
