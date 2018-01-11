namespace WS_Starter_Ver2
{
    partial class Form1
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dgvResponse = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetReellerettighetshavere = new System.Windows.Forms.Button();
            this.dgvReellerettighetshavere = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOrgnrReellerettighetshavere = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPersonSearch = new System.Windows.Forms.Button();
            this.dgvPersonSearch = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponse)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReellerettighetshavere)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetData.Location = new System.Drawing.Point(838, 39);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(207, 23);
            this.btnGetData.TabIndex = 4;
            this.btnGetData.Text = "Søk";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(103, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // dgvResponse
            // 
            this.dgvResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponse.Location = new System.Drawing.Point(6, 68);
            this.dgvResponse.Name = "dgvResponse";
            this.dgvResponse.Size = new System.Drawing.Size(1039, 421);
            this.dgvResponse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hit list:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(97, 13);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(948, 20);
            this.txtCompanyName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Company Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 521);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnGetData);
            this.tabPage1.Controls.Add(this.txtCompanyName);
            this.tabPage1.Controls.Add(this.dgvResponse);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Firmasøk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetReellerettighetshavere);
            this.tabPage2.Controls.Add(this.dgvReellerettighetshavere);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxOrgnrReellerettighetshavere);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reellerettighetshavere";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetReellerettighetshavere
            // 
            this.btnGetReellerettighetshavere.Location = new System.Drawing.Point(172, 12);
            this.btnGetReellerettighetshavere.Name = "btnGetReellerettighetshavere";
            this.btnGetReellerettighetshavere.Size = new System.Drawing.Size(75, 23);
            this.btnGetReellerettighetshavere.TabIndex = 7;
            this.btnGetReellerettighetshavere.Text = "Hent data";
            this.btnGetReellerettighetshavere.UseVisualStyleBackColor = true;
            this.btnGetReellerettighetshavere.Click += new System.EventHandler(this.btnGetReellerettighetshavere_Click);
            // 
            // dgvReellerettighetshavere
            // 
            this.dgvReellerettighetshavere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReellerettighetshavere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReellerettighetshavere.Location = new System.Drawing.Point(6, 68);
            this.dgvReellerettighetshavere.Name = "dgvReellerettighetshavere";
            this.dgvReellerettighetshavere.Size = new System.Drawing.Size(1039, 421);
            this.dgvReellerettighetshavere.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Orgnr:";
            // 
            // textBoxOrgnrReellerettighetshavere
            // 
            this.textBoxOrgnrReellerettighetshavere.Location = new System.Drawing.Point(49, 14);
            this.textBoxOrgnrReellerettighetshavere.Name = "textBoxOrgnrReellerettighetshavere";
            this.textBoxOrgnrReellerettighetshavere.Size = new System.Drawing.Size(117, 20);
            this.textBoxOrgnrReellerettighetshavere.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtpBornDate);
            this.tabPage3.Controls.Add(this.tbLastName);
            this.tabPage3.Controls.Add(this.tbFirstName);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnPersonSearch);
            this.tabPage3.Controls.Add(this.dgvPersonSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1051, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Personsøk";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(65, 40);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Født dato";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnPersonSearch
            // 
            this.btnPersonSearch.Location = new System.Drawing.Point(317, 63);
            this.btnPersonSearch.Name = "btnPersonSearch";
            this.btnPersonSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPersonSearch.TabIndex = 1;
            this.btnPersonSearch.Text = "Hent";
            this.btnPersonSearch.UseVisualStyleBackColor = true;
            this.btnPersonSearch.Click += new System.EventHandler(this.btnPersonSearch_Click);
            // 
            // dgvPersonSearch
            // 
            this.dgvPersonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonSearch.Location = new System.Drawing.Point(6, 133);
            this.dgvPersonSearch.Name = "dgvPersonSearch";
            this.dgvPersonSearch.Size = new System.Drawing.Size(1039, 356);
            this.dgvPersonSearch.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fornavn";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Etternavn";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(65, 66);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 4;
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(65, 14);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBornDate.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 633);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponse)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReellerettighetshavere)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dgvResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGetReellerettighetshavere;
        private System.Windows.Forms.DataGridView dgvReellerettighetshavere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOrgnrReellerettighetshavere;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPersonSearch;
        private System.Windows.Forms.DataGridView dgvPersonSearch;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

