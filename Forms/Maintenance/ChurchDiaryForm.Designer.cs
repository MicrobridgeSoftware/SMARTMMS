namespace SMARTMMS.Forms.Maintenance
{
    partial class ChurchDiaryForm
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlMember = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtEntry = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.chkEntryType = new Telerik.WinControls.UI.RadCheckBox();
            this.bindingSourceMember = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEntryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.chkEntryType);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.txtEntry);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.dtpDate);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.ddlMember);
            this.radGroupBox1.HeaderText = "Log Entry";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(475, 165);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Log Entry";
            // 
            // ddlMember
            // 
            this.ddlMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlMember.DataSource = this.bindingSourceMember;
            this.ddlMember.DisplayMember = "memberName";
            this.ddlMember.Enabled = false;
            this.ddlMember.Location = new System.Drawing.Point(119, 40);
            this.ddlMember.Name = "ddlMember";
            this.ddlMember.Size = new System.Drawing.Size(226, 20);
            this.ddlMember.TabIndex = 0;
            this.ddlMember.ValueMember = "memberId";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(22, 40);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(91, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Relative Member";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(119, 67);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(226, 20);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "Thursday, April 22, 2021";
            this.dtpDate.Value = new System.DateTime(2021, 4, 22, 16, 50, 25, 765);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(31, 68);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(82, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Reference Date";
            // 
            // txtEntry
            // 
            this.txtEntry.AcceptsReturn = true;
            this.txtEntry.Location = new System.Drawing.Point(119, 94);
            this.txtEntry.Multiline = true;
            this.txtEntry.Name = "txtEntry";
            // 
            // 
            // 
            this.txtEntry.RootElement.StretchVertically = true;
            this.txtEntry.Size = new System.Drawing.Size(339, 62);
            this.txtEntry.TabIndex = 4;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(45, 116);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(68, 18);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Entry Details";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(252, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 54);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(137, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 54);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkEntryType
            // 
            this.chkEntryType.Location = new System.Drawing.Point(119, 15);
            this.chkEntryType.Name = "chkEntryType";
            this.chkEntryType.Size = new System.Drawing.Size(137, 18);
            this.chkEntryType.TabIndex = 6;
            this.chkEntryType.Text = "Member Related Entry?";
            this.chkEntryType.CheckStateChanged += new System.EventHandler(this.chkEntryType_CheckStateChanged);
            // 
            // bindingSourceMember
            // 
            this.bindingSourceMember.DataSource = typeof(SMARTMMS.Util.MemberDefinition);
            // 
            // ChurchDiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 263);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChurchDiaryForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Church Diary/Logger";
            this.Load += new System.EventHandler(this.ChurchDiaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEntryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtEntry;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList ddlMember;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadCheckBox chkEntryType;
        private System.Windows.Forms.BindingSource bindingSourceMember;
    }
}
