namespace DVLD
{
    partial class FrmAddUpdateUsers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.tbLoginInfo = new System.Windows.Forms.TabPage();
            this.crtPersonCard1 = new DVLD.crtPersonCard();
            this.btNext = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.rdtIsActive = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPersonInfo);
            this.tabControl1.Controls.Add(this.tbLoginInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.btNext);
            this.tbPersonInfo.Controls.Add(this.crtPersonCard1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 24);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(1016, 417);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Personal Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tbLoginInfo
            // 
            this.tbLoginInfo.Controls.Add(this.rdtIsActive);
            this.tbLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tbLoginInfo.Controls.Add(this.txPassword);
            this.tbLoginInfo.Controls.Add(this.txUserName);
            this.tbLoginInfo.Controls.Add(this.lbUserID);
            this.tbLoginInfo.Controls.Add(this.label4);
            this.tbLoginInfo.Controls.Add(this.label3);
            this.tbLoginInfo.Controls.Add(this.label2);
            this.tbLoginInfo.Controls.Add(this.label1);
            this.tbLoginInfo.Location = new System.Drawing.Point(4, 24);
            this.tbLoginInfo.Name = "tbLoginInfo";
            this.tbLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLoginInfo.Size = new System.Drawing.Size(1016, 417);
            this.tbLoginInfo.TabIndex = 1;
            this.tbLoginInfo.Text = "Login Info";
            this.tbLoginInfo.UseVisualStyleBackColor = true;
            // 
            // crtPersonCard1
            // 
            this.crtPersonCard1.FilterEnabled = true;
            this.crtPersonCard1.Location = new System.Drawing.Point(0, 0);
            this.crtPersonCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crtPersonCard1.Name = "crtPersonCard1";
            this.crtPersonCard1.ShowAddPerson = true;
            this.crtPersonCard1.Size = new System.Drawing.Size(1241, 516);
            this.crtPersonCard1.TabIndex = 0;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(935, 391);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(944, 525);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(853, 525);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(171, 47);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(28, 15);
            this.lbUserID.TabIndex = 4;
            this.lbUserID.Text = "???";
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(174, 79);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(100, 21);
            this.txUserName.TabIndex = 5;
            this.txUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txUserName_Validating);
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(174, 115);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(100, 21);
            this.txPassword.TabIndex = 6;
            this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txPassword_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(174, 152);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 21);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txConfirmPassword_TextChanged);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(407, 36);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(143, 25);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Add New User";
            // 
            // rdtIsActive
            // 
            this.rdtIsActive.AutoSize = true;
            this.rdtIsActive.Location = new System.Drawing.Point(174, 197);
            this.rdtIsActive.Name = "rdtIsActive";
            this.rdtIsActive.Size = new System.Drawing.Size(68, 19);
            this.rdtIsActive.TabIndex = 8;
            this.rdtIsActive.TabStop = true;
            this.rdtIsActive.Text = "Is Active";
            this.rdtIsActive.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddUpdateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 569);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAddUpdateUsers";
            this.Text = "FrmAddUpdateUsers";
            this.Activated += new System.EventHandler(this.FrmAddUpdateUsers_Activated);
            this.Load += new System.EventHandler(this.FrmAddUpdateUsers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbLoginInfo.ResumeLayout(false);
            this.tbLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private crtPersonCard crtPersonCard1;
        private System.Windows.Forms.TabPage tbLoginInfo;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RadioButton rdtIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}