namespace DVLD
{
    partial class FrmAddUpdateLocalDrivingLicenseApplications
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
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.tbInformation = new System.Windows.Forms.TabPage();
            this.btNext = new System.Windows.Forms.Button();
            this.crtPersonCard1 = new DVLD.crtPersonCard();
            this.tbApplicationInfo = new System.Windows.Forms.TabPage();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.cpLicenseClass = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tcApplicationInfo.SuspendLayout();
            this.tbInformation.SuspendLayout();
            this.tbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.tbInformation);
            this.tcApplicationInfo.Controls.Add(this.tbApplicationInfo);
            this.tcApplicationInfo.Location = new System.Drawing.Point(3, 66);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(820, 425);
            this.tcApplicationInfo.TabIndex = 0;
            // 
            // tbInformation
            // 
            this.tbInformation.Controls.Add(this.btNext);
            this.tbInformation.Controls.Add(this.crtPersonCard1);
            this.tbInformation.Location = new System.Drawing.Point(4, 22);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbInformation.Size = new System.Drawing.Size(812, 399);
            this.tbInformation.TabIndex = 0;
            this.tbInformation.Text = "Information";
            this.tbInformation.UseVisualStyleBackColor = true;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(725, 365);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // crtPersonCard1
            // 
            this.crtPersonCard1.FilterEnabled = true;
            this.crtPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.crtPersonCard1.Name = "crtPersonCard1";
            this.crtPersonCard1.ShowAddPerson = true;
            this.crtPersonCard1.Size = new System.Drawing.Size(813, 356);
            this.crtPersonCard1.TabIndex = 0;
            this.crtPersonCard1.OnPersonSelected += new System.Action<int>(this.crtPersonCard1_OnPersonSelected);
            // 
            // tbApplicationInfo
            // 
            this.tbApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.tbApplicationInfo.Controls.Add(this.lbFees);
            this.tbApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tbApplicationInfo.Controls.Add(this.lbID);
            this.tbApplicationInfo.Controls.Add(this.cpLicenseClass);
            this.tbApplicationInfo.Controls.Add(this.label6);
            this.tbApplicationInfo.Controls.Add(this.label5);
            this.tbApplicationInfo.Controls.Add(this.label4);
            this.tbApplicationInfo.Controls.Add(this.label3);
            this.tbApplicationInfo.Controls.Add(this.label2);
            this.tbApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.tbApplicationInfo.Name = "tbApplicationInfo";
            this.tbApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbApplicationInfo.Size = new System.Drawing.Size(812, 399);
            this.tbApplicationInfo.TabIndex = 1;
            this.tbApplicationInfo.Text = "Application Info";
            this.tbApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Location = new System.Drawing.Point(216, 251);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(25, 13);
            this.lbCreatedBy.TabIndex = 14;
            this.lbCreatedBy.Text = "???";
            // 
            // lbFees
            // 
            this.lbFees.AutoSize = true;
            this.lbFees.Location = new System.Drawing.Point(216, 210);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(25, 13);
            this.lbFees.TabIndex = 13;
            this.lbFees.Text = "???";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Location = new System.Drawing.Point(216, 112);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(25, 13);
            this.lbApplicationDate.TabIndex = 12;
            this.lbApplicationDate.Text = "???";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(216, 65);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 13);
            this.lbID.TabIndex = 11;
            this.lbID.Text = "???";
            // 
            // cpLicenseClass
            // 
            this.cpLicenseClass.FormattingEnabled = true;
            this.cpLicenseClass.Location = new System.Drawing.Point(199, 156);
            this.cpLicenseClass.Name = "cpLicenseClass";
            this.cpLicenseClass.Size = new System.Drawing.Size(121, 21);
            this.cpLicenseClass.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Created By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = " Application Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "L.D. Application ID";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(730, 510);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(638, 510);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(251, 29);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(287, 24);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Local Driving License Application";
            // 
            // FrmAddUpdateLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 545);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tcApplicationInfo);
            this.Name = "FrmAddUpdateLocalDrivingLicenseApplications";
            this.Text = "Add Update Local DrivingLicense  Applications";
            this.Activated += new System.EventHandler(this.FrmAddUpdateLocalDrivingLicenseApplications_Activated);
            this.Load += new System.EventHandler(this.FrmAddUpdateLocalDrivingLicenseApplications_Load);
            this.tcApplicationInfo.ResumeLayout(false);
            this.tbInformation.ResumeLayout(false);
            this.tbApplicationInfo.ResumeLayout(false);
            this.tbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tbInformation;
        private System.Windows.Forms.TabPage tbApplicationInfo;
        private System.Windows.Forms.Button btNext;
        private crtPersonCard crtPersonCard1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cpLicenseClass;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbID;
    }
}