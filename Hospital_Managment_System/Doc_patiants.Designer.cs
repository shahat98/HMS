namespace Hospital_Managment_System
{
    partial class Doc_patiants
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
            this.Patiants = new System.Windows.Forms.DataGridView();
            this.patID = new System.Windows.Forms.Label();
            this.pID = new System.Windows.Forms.TextBox();
            this.view_pat = new System.Windows.Forms.Button();
            this.del_pat = new System.Windows.Forms.Button();
            this.add_pat = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Patiants)).BeginInit();
            this.SuspendLayout();
            // 
            // Patiants
            // 
            this.Patiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patiants.Location = new System.Drawing.Point(287, 37);
            this.Patiants.Name = "Patiants";
            this.Patiants.Size = new System.Drawing.Size(384, 268);
            this.Patiants.TabIndex = 0;
            this.Patiants.SelectionChanged += new System.EventHandler(this.selectPat);
            // 
            // patID
            // 
            this.patID.AutoSize = true;
            this.patID.Location = new System.Drawing.Point(27, 37);
            this.patID.Name = "patID";
            this.patID.Size = new System.Drawing.Size(54, 13);
            this.patID.TabIndex = 1;
            this.patID.Text = "Patiant ID";
            // 
            // pID
            // 
            this.pID.Location = new System.Drawing.Point(93, 37);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(131, 20);
            this.pID.TabIndex = 2;
            // 
            // view_pat
            // 
            this.view_pat.Location = new System.Drawing.Point(93, 81);
            this.view_pat.Name = "view_pat";
            this.view_pat.Size = new System.Drawing.Size(75, 23);
            this.view_pat.TabIndex = 3;
            this.view_pat.Text = "View";
            this.view_pat.UseVisualStyleBackColor = true;
            this.view_pat.Click += new System.EventHandler(this.view_pat_Click);
            // 
            // del_pat
            // 
            this.del_pat.Location = new System.Drawing.Point(188, 81);
            this.del_pat.Name = "del_pat";
            this.del_pat.Size = new System.Drawing.Size(75, 23);
            this.del_pat.TabIndex = 4;
            this.del_pat.Text = "Delete";
            this.del_pat.UseVisualStyleBackColor = true;
            this.del_pat.Click += new System.EventHandler(this.del_pat_Click);
            // 
            // add_pat
            // 
            this.add_pat.Location = new System.Drawing.Point(93, 282);
            this.add_pat.Name = "add_pat";
            this.add_pat.Size = new System.Drawing.Size(131, 23);
            this.add_pat.TabIndex = 5;
            this.add_pat.Text = "Add New Patiant";
            this.add_pat.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(563, 313);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 6;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Doc_patiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 348);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.add_pat);
            this.Controls.Add(this.del_pat);
            this.Controls.Add(this.view_pat);
            this.Controls.Add(this.pID);
            this.Controls.Add(this.patID);
            this.Controls.Add(this.Patiants);
            this.Name = "Doc_patiants";
            this.Text = "Doc_patiants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BeforeClose);
            this.Load += new System.EventHandler(this.Doc_patiants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patiants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Patiants;
        private System.Windows.Forms.Label patID;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.Button view_pat;
        private System.Windows.Forms.Button del_pat;
        private System.Windows.Forms.Button add_pat;
        private System.Windows.Forms.Button Update;
    }
}