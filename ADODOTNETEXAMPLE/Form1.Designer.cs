namespace ADODOTNETEXAMPLE
{
    partial class ctlLoginForm
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
            this.ctlLabelUserName = new System.Windows.Forms.Label();
            this.ctlTxtUserName = new System.Windows.Forms.TextBox();
            this.ctlBtnLogin = new System.Windows.Forms.Button();
            this.ctlLabelPassword = new System.Windows.Forms.Label();
            this.ctlTxtPassword = new System.Windows.Forms.TextBox();
            this.ctlBtnRegister = new System.Windows.Forms.Button();
            this.ctlLabelID = new System.Windows.Forms.Label();
            this.ctlTxtID = new System.Windows.Forms.TextBox();
            this.ctlBtnSearch = new System.Windows.Forms.Button();
            this.ctlBtnUpdate = new System.Windows.Forms.Button();
            this.ctlBtnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ctlBtnDisplayData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlLabelUserName
            // 
            this.ctlLabelUserName.AutoSize = true;
            this.ctlLabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlLabelUserName.Location = new System.Drawing.Point(52, 81);
            this.ctlLabelUserName.Name = "ctlLabelUserName";
            this.ctlLabelUserName.Size = new System.Drawing.Size(88, 18);
            this.ctlLabelUserName.TabIndex = 0;
            this.ctlLabelUserName.Text = "UserName";
            // 
            // ctlTxtUserName
            // 
            this.ctlTxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlTxtUserName.Location = new System.Drawing.Point(173, 81);
            this.ctlTxtUserName.Name = "ctlTxtUserName";
            this.ctlTxtUserName.Size = new System.Drawing.Size(228, 24);
            this.ctlTxtUserName.TabIndex = 1;
            this.ctlTxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctlBtnLogin
            // 
            this.ctlBtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBtnLogin.Location = new System.Drawing.Point(28, 195);
            this.ctlBtnLogin.Name = "ctlBtnLogin";
            this.ctlBtnLogin.Size = new System.Drawing.Size(112, 35);
            this.ctlBtnLogin.TabIndex = 2;
            this.ctlBtnLogin.Text = "login";
            this.ctlBtnLogin.UseVisualStyleBackColor = true;
            this.ctlBtnLogin.Click += new System.EventHandler(this.ctlBtnLogin_Click);
            // 
            // ctlLabelPassword
            // 
            this.ctlLabelPassword.AutoSize = true;
            this.ctlLabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlLabelPassword.Location = new System.Drawing.Point(52, 144);
            this.ctlLabelPassword.Name = "ctlLabelPassword";
            this.ctlLabelPassword.Size = new System.Drawing.Size(81, 18);
            this.ctlLabelPassword.TabIndex = 3;
            this.ctlLabelPassword.Text = "password";
            // 
            // ctlTxtPassword
            // 
            this.ctlTxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlTxtPassword.Location = new System.Drawing.Point(173, 144);
            this.ctlTxtPassword.Name = "ctlTxtPassword";
            this.ctlTxtPassword.PasswordChar = '*';
            this.ctlTxtPassword.Size = new System.Drawing.Size(228, 24);
            this.ctlTxtPassword.TabIndex = 4;
            this.ctlTxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctlBtnRegister
            // 
            this.ctlBtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBtnRegister.Location = new System.Drawing.Point(161, 195);
            this.ctlBtnRegister.Name = "ctlBtnRegister";
            this.ctlBtnRegister.Size = new System.Drawing.Size(112, 35);
            this.ctlBtnRegister.TabIndex = 5;
            this.ctlBtnRegister.Text = "Register";
            this.ctlBtnRegister.UseVisualStyleBackColor = true;
            this.ctlBtnRegister.Click += new System.EventHandler(this.ctlBtnRegister_Click);
            // 
            // ctlLabelID
            // 
            this.ctlLabelID.AutoSize = true;
            this.ctlLabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlLabelID.Location = new System.Drawing.Point(52, 30);
            this.ctlLabelID.Name = "ctlLabelID";
            this.ctlLabelID.Size = new System.Drawing.Size(21, 18);
            this.ctlLabelID.TabIndex = 6;
            this.ctlLabelID.Text = "Id";
            // 
            // ctlTxtID
            // 
            this.ctlTxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlTxtID.Location = new System.Drawing.Point(173, 24);
            this.ctlTxtID.Name = "ctlTxtID";
            this.ctlTxtID.Size = new System.Drawing.Size(228, 24);
            this.ctlTxtID.TabIndex = 7;
            this.ctlTxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctlBtnSearch
            // 
            this.ctlBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBtnSearch.Location = new System.Drawing.Point(302, 195);
            this.ctlBtnSearch.Name = "ctlBtnSearch";
            this.ctlBtnSearch.Size = new System.Drawing.Size(112, 35);
            this.ctlBtnSearch.TabIndex = 8;
            this.ctlBtnSearch.Text = "Search";
            this.ctlBtnSearch.UseVisualStyleBackColor = true;
            this.ctlBtnSearch.Click += new System.EventHandler(this.ctlBtnSearch_Click);
            // 
            // ctlBtnUpdate
            // 
            this.ctlBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBtnUpdate.Location = new System.Drawing.Point(21, 236);
            this.ctlBtnUpdate.Name = "ctlBtnUpdate";
            this.ctlBtnUpdate.Size = new System.Drawing.Size(112, 35);
            this.ctlBtnUpdate.TabIndex = 9;
            this.ctlBtnUpdate.Text = "Update";
            this.ctlBtnUpdate.UseVisualStyleBackColor = true;
            this.ctlBtnUpdate.Click += new System.EventHandler(this.ctlBtnUpdate_Click);
            // 
            // ctlBtnDelete
            // 
            this.ctlBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBtnDelete.Location = new System.Drawing.Point(161, 238);
            this.ctlBtnDelete.Name = "ctlBtnDelete";
            this.ctlBtnDelete.Size = new System.Drawing.Size(112, 35);
            this.ctlBtnDelete.TabIndex = 10;
            this.ctlBtnDelete.Text = "Delete";
            this.ctlBtnDelete.UseVisualStyleBackColor = true;
            this.ctlBtnDelete.Click += new System.EventHandler(this.ctlBtnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(420, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(587, 249);
            this.dataGridView1.TabIndex = 11;
            // 
            // ctlBtnDisplayData
            // 
            this.ctlBtnDisplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlBtnDisplayData.Location = new System.Drawing.Point(302, 238);
            this.ctlBtnDisplayData.Name = "ctlBtnDisplayData";
            this.ctlBtnDisplayData.Size = new System.Drawing.Size(112, 35);
            this.ctlBtnDisplayData.TabIndex = 12;
            this.ctlBtnDisplayData.Text = "Display";
            this.ctlBtnDisplayData.UseVisualStyleBackColor = true;
            this.ctlBtnDisplayData.Click += new System.EventHandler(this.ctlBtnDisplayData_Click);
            // 
            // ctlLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(911, 312);
            this.Controls.Add(this.ctlBtnDisplayData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctlBtnDelete);
            this.Controls.Add(this.ctlBtnUpdate);
            this.Controls.Add(this.ctlBtnSearch);
            this.Controls.Add(this.ctlTxtID);
            this.Controls.Add(this.ctlLabelID);
            this.Controls.Add(this.ctlBtnRegister);
            this.Controls.Add(this.ctlTxtPassword);
            this.Controls.Add(this.ctlLabelPassword);
            this.Controls.Add(this.ctlBtnLogin);
            this.Controls.Add(this.ctlTxtUserName);
            this.Controls.Add(this.ctlLabelUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctlLoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctlLabelUserName;
        private System.Windows.Forms.TextBox ctlTxtUserName;
        private System.Windows.Forms.Button ctlBtnLogin;
        private System.Windows.Forms.Label ctlLabelPassword;
        private System.Windows.Forms.TextBox ctlTxtPassword;
        private System.Windows.Forms.Button ctlBtnRegister;
        private System.Windows.Forms.Label ctlLabelID;
        private System.Windows.Forms.TextBox ctlTxtID;
        private System.Windows.Forms.Button ctlBtnSearch;
        private System.Windows.Forms.Button ctlBtnUpdate;
        private System.Windows.Forms.Button ctlBtnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ctlBtnDisplayData;
    }
}

