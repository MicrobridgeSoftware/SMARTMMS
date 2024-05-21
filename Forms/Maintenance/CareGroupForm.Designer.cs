namespace SMARTMMS.Forms.Maintenance
{
    partial class CareGroupForm
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.grdData = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.chkActive = new Telerik.WinControls.UI.RadCheckBox();
            this.txtGroup = new Telerik.WinControls.UI.RadTextBox();
            this.bindingNavigatorControl1 = new MBridge.Common.Presentation.Controls.BindingNavigatorControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ddlLeader = new Telerik.WinControls.UI.RadDropDownList();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceMember = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Location = new System.Drawing.Point(191, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 45);
            this.btnExit.TabIndex = 7;
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
            this.grdData.Location = new System.Drawing.Point(17, 197);
            // 
            // 
            // 
            this.grdData.MasterTemplate.AllowAddNewRow = false;
            this.grdData.MasterTemplate.AllowColumnReorder = false;
            this.grdData.MasterTemplate.AutoGenerateColumns = false;
            gridViewDecimalColumn1.DataType = typeof(short);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "CareGroupId";
            gridViewDecimalColumn1.HeaderText = "CareGroupId";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "CareGroupId";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CareGroupName";
            gridViewTextBoxColumn1.HeaderText = "Care Group Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CareGroupName";
            gridViewTextBoxColumn1.Width = 91;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "Active";
            gridViewCheckBoxColumn1.IsAutoGenerated = true;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "IsActive";
            this.grdData.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewCheckBoxColumn1});
            this.grdData.MasterTemplate.DataSource = this.bindingSource;
            this.grdData.MasterTemplate.EnableFiltering = true;
            this.grdData.MasterTemplate.EnableGrouping = false;
            this.grdData.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdData.Size = new System.Drawing.Size(465, 225);
            this.grdData.TabIndex = 6;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.ddlLeader);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.chkActive);
            this.radGroupBox1.Controls.Add(this.txtGroup);
            this.radGroupBox1.HeaderText = "Care Group Information";
            this.radGroupBox1.Location = new System.Drawing.Point(15, 44);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(467, 147);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Care Group Information";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(45, 72);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(45, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Lead By";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(19, 34);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Group Name";
            // 
            // chkActive
            // 
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("IsChecked", this.bindingSource, "IsActive", true));
            this.chkActive.Enabled = false;
            this.chkActive.Location = new System.Drawing.Point(96, 110);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(51, 18);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Active";
            // 
            // txtGroup
            // 
            this.txtGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "CareGroupName", true));
            this.txtGroup.Enabled = false;
            this.txtGroup.Location = new System.Drawing.Point(96, 33);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(173, 20);
            this.txtGroup.TabIndex = 0;
            // 
            // bindingNavigatorControl1
            // 
            this.bindingNavigatorControl1.BindingSouce = this.bindingSource;
            this.bindingNavigatorControl1.Location = new System.Drawing.Point(17, 8);
            this.bindingNavigatorControl1.Name = "bindingNavigatorControl1";
            this.bindingNavigatorControl1.Savable = null;
            this.bindingNavigatorControl1.Size = new System.Drawing.Size(466, 29);
            this.bindingNavigatorControl1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.bindingSource;
            // 
            // ddlLeader
            // 
            this.ddlLeader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlLeader.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "LeadMemberId", true));
            this.ddlLeader.DataSource = this.bindingSourceMember;
            this.ddlLeader.DisplayMember = "memberName";
            this.ddlLeader.Enabled = false;
            this.ddlLeader.Location = new System.Drawing.Point(96, 72);
            this.ddlLeader.Name = "ddlLeader";
            this.ddlLeader.Size = new System.Drawing.Size(266, 20);
            this.ddlLeader.TabIndex = 4;
            this.ddlLeader.ValueMember = "memberId";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Mbridge.SMARTMMS.Persistence.CareGroup);
            // 
            // bindingSourceMember
            // 
            this.bindingSourceMember.DataSource = typeof(SMARTMMS.Util.MemberDefinition);
            // 
            // CareGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 488);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.bindingNavigatorControl1);
            this.Name = "CareGroupForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Care Group Maintenance";
            this.Load += new System.EventHandler(this.CareGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadGridView grdData;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox chkActive;
        private Telerik.WinControls.UI.RadTextBox txtGroup;
        private MBridge.Common.Presentation.Controls.BindingNavigatorControl bindingNavigatorControl1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.UI.RadDropDownList ddlLeader;
        private System.Windows.Forms.BindingSource bindingSourceMember;
    }
}
