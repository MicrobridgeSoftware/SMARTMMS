namespace SMARTMMS.Forms.Popup_Dialogs
{
    partial class FrmDisfellowship
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
            this.btnReAdmit = new Telerik.WinControls.UI.RadButton();
            this.dtpEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.ddlReason = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnReAdmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReAdmit
            // 
            this.btnReAdmit.Image = global::SMARTMMS.Properties.Resources.check;
            this.btnReAdmit.Location = new System.Drawing.Point(169, 111);
            this.btnReAdmit.Name = "btnReAdmit";
            this.btnReAdmit.Size = new System.Drawing.Size(110, 32);
            this.btnReAdmit.TabIndex = 9;
            this.btnReAdmit.Text = "Dismember";
            this.btnReAdmit.Click += new System.EventHandler(this.btnReAdmit_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(109, 73);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(172, 20);
            this.dtpEnd.TabIndex = 8;
            this.dtpEnd.TabStop = false;
            this.dtpEnd.Text = "Monday, April 05, 2021";
            this.dtpEnd.Value = new System.DateTime(2021, 4, 5, 11, 11, 10, 986);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 74);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(90, 18);
            this.radLabel2.TabIndex = 7;
            this.radLabel2.Text = "Date Terminated";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(21, 17);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 18);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Member Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 16);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(267, 20);
            this.txtName.TabIndex = 5;
            // 
            // ddlReason
            // 
            this.ddlReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlReason.DataSource = this.bindingSource;
            this.ddlReason.DisplayMember = "ReasonComment";
            this.ddlReason.Location = new System.Drawing.Point(109, 45);
            this.ddlReason.Name = "ddlReason";
            this.ddlReason.Size = new System.Drawing.Size(267, 20);
            this.ddlReason.TabIndex = 10;
            this.ddlReason.ValueMember = "DisFellowshipReasonsId";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(61, 45);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(42, 18);
            this.radLabel3.TabIndex = 11;
            this.radLabel3.Text = "Reason";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Mbridge.SMARTMMS.Persistence.DisFellowshipReasons);
            // 
            // FrmDisfellowship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 161);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.ddlReason);
            this.Controls.Add(this.btnReAdmit);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisfellowship";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Disfellowship Member";
            this.Load += new System.EventHandler(this.FrmDisfellowship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnReAdmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnReAdmit;
        private Telerik.WinControls.UI.RadDateTimePicker dtpEnd;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadDropDownList ddlReason;
        private System.Windows.Forms.BindingSource bindingSource;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
