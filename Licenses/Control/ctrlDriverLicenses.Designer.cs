namespace DVLD
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tbDriverLicenses = new System.Windows.Forms.TabControl();
            this.tbLocal = new System.Windows.Forms.TabPage();
            this.dgLicenses = new System.Windows.Forms.DataGridView();
            this.tbInternational = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDriverLicenses.SuspendLayout();
            this.tbDriverLicenses.SuspendLayout();
            this.tbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tbDriverLicenses);
            this.gbDriverLicenses.Location = new System.Drawing.Point(3, 3);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(609, 216);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            this.gbDriverLicenses.Enter += new System.EventHandler(this.gbDriverLicenses_Enter);
            // 
            // tbDriverLicenses
            // 
            this.tbDriverLicenses.Controls.Add(this.tbLocal);
            this.tbDriverLicenses.Controls.Add(this.tbInternational);
            this.tbDriverLicenses.Location = new System.Drawing.Point(6, 19);
            this.tbDriverLicenses.Name = "tbDriverLicenses";
            this.tbDriverLicenses.SelectedIndex = 0;
            this.tbDriverLicenses.Size = new System.Drawing.Size(606, 191);
            this.tbDriverLicenses.TabIndex = 0;
            // 
            // tbLocal
            // 
            this.tbLocal.Controls.Add(this.dgLicenses);
            this.tbLocal.Location = new System.Drawing.Point(4, 22);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbLocal.Size = new System.Drawing.Size(598, 165);
            this.tbLocal.TabIndex = 0;
            this.tbLocal.Text = "Local";
            this.tbLocal.UseVisualStyleBackColor = true;
            // 
            // dgLicenses
            // 
            this.dgLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLicenses.Location = new System.Drawing.Point(0, 6);
            this.dgLicenses.Name = "dgLicenses";
            this.dgLicenses.Size = new System.Drawing.Size(595, 150);
            this.dgLicenses.TabIndex = 0;
            // 
            // tbInternational
            // 
            this.tbInternational.Location = new System.Drawing.Point(4, 22);
            this.tbInternational.Name = "tbInternational";
            this.tbInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternational.Size = new System.Drawing.Size(598, 165);
            this.tbInternational.TabIndex = 1;
            this.tbInternational.Text = "International";
            this.tbInternational.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(615, 219);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tbDriverLicenses.ResumeLayout(false);
            this.tbLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tbDriverLicenses;
        private System.Windows.Forms.TabPage tbLocal;
        private System.Windows.Forms.DataGridView dgLicenses;
        private System.Windows.Forms.TabPage tbInternational;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
