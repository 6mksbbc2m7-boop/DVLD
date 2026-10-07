namespace DVLD
{
    partial class crtPersonCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiterBox = new System.Windows.Forms.ComboBox();
            this.txtFiterValue = new System.Windows.Forms.TextBox();
            this.btSersh = new System.Windows.Forms.Button();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD.ctrlPersonCard();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbFiterBox
            // 
            this.cbFiterBox.FormattingEnabled = true;
            this.cbFiterBox.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFiterBox.Location = new System.Drawing.Point(88, 33);
            this.cbFiterBox.Name = "cbFiterBox";
            this.cbFiterBox.Size = new System.Drawing.Size(121, 21);
            this.cbFiterBox.TabIndex = 2;
            this.cbFiterBox.SelectedIndexChanged += new System.EventHandler(this.cbFiterBox_SelectedIndexChanged);
            // 
            // txtFiterValue
            // 
            this.txtFiterValue.Location = new System.Drawing.Point(215, 34);
            this.txtFiterValue.Name = "txtFiterValue";
            this.txtFiterValue.Size = new System.Drawing.Size(251, 20);
            this.txtFiterValue.TabIndex = 3;
            this.txtFiterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiterValue_KeyPress);
            this.txtFiterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFiterValue_Validating);
            // 
            // btSersh
            // 
            this.btSersh.Location = new System.Drawing.Point(485, 34);
            this.btSersh.Name = "btSersh";
            this.btSersh.Size = new System.Drawing.Size(75, 23);
            this.btSersh.TabIndex = 4;
            this.btSersh.Text = "Sersh";
            this.btSersh.UseVisualStyleBackColor = true;
            this.btSersh.Click += new System.EventHandler(this.btSersh_Click);
            // 
            // btAddPerson
            // 
            this.btAddPerson.Location = new System.Drawing.Point(566, 34);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btAddPerson.TabIndex = 5;
            this.btAddPerson.Text = "Add Person";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.btSersh);
            this.gbFilter.Controls.Add(this.btAddPerson);
            this.gbFilter.Controls.Add(this.cbFiterBox);
            this.gbFilter.Controls.Add(this.txtFiterValue);
            this.gbFilter.Location = new System.Drawing.Point(3, 18);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(664, 77);
            this.gbFilter.TabIndex = 6;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 101);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(758, 283);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // crtPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "crtPersonCard";
            this.Size = new System.Drawing.Size(761, 393);
            this.Load += new System.EventHandler(this.crtPersonCard_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiterBox;
        private System.Windows.Forms.TextBox txtFiterValue;
        private System.Windows.Forms.Button btSersh;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
