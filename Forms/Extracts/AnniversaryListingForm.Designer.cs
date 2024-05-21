namespace SMARTMMS.Forms.Extracts
{
    partial class AnniversaryListingForm
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnExport = new Telerik.WinControls.UI.RadButton();
            this.grdDataDisplay = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(335, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 54);
            this.btnClose.TabIndex = 5;
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
            this.btnExport.TabIndex = 4;
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
            this.grdDataDisplay.Location = new System.Drawing.Point(6, 5);
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
            gridViewTextBoxColumn1.Width = 92;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "m.FirstName";
            gridViewTextBoxColumn2.HeaderText = "First Name";
            gridViewTextBoxColumn2.Name = "FirstName";
            gridViewTextBoxColumn2.Width = 67;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "m.LastName";
            gridViewTextBoxColumn3.HeaderText = "Last Name";
            gridViewTextBoxColumn3.Name = "LastName";
            gridViewTextBoxColumn3.Width = 67;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "m.Gender";
            gridViewTextBoxColumn4.HeaderText = "Gender";
            gridViewTextBoxColumn4.Name = "Gender";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 40;
            gridViewTextBoxColumn5.FieldName = "m.Address1";
            gridViewTextBoxColumn5.HeaderText = "Address Line 1";
            gridViewTextBoxColumn5.Name = "Address1";
            gridViewTextBoxColumn5.Width = 67;
            gridViewTextBoxColumn6.FieldName = "m.Address2";
            gridViewTextBoxColumn6.HeaderText = "Address Line 2";
            gridViewTextBoxColumn6.Name = "Address2";
            gridViewTextBoxColumn6.Width = 67;
            gridViewTextBoxColumn7.FieldName = "m.Town";
            gridViewTextBoxColumn7.HeaderText = "City";
            gridViewTextBoxColumn7.Name = "Town";
            gridViewTextBoxColumn7.Width = 56;
            gridViewTextBoxColumn8.FieldName = "m.HomePhone";
            gridViewTextBoxColumn8.HeaderText = "Home Phone";
            gridViewTextBoxColumn8.Name = "HomePhone";
            gridViewTextBoxColumn8.Width = 46;
            gridViewTextBoxColumn9.FieldName = "m.CellPhone";
            gridViewTextBoxColumn9.HeaderText = "Cell Phone";
            gridViewTextBoxColumn9.Name = "CellPhone";
            gridViewTextBoxColumn9.Width = 46;
            gridViewTextBoxColumn10.FieldName = "m.WorkPhone";
            gridViewTextBoxColumn10.HeaderText = "Work Phone";
            gridViewTextBoxColumn10.Name = "WorkPhone";
            gridViewTextBoxColumn10.Width = 46;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumDate;
            gridViewTextBoxColumn11.FieldName = "a.AnniversaryDate";
            gridViewTextBoxColumn11.FormatString = "{0:dd/MMM/yyyy}";
            gridViewTextBoxColumn11.HeaderText = "Anniversary Date";
            gridViewTextBoxColumn11.Name = "AnniversaryDate";
            gridViewTextBoxColumn11.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn11.Width = 48;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "at.AnniversaryTypeName";
            gridViewTextBoxColumn12.HeaderText = "Anniversary Type";
            gridViewTextBoxColumn12.Name = "AnniversaryTypeName";
            gridViewTextBoxColumn12.Width = 52;
            gridViewCheckBoxColumn1.FieldName = "a.IsActive";
            gridViewCheckBoxColumn1.HeaderText = "Active?";
            gridViewCheckBoxColumn1.IsVisible = false;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCheckBoxColumn1.Width = 87;
            gridViewTextBoxColumn13.FieldName = "a.MonthName";
            gridViewTextBoxColumn13.HeaderText = "Anniversary Month";
            gridViewTextBoxColumn13.Name = "MonthName";
            gridViewTextBoxColumn13.ReadOnly = true;
            gridViewTextBoxColumn13.Width = 48;
            this.grdDataDisplay.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn13});
            this.grdDataDisplay.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "AnniversaryDate";
            this.grdDataDisplay.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.grdDataDisplay.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdDataDisplay.Name = "grdDataDisplay";
            this.grdDataDisplay.ReadOnly = true;
            this.grdDataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdDataDisplay.Size = new System.Drawing.Size(660, 450);
            this.grdDataDisplay.TabIndex = 3;
            this.grdDataDisplay.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.grdDataDisplay_ViewCellFormatting);
            // 
            // AnniversaryListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grdDataDisplay);
            this.Name = "AnniversaryListingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Anniversary Listing";
            this.Load += new System.EventHandler(this.AnniversaryListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnClose;
        private Telerik.WinControls.UI.RadButton btnExport;
        private Telerik.WinControls.UI.RadGridView grdDataDisplay;
    }
}
