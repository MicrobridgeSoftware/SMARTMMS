namespace SMARTMMS.Forms.Extracts
{
    partial class MemberListingForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.grdDataDisplay = new Telerik.WinControls.UI.RadGridView();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            this.grdDataDisplay.Location = new System.Drawing.Point(6, 4);
            // 
            // 
            // 
            this.grdDataDisplay.MasterTemplate.AllowAddNewRow = false;
            this.grdDataDisplay.MasterTemplate.AllowColumnReorder = false;
            this.grdDataDisplay.MasterTemplate.AutoExpandGroups = true;
            this.grdDataDisplay.MasterTemplate.AutoGenerateColumns = false;
            this.grdDataDisplay.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "m.MemberNo";
            gridViewTextBoxColumn1.HeaderText = "Member No";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "MemberNo";
            gridViewTextBoxColumn1.Width = 65;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "m.FirstName";
            gridViewTextBoxColumn2.HeaderText = "First Name";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 44;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "m.LastName";
            gridViewTextBoxColumn3.HeaderText = "Last Name";
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn3.Width = 44;
            gridViewTextBoxColumn4.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumDate;
            gridViewTextBoxColumn4.FieldName = "m.DateOfBirth";
            gridViewTextBoxColumn4.FormatString = "{0:dd/MMM/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Date of Birth";
            gridViewTextBoxColumn4.Name = "DateOfBith";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 43;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.HeaderText = "Age";
            gridViewDecimalColumn1.Name = "Age";
            gridViewDecimalColumn1.Width = 44;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "m.Gender";
            gridViewTextBoxColumn5.HeaderText = "Gender";
            gridViewTextBoxColumn5.Name = "Gender";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 44;
            gridViewTextBoxColumn6.FieldName = "mstat.MaritalStatus1";
            gridViewTextBoxColumn6.HeaderText = "Marital Status";
            gridViewTextBoxColumn6.Name = "MaritalStatus";
            gridViewTextBoxColumn6.Width = 36;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "m.HomePhone";
            gridViewTextBoxColumn7.HeaderText = "Home Phone";
            gridViewTextBoxColumn7.Name = "HomePhone";
            gridViewTextBoxColumn7.Width = 44;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "m.CellPhone";
            gridViewTextBoxColumn8.HeaderText = "Cell Phone";
            gridViewTextBoxColumn8.Name = "CellPhone";
            gridViewTextBoxColumn8.Width = 44;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "m.WorkPhone";
            gridViewTextBoxColumn9.HeaderText = "Work Phone";
            gridViewTextBoxColumn9.Name = "WorkPhone";
            gridViewTextBoxColumn9.Width = 44;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "m.Address1";
            gridViewTextBoxColumn10.HeaderText = "Address Line 1";
            gridViewTextBoxColumn10.Name = "Address1";
            gridViewTextBoxColumn10.Width = 44;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "m.Address2";
            gridViewTextBoxColumn11.HeaderText = "Address Line 2";
            gridViewTextBoxColumn11.Name = "Address2";
            gridViewTextBoxColumn11.Width = 44;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "m.Town";
            gridViewTextBoxColumn12.HeaderText = "City";
            gridViewTextBoxColumn12.Name = "Town";
            gridViewTextBoxColumn12.Width = 43;
            gridViewTextBoxColumn13.FieldName = "z.ZoneName";
            gridViewTextBoxColumn13.HeaderText = "Zone";
            gridViewTextBoxColumn13.Name = "ZoneName";
            gridViewTextBoxColumn13.Width = 43;
            gridViewTextBoxColumn14.FieldName = "c.CongregationName";
            gridViewTextBoxColumn14.HeaderText = "Congregation";
            gridViewTextBoxColumn14.Name = "Congregation";
            gridViewTextBoxColumn14.Width = 32;
            gridViewCheckBoxColumn1.FieldName = "m.IsActive";
            gridViewCheckBoxColumn1.HeaderText = "Active?";
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn1.Width = 59;
            gridViewTextBoxColumn15.FieldName = "ms.ReasonComment";
            gridViewTextBoxColumn15.HeaderText = "Member Status";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "MemberStatus";
            gridViewTextBoxColumn15.Width = 45;
            gridViewTextBoxColumn16.FieldName = "m.EmploymentStatus";
            gridViewTextBoxColumn16.HeaderText = "Employment Status";
            gridViewTextBoxColumn16.Name = "EmploymentStatus";
            gridViewTextBoxColumn16.Width = 30;
            gridViewTextBoxColumn17.FieldName = "m.Occupation";
            gridViewTextBoxColumn17.HeaderText = "Occupation";
            gridViewTextBoxColumn17.Name = "Occupation";
            gridViewTextBoxColumn17.Width = 31;
            this.grdDataDisplay.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17});
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "LastName";
            this.grdDataDisplay.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.ReadOnly = true;
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(660, 450);
            this.grdDataDisplay.TabIndex = 0;
            this.grdDataDisplay.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.grdDataDisplay_ViewCellFormatting);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.Location = new System.Drawing.Point(220, 461);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 54);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(335, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 54);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MemberListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grdDataDisplay);
            this.Name = "MemberListingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Member Listing";
            this.Load += new System.EventHandler(this.MemberListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}
