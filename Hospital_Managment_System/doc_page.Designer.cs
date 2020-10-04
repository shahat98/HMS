namespace Hospital_Managment_System
{
    partial class doc_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doc_pic = new System.Windows.Forms.PictureBox();
            this.Browes = new System.Windows.Forms.Button();
            this.doc_patiants = new System.Windows.Forms.Button();
            this.edit_docINFO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.TextBox();
            this.time_from = new System.Windows.Forms.TextBox();
            this.doc_spec = new System.Windows.Forms.TextBox();
            this.doc_phone = new System.Windows.Forms.TextBox();
            this.time_to = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateInfo = new System.Windows.Forms.Button();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.passLable = new System.Windows.Forms.Label();
            this.InValidTime = new System.Windows.Forms.Label();
            this.InValidNumber = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doc_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // doc_pic
            // 
            this.doc_pic.Location = new System.Drawing.Point(396, 43);
            this.doc_pic.Name = "doc_pic";
            this.doc_pic.Size = new System.Drawing.Size(100, 116);
            this.doc_pic.TabIndex = 0;
            this.doc_pic.TabStop = false;
            // 
            // Browes
            // 
            this.Browes.Location = new System.Drawing.Point(409, 193);
            this.Browes.Name = "Browes";
            this.Browes.Size = new System.Drawing.Size(75, 23);
            this.Browes.TabIndex = 1;
            this.Browes.Text = "Browes";
            this.Browes.UseVisualStyleBackColor = true;
            this.Browes.Visible = false;
            this.Browes.Click += new System.EventHandler(this.Browes_Click);
            // 
            // doc_patiants
            // 
            this.doc_patiants.Location = new System.Drawing.Point(47, 273);
            this.doc_patiants.Name = "doc_patiants";
            this.doc_patiants.Size = new System.Drawing.Size(75, 23);
            this.doc_patiants.TabIndex = 2;
            this.doc_patiants.Text = "Patiants";
            this.doc_patiants.UseVisualStyleBackColor = true;
            this.doc_patiants.Click += new System.EventHandler(this.doc_patiants_Click);
            // 
            // edit_docINFO
            // 
            this.edit_docINFO.Location = new System.Drawing.Point(297, 42);
            this.edit_docINFO.Name = "edit_docINFO";
            this.edit_docINFO.Size = new System.Drawing.Size(41, 23);
            this.edit_docINFO.TabIndex = 3;
            this.edit_docINFO.Text = "Edit";
            this.edit_docINFO.UseVisualStyleBackColor = true;
            this.edit_docINFO.Click += new System.EventHandler(this.edit_docINFO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Specialization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Working hours";
            // 
            // doc_name
            // 
            this.doc_name.Location = new System.Drawing.Point(142, 45);
            this.doc_name.Name = "doc_name";
            this.doc_name.ReadOnly = true;
            this.doc_name.Size = new System.Drawing.Size(138, 20);
            this.doc_name.TabIndex = 8;
            // 
            // time_from
            // 
            this.time_from.Location = new System.Drawing.Point(142, 162);
            this.time_from.Name = "time_from";
            this.time_from.ReadOnly = true;
            this.time_from.Size = new System.Drawing.Size(62, 20);
            this.time_from.TabIndex = 9;
            // 
            // doc_spec
            // 
            this.doc_spec.Location = new System.Drawing.Point(142, 123);
            this.doc_spec.Name = "doc_spec";
            this.doc_spec.ReadOnly = true;
            this.doc_spec.Size = new System.Drawing.Size(138, 20);
            this.doc_spec.TabIndex = 10;
            // 
            // doc_phone
            // 
            this.doc_phone.Location = new System.Drawing.Point(142, 85);
            this.doc_phone.Name = "doc_phone";
            this.doc_phone.ReadOnly = true;
            this.doc_phone.Size = new System.Drawing.Size(138, 20);
            this.doc_phone.TabIndex = 11;
            // 
            // time_to
            // 
            this.time_to.Location = new System.Drawing.Point(220, 162);
            this.time_to.Name = "time_to";
            this.time_to.ReadOnly = true;
            this.time_to.Size = new System.Drawing.Size(60, 20);
            this.time_to.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = ":";
            // 
            // updateInfo
            // 
            this.updateInfo.Location = new System.Drawing.Point(47, 235);
            this.updateInfo.Name = "updateInfo";
            this.updateInfo.Size = new System.Drawing.Size(75, 23);
            this.updateInfo.TabIndex = 14;
            this.updateInfo.Text = "Update";
            this.updateInfo.UseVisualStyleBackColor = true;
            this.updateInfo.Visible = false;
            this.updateInfo.Click += new System.EventHandler(this.updateInfo_Click);
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(142, 196);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(138, 20);
            this.editPassword.TabIndex = 15;
            this.editPassword.Visible = false;
            // 
            // passLable
            // 
            this.passLable.AutoSize = true;
            this.passLable.Location = new System.Drawing.Point(44, 203);
            this.passLable.Name = "passLable";
            this.passLable.Size = new System.Drawing.Size(53, 13);
            this.passLable.TabIndex = 16;
            this.passLable.Text = "Password";
            this.passLable.Visible = false;
            // 
            // InValidTime
            // 
            this.InValidTime.AutoSize = true;
            this.InValidTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InValidTime.ForeColor = System.Drawing.Color.Red;
            this.InValidTime.Location = new System.Drawing.Point(294, 169);
            this.InValidTime.Name = "InValidTime";
            this.InValidTime.Size = new System.Drawing.Size(73, 13);
            this.InValidTime.TabIndex = 17;
            this.InValidTime.Text = "InValidTime";
            this.InValidTime.Visible = false;
            // 
            // InValidNumber
            // 
            this.InValidNumber.AutoSize = true;
            this.InValidNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InValidNumber.ForeColor = System.Drawing.Color.Red;
            this.InValidNumber.Location = new System.Drawing.Point(297, 92);
            this.InValidNumber.Name = "InValidNumber";
            this.InValidNumber.Size = new System.Drawing.Size(89, 13);
            this.InValidNumber.TabIndex = 18;
            this.InValidNumber.Text = "InValidNumber";
            this.InValidNumber.Visible = false;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(409, 273);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 19;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // doc_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 341);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.InValidNumber);
            this.Controls.Add(this.InValidTime);
            this.Controls.Add(this.passLable);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.updateInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time_to);
            this.Controls.Add(this.doc_phone);
            this.Controls.Add(this.doc_spec);
            this.Controls.Add(this.time_from);
            this.Controls.Add(this.doc_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_docINFO);
            this.Controls.Add(this.doc_patiants);
            this.Controls.Add(this.Browes);
            this.Controls.Add(this.doc_pic);
            this.Name = "doc_page";
            this.Text = "doc_page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Close);
            this.Load += new System.EventHandler(this.doc_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doc_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox doc_pic;
        private System.Windows.Forms.Button Browes;
        private System.Windows.Forms.Button doc_patiants;
        private System.Windows.Forms.Button edit_docINFO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doc_name;
        private System.Windows.Forms.TextBox time_from;
        private System.Windows.Forms.TextBox doc_spec;
        private System.Windows.Forms.TextBox doc_phone;
        private System.Windows.Forms.TextBox time_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button updateInfo;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.Label passLable;
        private System.Windows.Forms.Label InValidTime;
        private System.Windows.Forms.Label InValidNumber;
        private System.Windows.Forms.Button logout;
    }
}