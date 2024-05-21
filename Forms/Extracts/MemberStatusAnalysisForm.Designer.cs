namespace SMARTMMS.Forms.Extracts
{
    partial class MemberStatusAnalysisForm
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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.radChartView = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radChartView
            // 
            this.radChartView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radChartView.AreaDesign = cartesianArea2;
            this.radChartView.LegendTitle = "Member Status";
            this.radChartView.Location = new System.Drawing.Point(2, 3);
            this.radChartView.Name = "radChartView";
            this.radChartView.ShowGrid = false;
            this.radChartView.ShowLegend = true;
            this.radChartView.Size = new System.Drawing.Size(705, 446);
            this.radChartView.TabIndex = 2;
            // 
            // MemberStatusAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 452);
            this.Controls.Add(this.radChartView);
            this.Name = "MemberStatusAnalysisForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Member Status Analysis";
            this.Load += new System.EventHandler(this.MemberStatusAnalysisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView radChartView;
    }
}
