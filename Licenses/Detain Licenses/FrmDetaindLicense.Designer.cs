namespace DVLD
{
    partial class FrmDetaindLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbDetaindInfo = new System.Windows.Forms.GroupBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btDetain = new System.Windows.Forms.Button();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindeFees = new System.Windows.Forms.TextBox();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDetaindInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(24, 45);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(681, 402);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detaine License";
            // 
            // gbDetaindInfo
            // 
            this.gbDetaindInfo.Controls.Add(this.btClose);
            this.gbDetaindInfo.Controls.Add(this.btDetain);
            this.gbDetaindInfo.Controls.Add(this.lbLicenseID);
            this.gbDetaindInfo.Controls.Add(this.lbCreatedBy);
            this.gbDetaindInfo.Controls.Add(this.label6);
            this.gbDetaindInfo.Controls.Add(this.label5);
            this.gbDetaindInfo.Controls.Add(this.txtFindeFees);
            this.gbDetaindInfo.Controls.Add(this.lbDetainDate);
            this.gbDetaindInfo.Controls.Add(this.lbDetainID);
            this.gbDetaindInfo.Controls.Add(this.label4);
            this.gbDetaindInfo.Controls.Add(this.label3);
            this.gbDetaindInfo.Controls.Add(this.label2);
            this.gbDetaindInfo.Location = new System.Drawing.Point(0, 440);
            this.gbDetaindInfo.Name = "gbDetaindInfo";
            this.gbDetaindInfo.Size = new System.Drawing.Size(693, 124);
            this.gbDetaindInfo.TabIndex = 2;
            this.gbDetaindInfo.TabStop = false;
            this.gbDetaindInfo.Text = "Detain Info";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(453, 89);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDetain
            // 
            this.btDetain.Location = new System.Drawing.Point(557, 89);
            this.btDetain.Name = "btDetain";
            this.btDetain.Size = new System.Drawing.Size(75, 23);
            this.btDetain.TabIndex = 10;
            this.btDetain.Text = "Detain";
            this.btDetain.UseVisualStyleBackColor = true;
            this.btDetain.Click += new System.EventHandler(this.btDetain_Click);
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(621, 16);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(39, 15);
            this.lbLicenseID.TabIndex = 9;
            this.lbLicenseID.Text = "????";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(621, 48);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(39, 15);
            this.lbCreatedBy.TabIndex = 8;
            this.lbCreatedBy.Text = "????";
            this.lbCreatedBy.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Created By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "License ID";
            // 
            // txtFindeFees
            // 
            this.txtFindeFees.Location = new System.Drawing.Point(240, 80);
            this.txtFindeFees.Name = "txtFindeFees";
            this.txtFindeFees.Size = new System.Drawing.Size(100, 20);
            this.txtFindeFees.TabIndex = 5;
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(237, 48);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(39, 15);
            this.lbDetainDate.TabIndex = 4;
            this.lbDetainDate.Text = "????";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(237, 16);
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
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fine Fees";
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
            // FrmDetaindLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(705, 561);
            this.Controls.Add(this.gbDetaindInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Name = "FrmDetaindLicense";
            this.Text = "FrmDetaindLicense";
            this.Activated += new System.EventHandler(this.FrmDetaindLicense_Activated);
            this.Load += new System.EventHandler(this.FrmDetaindLicense_Load);
            this.gbDetaindInfo.ResumeLayout(false);
            this.gbDetaindInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetaindInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFindeFees;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDetain;
    }
}