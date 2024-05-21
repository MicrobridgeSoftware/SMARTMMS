using Mbridge.SMARTMMS.Persistence;
using SMARTMMS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace SMARTMMS.Forms.Extracts
{
    public partial class TurnOverReportForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<TurnoverDefinition> reportDataSource;
        List<MemberMovement> memberMovements;
        List<MemberMovement> memberMovement2;
        List<Congregation> congregationsList;
        List<DisFellowshipReasons> reasons;

        public TurnOverReportForm()
        {
            InitializeComponent();
        }

        private void TurnOverReportForm_Load(object sender, EventArgs e)
        {
            dtpStartDate.MaxDate = DateTime.Today.Date;
            dtpStartDate.Value = DateTime.Today.Date;

            grdDataDisplay.MasterTemplate.ShowTotals = true;

            GroupDescriptor groupDescriptor = new GroupDescriptor();
            groupDescriptor.GroupNames.Add("ReportGroupField", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(groupDescriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();

            GridViewSummaryItem summaryItem = new GridViewSummaryItem("MemberNo", "Total: {0:N0}", GridAggregateFunction.Count);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);
            this.grdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            reportDataSource = new List<TurnoverDefinition>();
            memberMovements = new List<MemberMovement>();
            memberMovement2 = new List<MemberMovement>();
            congregationsList = new List<Congregation>();
            reasons = new List<DisFellowshipReasons>();
                       
            congregationsList = dbContext.Congregations.AsNoTracking().ToList();
            memberMovements = dbContext.MemberMovements.Where(x=> x.MembershipEffectiveDate >= dtpStartDate.Value && x.MembershipEffectiveDate <= dtpEndDate.Value).AsNoTracking().ToList();
            memberMovement2 = dbContext.MemberMovements.Where(x => x.MembershipEndDate >= dtpStartDate.Value && x.MembershipEndDate <= dtpEndDate.Value).AsNoTracking().ToList();
            reasons = dbContext.DisFellowshipReasons.AsNoTracking().ToList();
            
            foreach(MemberMovement movement in memberMovements)
            {
                int congId = movement.Member.CongregationId;
                int mStatusId = movement.Member.MemberStatusId;
                string congregationName = congregationsList.Where(x => x.CongregationId == congId).Select(x => x.CongregationName).First();
                string reason = reasons.Where(x => x.DisFellowshipReasonsId == mStatusId).Select(x => x.ReasonComment).First();


                reportDataSource.Add(new TurnoverDefinition
                {
                    Comment = reason,//"Active Member",
                    Congregation = congregationName,
                    FirstName = movement.Member.FirstName,
                    Gender = movement.Member.Gender,
                    LastName = movement.Member.LastName,
                    MemberNo = movement.Member.MemberNo,
                    RefDate = movement.MembershipEffectiveDate,
                    ReportGroupField = "Admission"
                });
            }

            foreach (MemberMovement movement in memberMovement2)
            {
                int congId = movement.Member.CongregationId;
                int disReasonId = Convert.ToInt32(movement.DisFellowshipReasonId);
                string congregationName = congregationsList.Where(x => x.CongregationId == congId).Select(x => x.CongregationName).First();
                string reason = reasons.Where(x => x.DisFellowshipReasonsId == disReasonId).Select(x => x.ReasonComment).First();

                reportDataSource.Add(new TurnoverDefinition
                {
                    Comment = reason,
                    Congregation = congregationName,
                    FirstName = movement.Member.FirstName,
                    Gender = movement.Member.Gender,
                    LastName = movement.Member.LastName,
                    MemberNo = movement.Member.MemberNo,
                    RefDate = movement.MembershipEndDate,
                    ReportGroupField = "Separation"
                });
            }

            grdDataDisplay.DataSource = reportDataSource;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdDataDisplay.Rows.Count <= 0)
                return;

            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Select Path to save this export";
            folder.ShowDialog();
            string path = string.Empty;

            if (!string.IsNullOrEmpty(folder.SelectedPath))
                path = folder.SelectedPath;
            else
            {
                RadMessageBox.Show("A path must be selected to facilitate this export!", Application.ProductName);
                return;
            }

            string _destinationPath = path;

            string _saveAs = "Turnover Report";

            string fullpath = _destinationPath + "\\" + _saveAs + ".xlsx";

            bool fileExist = File.Exists(fullpath);

            if (fileExist)
            {
                RadMessageBox.Show("A file containing the same name already exist in this location", Application.ProductName);
                return;
            }

            GridViewSpreadExport spreadExporter = new GridViewSpreadExport(this.grdDataDisplay);
            SpreadExportRenderer exportRenderer = new SpreadExportRenderer();

            spreadExporter.HiddenColumnOption = HiddenOption.DoNotExport;
            spreadExporter.SheetName = _saveAs;
            spreadExporter.ExportVisualSettings = true;
            spreadExporter.FileExportMode = FileExportMode.CreateOrOverrideFile;

            spreadExporter.RunExport(fullpath, exportRenderer);

            RadMessageBox.Show("File exported successfully!", Application.ProductName);
        }

        private void grdDataDisplay_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Red;
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                e.CellElement.Font = new System.Drawing.Font("Segoe UI", 8.0f, FontStyle.Bold);
            }
        }
    }
}