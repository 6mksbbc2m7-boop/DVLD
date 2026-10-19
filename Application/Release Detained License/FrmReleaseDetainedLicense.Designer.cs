namespace DVLD
{
    partial class FrmReleaseDetainedLicense
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
            this.gbDetaindInfo = new System.Windows.Forms.GroupBox();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbFApplicationFees = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btRelease = new System.Windows.Forms.Button();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDetaindInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Release Detained License";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(13, 36);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(681, 402);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 1;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // gbDetaindInfo
            // 
            this.gbDetaindInfo.Controls.Add(this.lbApplicationID);
            this.gbDetaindInfo.Controls.Add(this.lbFineFees);
            this.gbDetaindInfo.Controls.Add(this.label9);
            this.gbDetaindInfo.Controls.Add(this.label8);
            this.gbDetaindInfo.Controls.Add(this.lbTotalFees);
            this.gbDetaindInfo.Controls.Add(this.label7);
            this.gbDetaindInfo.Controls.Add(this.lbFApplicationFees);
            this.gbDetaindInfo.Controls.Add(this.btClose);
            this.gbDetaindInfo.Controls.Add(this.btRelease);
            this.gbDetaindInfo.Controls.Add(this.lbLicenseID);
            this.gbDetaindInfo.Controls.Add(this.lbCreatedBy);
            this.gbDetaindInfo.Controls.Add(this.label6);
            this.gbDetaindInfo.Controls.Add(this.label5);
            this.gbDetaindInfo.Controls.Add(this.lbDetainDate);
            this.gbDetaindInfo.Controls.Add(this.lbDetainID);
            this.gbDetaindInfo.Controls.Add(this.label4);
            this.gbDetaindInfo.Controls.Add(this.label3);
            this.gbDetaindInfo.Controls.Add(this.label2);
            this.gbDetaindInfo.Location = new System.Drawing.Point(1, 444);
            this.gbDetaindInfo.Name = "gbDetaindInfo";
            this.gbDetaindInfo.Size = new System.Drawing.Size(681, 192);
            this.gbDetaindInfo.TabIndex = 3;
            this.gbDetaindInfo.TabStop = false;
            this.gbDetaindInfo.Text = "Detain Info";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationID.Location = new System.Drawing.Point(607, 114);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(39, 15);
            this.lbApplicationID.TabIndex = 18;
            this.lbApplicationID.Text = "????";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFees.Location = new System.Drawing.Point(607, 80);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(39, 15);
            this.lbFineFees.TabIndex = 17;
            this.lbFineFees.Text = "????";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Application ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fine Fees";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(224, 114);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(39, 15);
            this.lbTotalFees.TabIndex = 14;
            this.lbTotalFees.Text = "????";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Fees";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbFApplicationFees
            // 
            this.lbFApplicationFees.AutoSize = true;
            this.lbFApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFApplicationFees.Location = new System.Drawing.Point(224, 80);
            this.lbFApplicationFees.Name = "lbFApplicationFees";
            this.lbFApplicationFees.Size = new System.Drawing.Size(39, 15);
            this.lbFApplicationFees.TabIndex = 12;
            this.lbFApplicationFees.Text = "????";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(446, 148);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btRelease
            // 
            this.btRelease.Location = new System.Drawing.Point(560, 148);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(75, 23);
            this.btRelease.TabIndex = 10;
            this.btRelease.Text = "Release";
            this.btRelease.UseVisualStyleBackColor = true;
            this.btRelease.Click += new System.EventHandler(this.btRelease_Click);
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(607, 16);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(39, 15);
            this.lbLicenseID.TabIndex = 9;
            this.lbLicenseID.Text = "????";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(607, 48);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(39, 15);
            this.lbCreatedBy.TabIndex = 8;
            this.lbCreatedBy.Text = "????";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Created By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "License ID";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(224, 48);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(39, 15);
            this.lbDetainDate.TabIndex = 4;
            this.lbDetainDate.Text = "????";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(224, 16);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(39, 15);
            this.lbDetainID.TabIndex = 3;
            this.lbDetainID.Text = "????";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detain  Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain ID";
            // 
            // FrmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(709, 575);
            this.Controls.Add(this.gbDetaindInfo);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "FrmReleaseDetainedLicense";
            this.Text = "Release Detaind Licese";
            this.Load += new System.EventHandler(this.FrmReleaseDetainedLicense_Load);
            this.gbDetaindInfo.ResumeLayout(false);
            this.gbDetaindInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbDetaindInfo;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFApplicationFees;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btRelease;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}