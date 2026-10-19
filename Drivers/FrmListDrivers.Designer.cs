namespace DVLD
{
    partial class FrmListDrivers
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilter = new System.Windows.Forms.TextBox();
            this.dgListDrivers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonHistoryLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(351, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Drivers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(110, 86);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Location = new System.Drawing.Point(259, 87);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(100, 20);
            this.TxtFilter.TabIndex = 3;
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            this.TxtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFilter_KeyPress);
            // 
            // dgListDrivers
            // 
            this.dgListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListDrivers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgListDrivers.Location = new System.Drawing.Point(0, 113);
            this.dgListDrivers.Name = "dgListDrivers";
            this.dgListDrivers.Size = new System.Drawing.Size(801, 297);
            this.dgListDrivers.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showPersonHistoryLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 70);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showPersonHistoryLicenseToolStripMenuItem
            // 
            this.showPersonHistoryLicenseToolStripMenuItem.Name = "showPersonHistoryLicenseToolStripMenuItem";
            this.showPersonHistoryLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonHistoryLicenseToolStripMenuItem.Text = "Show Person History License";
            this.showPersonHistoryLicenseToolStripMenuItem.Click += new System.EventHandler(this.showPersonHistoryLicenseToolStripMenuItem_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(713, 416);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Clsoe";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FrmListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.dgListDrivers);
            this.Controls.Add(this.TxtFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Name = "FrmListDrivers";
            this.Text = "List Drivers";
            this.Load += new System.EventHandler(this.FrmListDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFilter;
        private System.Windows.Forms.DataGridView dgListDrivers;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryLicenseToolStripMenuItem;
    }
}