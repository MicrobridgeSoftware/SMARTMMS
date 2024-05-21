namespace SMARTMMS.Forms.Maintenance
{
    partial class SkillTypeForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.grdData = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.chkActive = new Telerik.WinControls.UI.RadCheckBox();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.bindingNavigatorControl1 = new MBridge.Common.Presentation.Controls.BindingNavigatorControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(191, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 45);
            this.btnExit.TabIndex = 11;
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
            this.grdData.Location = new System.Drawing.Point(17, 179);
            // 
            // 
            // 
            this.grdData.MasterTemplate.AllowAddNewRow = false;
            this.grdData.MasterTemplate.AllowColumnReorder = false;
            this.grdData.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn2.DataType = typeof(short);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "SkillTypeId";
            gridViewDecimalColumn2.HeaderText = "SkillTypeId";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "SkillTypeId";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "SkillTypeName";
            gridViewTextBoxColumn2.HeaderText = "Skill Type Description";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "SkillTypeName";
            gridViewTextBoxColumn2.Width = 116;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "IsActive";
            gridViewCheckBoxColumn2.HeaderText = "Active";
            gridViewCheckBoxColumn2.IsAutoGenerated = true;
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "IsActive";
            this.grdData.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn2,
            gridViewCheckBoxColumn2});
            this.grdData.MasterTemplate.DataSource = this.bindingSource;
            this.grdData.MasterTemplate.EnableFiltering = true;
            this.grdData.MasterTemplate.EnableGrouping = false;
            sortDescriptor2.PropertyName = "PostName";
            this.grdData.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.grdData.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdData.Size = new System.Drawing.Size(466, 245);
            this.grdData.TabIndex = 10;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.chkActive);
            this.radGroupBox1.Controls.Add(this.txtDescription);
            this.radGroupBox1.HeaderText = "Skill Type Information";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 46);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(468, 127);
            this.radGroupBox1.TabIndex = 9;
            this.radGroupBox1.Text = "Skill Type Information";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(19, 41);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Description";
            // 
            // chkActive
            // 
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("IsChecked", this.bindingSource, "IsActive", true));
            this.chkActive.Enabled = false;
            this.chkActive.Location = new System.Drawing.Point(96, 80);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(51, 18);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Active";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "SkillTypeName", true));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(96, 41);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // bindingNavigatorControl1
            // 
            this.bindingNavigatorControl1.BindingSouce = this.bindingSource;
            this.bindingNavigatorControl1.Location = new System.Drawing.Point(17, 10);
            this.bindingNavigatorControl1.Name = "bindingNavigatorControl1";
            this.bindingNavigatorControl1.Savable = null;
            this.bindingNavigatorControl1.Size = new System.Drawing.Size(466, 29);
            this.bindingNavigatorControl1.TabIndex = 8;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Mbridge.SMARTMMS.Persistence.SkillType);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.bindingSource;
            // 
            // SkillTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 488);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.bindingNavigatorControl1);
            this.Name = "SkillTypeForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Skill Type Maintenance";
            this.Load += new System.EventHandler(this.SkillTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadGridView grdData;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox chkActive;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private MBridge.Common.Presentation.Controls.BindingNavigatorControl bindingNavigatorControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
