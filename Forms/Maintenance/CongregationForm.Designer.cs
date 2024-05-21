namespace SMARTMMS.Forms.Maintenance
{
    partial class CongregationForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.grdData = new Telerik.WinControls.UI.RadGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtCity = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddress2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddress1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.bindingNavigatorControl1 = new MBridge.Common.Presentation.Controls.BindingNavigatorControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(189, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 45);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.grdData.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdData.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdData.ForeColor = System.Drawing.Color.Black;
            this.grdData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdData.Location = new System.Drawing.Point(17, 207);
            // 
            // 
            // 
            this.grdData.MasterTemplate.AllowAddNewRow = false;
            this.grdData.MasterTemplate.AllowColumnReorder = false;
            this.grdData.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(short);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "CongregationId";
            gridViewDecimalColumn1.HeaderText = "SkillId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "CongregationId";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CongregationName";
            gridViewTextBoxColumn1.HeaderText = "Congregation Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CongregationName";
            gridViewTextBoxColumn1.Width = 91;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "AddressLine1";
            gridViewTextBoxColumn2.HeaderText = "Address Line 1";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "AddressLine1";
            gridViewTextBoxColumn2.Width = 116;
            gridViewTextBoxColumn3.FieldName = "AddressLine2";
            gridViewTextBoxColumn3.HeaderText = "Address Line 2";
            gridViewTextBoxColumn3.Name = "AddressLine2";
            gridViewTextBoxColumn3.Width = 116;
            gridViewTextBoxColumn4.FieldName = "City";
            gridViewTextBoxColumn4.HeaderText = "City";
            gridViewTextBoxColumn4.Name = "City";
            this.grdData.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.grdData.MasterTemplate.DataSource = this.bindingSource;
            this.grdData.MasterTemplate.EnableFiltering = true;
            this.grdData.MasterTemplate.EnableGrouping = false;
            this.grdData.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdData.Size = new System.Drawing.Size(462, 202);
            this.grdData.TabIndex = 14;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Mbridge.SMARTMMS.Persistence.Congregation);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.txtCity);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.txtAddress2);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.txtAddress1);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.txtName);
            this.radGroupBox1.HeaderText = "Congregation Information";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 46);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(464, 155);
            this.radGroupBox1.TabIndex = 13;
            this.radGroupBox1.Text = "Congregation Information";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(102, 112);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(25, 18);
            this.radLabel6.TabIndex = 11;
            this.radLabel6.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "City", true));
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(134, 111);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(269, 20);
            this.txtCity.TabIndex = 10;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(48, 84);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(79, 18);
            this.radLabel5.TabIndex = 9;
            this.radLabel5.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AddressLine2", true));
            this.txtAddress2.Enabled = false;
            this.txtAddress2.Location = new System.Drawing.Point(134, 83);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(269, 20);
            this.txtAddress2.TabIndex = 8;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(48, 55);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(79, 18);
            this.radLabel4.TabIndex = 7;
            this.radLabel4.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AddressLine1", true));
            this.txtAddress1.Enabled = false;
            this.txtAddress1.Location = new System.Drawing.Point(134, 54);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(269, 20);
            this.txtAddress1.TabIndex = 6;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(19, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(108, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Congregation Name";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "CongregationName", true));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(134, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 0;
            // 
            // bindingNavigatorControl1
            // 
            this.bindingNavigatorControl1.BindingSouce = this.bindingSource;
            this.bindingNavigatorControl1.Location = new System.Drawing.Point(17, 10);
            this.bindingNavigatorControl1.Name = "bindingNavigatorControl1";
            this.bindingNavigatorControl1.Savable = null;
            this.bindingNavigatorControl1.Size = new System.Drawing.Size(466, 29);
            this.bindingNavigatorControl1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.bindingSource;
            // 
            // CongregationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 473);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.bindingNavigatorControl1);
            this.Name = "CongregationForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Congregation Maintenance";
            this.Load += new System.EventHandler(this.CongregationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadGridView grdData;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private MBridge.Common.Presentation.Controls.BindingNavigatorControl bindingNavigatorControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txtCity;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtAddress2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtAddress1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
