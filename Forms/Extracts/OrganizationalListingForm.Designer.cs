namespace SMARTMMS.Forms.Extracts
{
    partial class OrganizationalListingForm
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
            this.btnClose.TabIndex = 8;
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
            this.btnExport.TabIndex = 7;
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
            gridViewTextBoxColumn1.FieldName = "mp.Post.PostName";
            gridViewTextBoxColumn1.HeaderText = "Organizational Post";
            gridViewTextBoxColumn1.Name = "PostName";
            gridViewTextBoxColumn1.Width = 120;
            gridViewTextBoxColumn2.FieldName = "c.CongregationName";
            gridViewTextBoxColumn2.HeaderText = "Congregation";
            gridViewTextBoxColumn2.Name = "Congregation";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 80;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "m.FirstName";
            gridViewTextBoxColumn3.HeaderText = "First Name";
            gridViewTextBoxColumn3.Name = "FirstName";
            gridViewTextBoxColumn3.Width = 103;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "m.LastName";
            gridViewTextBoxColumn4.HeaderText = "Last Name";
            gridViewTextBoxColumn4.Name = "LastName";
            gridViewTextBoxColumn4.Width = 103;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumDate;
            gridViewTextBoxColumn5.FieldName = "mp.StartDate";
            gridViewTextBoxColumn5.FormatString = "{0:dd/MMM/yyyy}";
            gridViewTextBoxColumn5.HeaderText = "Effective Date";
            gridViewTextBoxColumn5.Name = "StartDate";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 120;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumDate;
            gridViewTextBoxColumn6.FieldName = "mp.EndDate";
            gridViewTextBoxColumn6.FormatString = "{0:dd/MMM/yyyy}";
            gridViewTextBoxColumn6.HeaderText = "End Date";
            gridViewTextBoxColumn6.Name = "EndDate";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 118;
            this.grdDataDisplay.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
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
            this.grdDataDisplay.TabIndex = 6;
            // 
            // OrganizationalListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 520);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grdDataDisplay);
            this.Name = "OrganizationalListingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Organizational Listing";
            this.Load += new System.EventHandler(this.OrganizationalListingForm_Load);
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
