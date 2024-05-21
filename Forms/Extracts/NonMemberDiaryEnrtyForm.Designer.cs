namespace SMARTMMS.Forms.Extracts
{
    partial class NonMemberDiaryEnrtyForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnSearch = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpEndDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtpStartDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.grdDataDisplay = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(411, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 33);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Data Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(44, 40);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(89, 18);
            this.radLabel2.TabIndex = 20;
            this.radLabel2.Text = "Entry End Period";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(40, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(93, 18);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "Entry Start Period";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(139, 39);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(191, 20);
            this.dtpEndDate.TabIndex = 18;
            this.dtpEndDate.TabStop = false;
            this.dtpEndDate.Text = "Tuesday, April 06, 2021";
            this.dtpEndDate.Value = new System.DateTime(2021, 4, 6, 12, 31, 10, 733);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(139, 13);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(191, 20);
            this.dtpStartDate.TabIndex = 17;
            this.dtpStartDate.TabStop = false;
            this.dtpStartDate.Text = "Tuesday, April 06, 2021";
            this.dtpStartDate.Value = new System.DateTime(2021, 4, 6, 12, 31, 10, 733);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(335, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 54);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(220, 462);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 54);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grdDataDisplay
            // 
            this.grdDataDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDataDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.grdDataDisplay.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdDataDisplay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdDataDisplay.ForeColor = System.Drawing.Color.Black;
            this.grdDataDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdDataDisplay.Location = new System.Drawing.Point(6, 72);
            // 
            // 
            // 
            this.grdDataDisplay.MasterTemplate.AllowAddNewRow = false;
            this.grdDataDisplay.MasterTemplate.AllowColumnReorder = false;
            this.grdDataDisplay.MasterTemplate.AutoExpandGroups = true;
            this.grdDataDisplay.MasterTemplate.AutoGenerateColumns = false;
            this.grdDataDisplay.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumDate;
            gridViewTextBoxColumn1.FieldName = "notes.ReferenceDate";
            gridViewTextBoxColumn1.FormatString = "{0:dd/MMM/yyyy}";
            gridViewTextBoxColumn1.HeaderText = "Reference Date";
            gridViewTextBoxColumn1.Name = "RefDate";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 76;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "notes.Notes";
            gridViewTextBoxColumn2.HeaderText = "Entry";
            gridViewTextBoxColumn2.Name = "MemberNo";
            gridViewTextBoxColumn2.Width = 488;
            gridViewTextBoxColumn2.WrapText = true;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "users.UserName";
            gridViewTextBoxColumn3.HeaderText = "Created By";
            gridViewTextBoxColumn3.Name = "FirstName";
            gridViewTextBoxColumn3.Width = 77;
            this.grdDataDisplay.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "AnniversaryDate";
            sortDescriptor2.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor2.PropertyName = "RefDate";
            this.grdDataDisplay.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2});
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.ReadOnly = true;
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(660, 383);
            this.grdDataDisplay.TabIndex = 14;
            // 
            // NonMemberDiaryEnrtyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 520);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grdDataDisplay);
            this.Name = "NonMemberDiaryEnrtyForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Non-Member Diary Enrties";
            this.Load += new System.EventHandler(this.NonMemberDiaryEnrtyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSearch;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEndDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpStartDate;
        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
    }
}
