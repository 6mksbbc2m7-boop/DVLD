namespace DVLD
{
    partial class FrmAddUpdatePerson
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
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textPrsonID = new System.Windows.Forms.TextBox();
            this.texFirstName = new System.Windows.Forms.TextBox();
            this.textSecond = new System.Windows.Forms.TextBox();
            this.textThirdName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textNationalNUmber = new System.Windows.Forms.TextBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.lblDateOFbirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.cpCountry = new System.Windows.Forms.ComboBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.linSetImage = new System.Windows.Forms.LinkLabel();
            this.linRemove = new System.Windows.Forms.LinkLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(293, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(154, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add New Person";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(37, 60);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(66, 16);
            this.lblPersonID.TabIndex = 1;
            this.lblPersonID.Text = "Person ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "National Nu";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.Location = new System.Drawing.Point(37, 177);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(52, 16);
            this.lblGendor.TabIndex = 4;
            this.lblGendor.Text = "Gendor";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(37, 216);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(37, 255);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // textPrsonID
            // 
            this.textPrsonID.Location = new System.Drawing.Point(161, 60);
            this.textPrsonID.Name = "textPrsonID";
            this.textPrsonID.Size = new System.Drawing.Size(100, 20);
            this.textPrsonID.TabIndex = 7;
            this.textPrsonID.Validating += new System.ComponentModel.CancelEventHandler(this.textPrsonID_Validating);
            // 
            // texFirstName
            // 
            this.texFirstName.Location = new System.Drawing.Point(161, 98);
            this.texFirstName.Name = "texFirstName";
            this.texFirstName.Size = new System.Drawing.Size(100, 20);
            this.texFirstName.TabIndex = 8;
            this.texFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.texFirstName_Validating);
            // 
            // textSecond
            // 
            this.textSecond.Location = new System.Drawing.Point(306, 98);
            this.textSecond.Name = "textSecond";
            this.textSecond.Size = new System.Drawing.Size(100, 20);
            this.textSecond.TabIndex = 9;
            this.textSecond.Validating += new System.ComponentModel.CancelEventHandler(this.textSecond_Validating);
            // 
            // textThirdName
            // 
            this.textThirdName.Location = new System.Drawing.Point(451, 98);
            this.textThirdName.Name = "textThirdName";
            this.textThirdName.Size = new System.Drawing.Size(100, 20);
            this.textThirdName.TabIndex = 10;
            this.textThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.textThirdName_Validating);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(596, 98);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 11;
            this.textLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textLastName_Validating);
            // 
            // textNationalNUmber
            // 
            this.textNationalNUmber.Location = new System.Drawing.Point(161, 137);
            this.textNationalNUmber.Name = "textNationalNUmber";
            this.textNationalNUmber.Size = new System.Drawing.Size(100, 20);
            this.textNationalNUmber.TabIndex = 12;
            this.textNationalNUmber.Validating += new System.ComponentModel.CancelEventHandler(this.textNationalNUmber_Validating);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(147, 177);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 13;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            this.rdMale.Validating += new System.ComponentModel.CancelEventHandler(this.rdMale_Validating);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(253, 177);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 14;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(161, 216);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 15;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            this.textEmail.VisibleChanged += new System.EventHandler(this.textEmail_VisibleChanged);
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textEmail_Validating);
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(161, 255);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 16;
            this.textAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textAddress_Validating);
            // 
            // lblDateOFbirth
            // 
            this.lblDateOFbirth.AutoSize = true;
            this.lblDateOFbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOFbirth.Location = new System.Drawing.Point(366, 178);
            this.lblDateOFbirth.Name = "lblDateOFbirth";
            this.lblDateOFbirth.Size = new System.Drawing.Size(81, 16);
            this.lblDateOFbirth.TabIndex = 17;
            this.lblDateOFbirth.Text = "Date Of Birth";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(366, 212);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(366, 246);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(52, 16);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(469, 178);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(201, 20);
            this.dtpDateOfBirth.TabIndex = 20;
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(469, 212);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 21;
            this.textPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textPhone_Validating);
            // 
            // cpCountry
            // 
            this.cpCountry.FormattingEnabled = true;
            this.cpCountry.Location = new System.Drawing.Point(469, 246);
            this.cpCountry.Name = "cpCountry";
            this.cpCountry.Size = new System.Drawing.Size(121, 21);
            this.cpCountry.TabIndex = 22;
            this.cpCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cpCountry_Validating);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Boy;
            this.pbPersonImage.Location = new System.Drawing.Point(40, 303);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(206, 166);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 23;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.Validating += new System.ComponentModel.CancelEventHandler(this.pbPersonImage_Validating);
            // 
            // linSetImage
            // 
            this.linSetImage.AutoSize = true;
            this.linSetImage.Location = new System.Drawing.Point(303, 318);
            this.linSetImage.Name = "linSetImage";
            this.linSetImage.Size = new System.Drawing.Size(55, 13);
            this.linSetImage.TabIndex = 24;
            this.linSetImage.TabStop = true;
            this.linSetImage.Text = "Set Image";
            this.linSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linSetImage_LinkClicked);
            // 
            // linRemove
            // 
            this.linRemove.AutoSize = true;
            this.linRemove.Location = new System.Drawing.Point(303, 375);
            this.linRemove.Name = "linRemove";
            this.linRemove.Size = new System.Drawing.Size(47, 13);
            this.linRemove.TabIndex = 25;
            this.linRemove.TabStop = true;
            this.linRemove.Text = "Remove";
            this.linRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linRemove_LinkClicked);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(285, 446);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(411, 446);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 27;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddUpdatePerson
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(740, 505);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.linRemove);
            this.Controls.Add(this.linSetImage);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.cpCountry);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDateOFbirth);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.textNationalNUmber);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textThirdName);
            this.Controls.Add(this.textSecond);
            this.Controls.Add(this.texFirstName);
            this.Controls.Add(this.textPrsonID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmAddUpdatePerson";
            this.Text = "Add/Edite";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textPrsonID;
        private System.Windows.Forms.TextBox texFirstName;
        private System.Windows.Forms.TextBox textSecond;
        private System.Windows.Forms.TextBox textThirdName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textNationalNUmber;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label lblDateOFbirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.ComboBox cpCountry;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.LinkLabel linSetImage;
        private System.Windows.Forms.LinkLabel linRemove;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

