namespace SMARTMMS.Forms.Popup_Dialogs
{
    partial class FrmAdmit
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
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dtpJoin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnReAdmit = new Telerik.WinControls.UI.RadButton();
            this.ddlStatus = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.bindingSourceStatus = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReAdmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 22);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(267, 20);
            this.txtName.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Member Name";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(17, 77);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(77, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Date Rejoined";
            // 
            // dtpJoin
            // 
            this.dtpJoin.Location = new System.Drawing.Point(100, 76);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(172, 20);
            this.dtpJoin.TabIndex = 3;
            this.dtpJoin.TabStop = false;
            this.dtpJoin.Text = "Monday, April 05, 2021";
            this.dtpJoin.Value = new System.DateTime(2021, 4, 5, 11, 11, 10, 986);
            // 
            // btnReAdmit
            // 
            this.btnReAdmit.Image = global::SMARTMMS.Properties.Resources.check;
            this.btnReAdmit.Location = new System.Drawing.Point(150, 110);
            this.btnReAdmit.Name = "btnReAdmit";
            this.btnReAdmit.Size = new System.Drawing.Size(110, 32);
            this.btnReAdmit.TabIndex = 4;
            this.btnReAdmit.Text = "Re-Admit";
            this.btnReAdmit.Click += new System.EventHandler(this.btnReAdmit_Click);
            // 
            // ddlStatus
            // 
            this.ddlStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlStatus.DataSource = this.bindingSourceStatus;
            this.ddlStatus.DisplayMember = "ReasonComment";
            this.ddlStatus.Location = new System.Drawing.Point(100, 49);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(172, 20);
            this.ddlStatus.TabIndex = 5;
            this.ddlStatus.ValueMember = "DisFellowshipReasonsId";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(57, 49);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(37, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Status";
            // 
            // bindingSourceStatus
            // 
            this.bindingSourceStatus.DataSource = typeof(Mbridge.SMARTMMS.Persistence.DisFellowshipReasons);
            // 
            // FrmAdmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 149);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.btnReAdmit);
            this.Controls.Add(this.dtpJoin);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmit";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Re-Admit Member";
            this.Load += new System.EventHandler(this.FrmAdmit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReAdmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker dtpJoin;
        private Telerik.WinControls.UI.RadButton btnReAdmit;
        private Telerik.WinControls.UI.RadDropDownList ddlStatus;
        private System.Windows.Forms.BindingSource bindingSourceStatus;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
