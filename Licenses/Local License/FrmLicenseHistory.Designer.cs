namespace DVLD
{
    partial class FrmLicenseHistory
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
            this.ctrlDriverLicenses1 = new DVLD.ctrlDriverLicenses();
            this.crtPersonCard1 = new DVLD.crtPersonCard();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(2, 452);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(608, 202);
            this.ctrlDriverLicenses1.TabIndex = 1;
            // 
            // crtPersonCard1
            // 
            this.crtPersonCard1.FilterEnabled = true;
            this.crtPersonCard1.Location = new System.Drawing.Point(12, 72);
            this.crtPersonCard1.Name = "crtPersonCard1";
            this.crtPersonCard1.ShowAddPerson = true;
            this.crtPersonCard1.Size = new System.Drawing.Size(761, 355);
            this.crtPersonCard1.TabIndex = 2;
            this.crtPersonCard1.OnPersonSelected += new System.Action<int>(this.crtPersonCard1_OnPersonSelected);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(732, 609);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FrmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(836, 571);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.crtPersonCard1);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.label1);
            this.Name = "FrmLicenseHistory";
            this.Text = "FrmLicenseHistory";
            this.Load += new System.EventHandler(this.FrmLicenseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenses ctrlDriverLicenses1;
        private crtPersonCard crtPersonCard1;
        private System.Windows.Forms.Button btClose;
    }
}