namespace DVLD
{
    partial class FrmLicenseReplacement
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
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD.ctrlDriverLicenseInfoWithFilter();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbReplacementfor = new System.Windows.Forms.GroupBox();
            this.rdLoseLicense = new System.Windows.Forms.RadioButton();
            this.rdDamageLicense = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRepacedLicenseID = new System.Windows.Forms.Label();
            this.lbOldLicense = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbLicenseApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btIssueReplacement = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Button();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llShowLicense = new System.Windows.Forms.LinkLabel();
            this.gbReplacementfor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(-2, 46);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(681, 402);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(203, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(212, 24);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "License Replacement";
            // 
            // gbReplacementfor
            // 
            this.gbReplacementfor.Controls.Add(this.rdLoseLicense);
            this.gbReplacementfor.Controls.Add(this.rdDamageLicense);
            this.gbReplacementfor.Location = new System.Drawing.Point(464, 65);
            this.gbReplacementfor.Name = "gbReplacementfor";
            this.gbReplacementfor.Size = new System.Drawing.Size(200, 64);
            this.gbReplacementfor.TabIndex = 2;
            this.gbReplacementfor.TabStop = false;
            this.gbReplacementfor.Text = "Replacement for";
            // 
            // rdLoseLicense
            // 
            this.rdLoseLicense.AutoSize = true;
            this.rdLoseLicense.Location = new System.Drawing.Point(6, 41);
            this.rdLoseLicense.Name = "rdLoseLicense";
            this.rdLoseLicense.Size = new System.Drawing.Size(88, 17);
            this.rdLoseLicense.TabIndex = 1;
            this.rdLoseLicense.TabStop = true;
            this.rdLoseLicense.Text = "Lose License";
            this.rdLoseLicense.UseVisualStyleBackColor = true;
            this.rdLoseLicense.CheckedChanged += new System.EventHandler(this.rdLoseLicense_CheckedChanged);
            // 
            // rdDamageLicense
            // 
            this.rdDamageLicense.AutoSize = true;
            this.rdDamageLicense.Location = new System.Drawing.Point(6, 19);
            this.rdDamageLicense.Name = "rdDamageLicense";
            this.rdDamageLicense.Size = new System.Drawing.Size(105, 17);
            this.rdDamageLicense.TabIndex = 0;
            this.rdDamageLicense.TabStop = true;
            this.rdDamageLicense.Text = "Damage License";
            this.rdDamageLicense.UseVisualStyleBackColor = true;
            this.rdDamageLicense.CheckedChanged += new System.EventHandler(this.rdDamageLicense_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRepacedLicenseID);
            this.groupBox2.Controls.Add(this.lbOldLicense);
            this.groupBox2.Controls.Add(this.lbCreatedBy);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbApplicationFees);
            this.groupBox2.Controls.Add(this.lbApplicationDate);
            this.groupBox2.Controls.Add(this.lbLicenseApplicationID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info For License Replacmenet";
            // 
            // lbRepacedLicenseID
            // 
            this.lbRepacedLicenseID.AutoSize = true;
            this.lbRepacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepacedLicenseID.Location = new System.Drawing.Point(582, 19);
            this.lbRepacedLicenseID.Name = "lbRepacedLicenseID";
            this.lbRepacedLicenseID.Size = new System.Drawing.Size(39, 15);
            this.lbRepacedLicenseID.TabIndex = 11;
            this.lbRepacedLicenseID.Text = "????";
            // 
            // lbOldLicense
            // 
            this.lbOldLicense.AutoSize = true;
            this.lbOldLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicense.Location = new System.Drawing.Point(582, 45);
            this.lbOldLicense.Name = "lbOldLicense";
            this.lbOldLicense.Size = new System.Drawing.Size(39, 15);
            this.lbOldLicense.TabIndex = 10;
            this.lbOldLicense.Text = "????";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(582, 77);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(39, 15);
            this.lbCreatedBy.TabIndex = 9;
            this.lbCreatedBy.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Replaced License ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Old License ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Created By";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(181, 74);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(39, 15);
            this.lbApplicationFees.TabIndex = 5;
            this.lbApplicationFees.Text = "????";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(181, 45);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(39, 15);
            this.lbApplicationDate.TabIndex = 4;
            this.lbApplicationDate.Text = "????";
            // 
            // lbLicenseApplicationID
            // 
            this.lbLicenseApplicationID.AutoSize = true;
            this.lbLicenseApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseApplicationID.Location = new System.Drawing.Point(181, 19);
            this.lbLicenseApplicationID.Name = "lbLicenseApplicationID";
            this.lbLicenseApplicationID.Size = new System.Drawing.Size(39, 15);
            this.lbLicenseApplicationID.TabIndex = 3;
            this.lbLicenseApplicationID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "L.R.Application ID";
            // 
            // btIssueReplacement
            // 
            this.btIssueReplacement.Location = new System.Drawing.Point(510, 533);
            this.btIssueReplacement.Name = "btIssueReplacement";
            this.btIssueReplacement.Size = new System.Drawing.Size(114, 23);
            this.btIssueReplacement.TabIndex = 4;
            this.btIssueReplacement.Text = "Issue Replacement";
            this.btIssueReplacement.UseVisualStyleBackColor = true;
            this.btIssueReplacement.Click += new System.EventHandler(this.btIssueReplacement_Click);
            // 
            // lbClose
            // 
            this.lbClose.Location = new System.Drawing.Point(410, 533);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(75, 23);
            this.lbClose.TabIndex = 5;
            this.lbClose.Text = "Close";
            this.lbClose.UseVisualStyleBackColor = true;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Location = new System.Drawing.Point(123, 533);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(109, 13);
            this.llShowLicenseHistory.TabIndex = 6;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History";
            // 
            // llShowLicense
            // 
            this.llShowLicense.AutoSize = true;
            this.llShowLicense.Location = new System.Drawing.Point(267, 533);
            this.llShowLicense.Name = "llShowLicense";
            this.llShowLicense.Size = new System.Drawing.Size(77, 13);
            this.llShowLicense.TabIndex = 7;
            this.llShowLicense.TabStop = true;
            this.llShowLicense.Text = "Show License ";
            this.llShowLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicense_LinkClicked);
            // 
            // FrmLicenseReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 584);
            this.Controls.Add(this.llShowLicense);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.btIssueReplacement);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbReplacementfor);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Name = "FrmLicenseReplacement";
            this.Text = "FrmLicenseReplacement";
            this.Load += new System.EventHandler(this.FrmLicenseReplacement_Load);
            this.gbReplacementfor.ResumeLayout(false);
            this.gbReplacementfor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbReplacementfor;
        private System.Windows.Forms.RadioButton rdLoseLicense;
        private System.Windows.Forms.RadioButton rdDamageLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLicenseApplicationID;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbRepacedLicenseID;
        private System.Windows.Forms.Label lbOldLicense;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btIssueReplacement;
        private System.Windows.Forms.Button lbClose;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llShowLicense;
    }
}