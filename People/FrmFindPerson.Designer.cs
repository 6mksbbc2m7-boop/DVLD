namespace DVLD
{
    partial class FrmFindPerson
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
            this.crtPersonCard1 = new DVLD.crtPersonCard();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtPersonCard1
            // 
            this.crtPersonCard1.FilterEnabled = true;
            this.crtPersonCard1.Location = new System.Drawing.Point(12, 47);
            this.crtPersonCard1.Name = "crtPersonCard1";
            this.crtPersonCard1.ShowAddPerson = true;
            this.crtPersonCard1.Size = new System.Drawing.Size(761, 393);
            this.crtPersonCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(290, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Person";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(676, 446);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FrmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crtPersonCard1);
            this.Name = "FrmFindPerson";
            this.Text = "FrmFindPerson";
            this.Load += new System.EventHandler(this.FrmFindPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private crtPersonCard crtPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
    }
}