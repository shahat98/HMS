namespace Hospital_Managment_System
{
    partial class LogIn
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
            this.log_in = new System.Windows.Forms.Button();
            this.LogInID = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.DocID = new System.Windows.Forms.TextBox();
            this.DocPass = new System.Windows.Forms.TextBox();
            this.InValid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.log_in.Location = new System.Drawing.Point(181, 167);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(75, 23);
            this.log_in.TabIndex = 0;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = true;
            this.log_in.Click += new System.EventHandler(this.log_in_Click);
            this.log_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ok);
            // 
            // LogInID
            // 
            this.LogInID.AutoSize = true;
            this.LogInID.Location = new System.Drawing.Point(83, 53);
            this.LogInID.Name = "LogInID";
            this.LogInID.Size = new System.Drawing.Size(18, 13);
            this.LogInID.TabIndex = 1;
            this.LogInID.Text = "ID";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(83, 95);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // DocID
            // 
            this.DocID.Location = new System.Drawing.Point(156, 53);
            this.DocID.Name = "DocID";
            this.DocID.Size = new System.Drawing.Size(122, 20);
            this.DocID.TabIndex = 3;
            this.DocID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ok);
            // 
            // DocPass
            // 
            this.DocPass.Location = new System.Drawing.Point(156, 88);
            this.DocPass.Name = "DocPass";
            this.DocPass.Size = new System.Drawing.Size(122, 20);
            this.DocPass.TabIndex = 4;
            this.DocPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ok);
            // 
            // InValid
            // 
            this.InValid.AutoSize = true;
            this.InValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InValid.ForeColor = System.Drawing.Color.Red;
            this.InValid.Location = new System.Drawing.Point(153, 128);
            this.InValid.Name = "InValid";
            this.InValid.Size = new System.Drawing.Size(136, 13);
            this.InValid.TabIndex = 5;
            this.InValid.Text = "InValid ID or Password";
            this.InValid.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 326);
            this.Controls.Add(this.InValid);
            this.Controls.Add(this.DocPass);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.password);
            this.Controls.Add(this.LogInID);
            this.Controls.Add(this.log_in);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_in;
        private System.Windows.Forms.Label LogInID;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox DocID;
        private System.Windows.Forms.TextBox DocPass;
        private System.Windows.Forms.Label InValid;
    }
}

