namespace SMARTMMS.Forms
{
    partial class MainForm
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
            this.radStatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.bgwTheme = new System.ComponentModel.BackgroundWorker();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip
            // 
            this.radStatusStrip.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1});
            this.radStatusStrip.Location = new System.Drawing.Point(0, 521);
            this.radStatusStrip.Name = "radStatusStrip";
            this.radStatusStrip.Size = new System.Drawing.Size(1034, 26);
            this.radStatusStrip.TabIndex = 1;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radLabelElement1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.radStatusStrip.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "Application UI Styling: ";
            this.radLabelElement1.TextWrap = true;
            // 
            // bgwTheme
            // 
            this.bgwTheme.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTheme_DoWork);
            this.bgwTheme.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTheme_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMARTMMS.Properties.Resources.Websiteicons1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1034, 547);
            this.Controls.Add(this.radStatusStrip);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "SMART Member Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.radStatusStrip, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private System.ComponentModel.BackgroundWorker bgwTheme;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
    }
}
