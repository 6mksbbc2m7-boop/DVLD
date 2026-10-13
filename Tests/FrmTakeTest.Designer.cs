namespace DVLD
{
    partial class FrmTakeTest
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
            this.ctrlScheduledTest1 = new DVLD.ctrlScheduledTest();
            this.label1 = new System.Windows.Forms.Label();
            this.rpPass = new System.Windows.Forms.RadioButton();
            this.rpFail = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.rdFail = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ctrlScheduledTest1
            // 
            this.ctrlScheduledTest1.Location = new System.Drawing.Point(0, 2);
            this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            this.ctrlScheduledTest1.Size = new System.Drawing.Size(339, 440);
            this.ctrlScheduledTest1.TabIndex = 0;
            this.ctrlScheduledTest1.Load += new System.EventHandler(this.ctrlScheduledTest1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result";
            // 
            // rpPass
            // 
            this.rpPass.AutoSize = true;
            this.rpPass.Location = new System.Drawing.Point(150, 445);
            this.rpPass.Name = "rpPass";
            this.rpPass.Size = new System.Drawing.Size(48, 17);
            this.rpPass.TabIndex = 2;
            this.rpPass.TabStop = true;
            this.rpPass.Text = "Pass";
            this.rpPass.UseVisualStyleBackColor = true;
            // 
            // rpFail
            // 
            this.rpFail.AutoSize = true;
            this.rpFail.Location = new System.Drawing.Point(224, 444);
            this.rpFail.Name = "rpFail";
            this.rpFail.Size = new System.Drawing.Size(41, 17);
            this.rpFail.TabIndex = 3;
            this.rpFail.TabStop = true;
            this.rpFail.Text = "Fail";
            this.rpFail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notice";
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(127, 475);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.Size = new System.Drawing.Size(215, 20);
            this.txtNotice.TabIndex = 5;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(174, 503);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(267, 503);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // rdFail
            // 
            this.rdFail.AutoSize = true;
            this.rdFail.Location = new System.Drawing.Point(224, 444);
            this.rdFail.Name = "rdFail";
            this.rdFail.Size = new System.Drawing.Size(41, 17);
            this.rdFail.TabIndex = 3;
            this.rdFail.TabStop = true;
            this.rdFail.Text = "Fail";
            this.rdFail.UseVisualStyleBackColor = true;
            // 
            // FrmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 538);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txtNotice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rpFail);
            this.Controls.Add(this.rpPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlScheduledTest1);
            this.Name = "FrmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.FrmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlScheduledTest ctrlScheduledTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rpPass;
        private System.Windows.Forms.RadioButton rpFail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.RadioButton rdFail;
    }
}