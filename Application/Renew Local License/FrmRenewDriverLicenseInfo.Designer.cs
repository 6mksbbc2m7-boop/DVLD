namespace DVLD
{
    partial class FrmRenewDriverLicenseInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.lbRenewLicenseID = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.lbIssueDATE = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.LbRLAppID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LLShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btRenew = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew DriverLicense Info";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(3, 36);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(778, 448);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 1;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.lbRenewLicenseID);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbAppDate);
            this.groupBox1.Controls.Add(this.lbIssueDATE);
            this.groupBox1.Controls.Add(this.lbAppFees);
            this.groupBox1.Controls.Add(this.lbLicenseFees);
            this.groupBox1.Controls.Add(this.LbRLAppID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LLShowLicenseHistory);
            this.groupBox1.Controls.Add(this.llShowNewLicenseInfo);
            this.groupBox1.Controls.Add(this.btRenew);
            this.groupBox1.Controls.Add(this.btClose);
            this.groupBox1.Location = new System.Drawing.Point(12, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New License Info";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(148, 275);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(487, 20);
            this.txtNotes.TabIndex = 27;
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(605, 223);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(39, 16);
            this.lbTotalFees.TabIndex = 26;
            this.lbTotalFees.Text = "????";
            // 
            // lbRenewLicenseID
            // 
            this.lbRenewLicenseID.AutoSize = true;
            this.lbRenewLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewLicenseID.Location = new System.Drawing.Point(605, 32);
            this.lbRenewLicenseID.Name = "lbRenewLicenseID";
            this.lbRenewLicenseID.Size = new System.Drawing.Size(39, 16);
            this.lbRenewLicenseID.TabIndex = 25;
            this.lbRenewLicenseID.Text = "????";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(605, 75);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(39, 16);
            this.lbOldLicenseID.TabIndex = 24;
            this.lbOldLicenseID.Text = "????";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.Location = new System.Drawing.Point(605, 123);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(39, 16);
            this.lbExpirationDate.TabIndex = 23;
            this.lbExpirationDate.Text = "????";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(605, 171);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(39, 16);
            this.lbCreatedBy.TabIndex = 22;
            this.lbCreatedBy.Text = "????";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(447, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Old License ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Expiration Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(447, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Created By";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total Fees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Renw License ID";
            // 
            // lbAppDate
            // 
            this.lbAppDate.AutoSize = true;
            this.lbAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppDate.Location = new System.Drawing.Point(193, 75);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(39, 16);
            this.lbAppDate.TabIndex = 16;
            this.lbAppDate.Text = "????";
            // 
            // lbIssueDATE
            // 
            this.lbIssueDATE.AutoSize = true;
            this.lbIssueDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDATE.Location = new System.Drawing.Point(193, 123);
            this.lbIssueDATE.Name = "lbIssueDATE";
            this.lbIssueDATE.Size = new System.Drawing.Size(39, 16);
            this.lbIssueDATE.TabIndex = 15;
            this.lbIssueDATE.Text = "????";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppFees.Location = new System.Drawing.Point(193, 171);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(39, 16);
            this.lbAppFees.TabIndex = 14;
            this.lbAppFees.Text = "????";
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFees.Location = new System.Drawing.Point(193, 223);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(39, 16);
            this.lbLicenseFees.TabIndex = 13;
            this.lbLicenseFees.Text = "????";
            // 
            // LbRLAppID
            // 
            this.LbRLAppID.AutoSize = true;
            this.LbRLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRLAppID.Location = new System.Drawing.Point(193, 32);
            this.LbRLAppID.Name = "LbRLAppID";
            this.LbRLAppID.Size = new System.Drawing.Size(39, 16);
            this.LbRLAppID.TabIndex = 11;
            this.LbRLAppID.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Issue Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Application Fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "License Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Application Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "R.L.Application ID";
            // 
            // LLShowLicenseHistory
            // 
            this.LLShowLicenseHistory.AutoSize = true;
            this.LLShowLicenseHistory.Location = new System.Drawing.Point(193, 317);
            this.LLShowLicenseHistory.Name = "LLShowLicenseHistory";
            this.LLShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.LLShowLicenseHistory.TabIndex = 4;
            this.LLShowLicenseHistory.TabStop = true;
            this.LLShowLicenseHistory.Text = "Show License History";
            // 
            // llShowNewLicenseInfo
            // 
            this.llShowNewLicenseInfo.AutoSize = true;
            this.llShowNewLicenseInfo.Location = new System.Drawing.Point(334, 317);
            this.llShowNewLicenseInfo.Name = "llShowNewLicenseInfo";
            this.llShowNewLicenseInfo.Size = new System.Drawing.Size(120, 13);
            this.llShowNewLicenseInfo.TabIndex = 3;
            this.llShowNewLicenseInfo.TabStop = true;
            this.llShowNewLicenseInfo.Text = "Show New License Info";
            this.llShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowNewLicenseInfo_LinkClicked);
            // 
            // btRenew
            // 
            this.btRenew.Location = new System.Drawing.Point(661, 317);
            this.btRenew.Name = "btRenew";
            this.btRenew.Size = new System.Drawing.Size(75, 23);
            this.btRenew.TabIndex = 2;
            this.btRenew.Text = "Renew";
            this.btRenew.UseVisualStyleBackColor = true;
            this.btRenew.Click += new System.EventHandler(this.btRenew_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(560, 317);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRenewDriverLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(834, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "FrmRenewDriverLicenseInfo";
            this.Text = "FrmRenewDriverLicenseInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRenew;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel LLShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llShowNewLicenseInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label lbIssueDATE;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label LbRLAppID;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label lbRenewLicenseID;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label lbCreatedBy;
    }
}