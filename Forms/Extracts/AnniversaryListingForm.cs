using Mbridge.SMARTMMS.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class AnniversaryListingForm : Telerik.WinControls.UI.RadForm
    {
        List<AnniversaryType> anniversaryTypes;
        List<MemberAnniversary> memberAnniversaries;
        List<Member> memberList;

        public AnniversaryListingForm()
        {
            InitializeComponent();
        }

        private void AnniversaryListingForm_Load(object sender, EventArgs e)
        {
            //Dictionary<int, string> monthKeyPairs = new Dictionary<int, string>();
            //monthKeyPairs.Add(1, "January");

            anniversaryTypes = new List<AnniversaryType>();
            memberAnniversaries = new List<MemberAnniversary>();
            memberList = new List<Member>();

            using (MMSDbContext dbContext = new MMSDbContext())
            {
                anniversaryTypes = dbContext.AnniversaryTypes.AsNoTracking().ToList();
                memberAnniversaries = dbContext.MemberAnniversaries.AsNoTracking().ToList();
                memberList = dbContext.Members.AsNoTracking().ToList();
            }

            //int anniversaryMonthId = anniversary.AnniversaryDate.Month;
            foreach (MemberAnniversary anniversary in memberAnniversaries)               
                anniversary.MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(anniversary.AnniversaryDate.Month);            

            var categorizedProducts = (from a in memberAnniversaries
                                       join at in anniversaryTypes on a.AnniversaryTypeId equals at.AnniversaryTypeId
                                       join m in memberList on a.MemberId equals m.MemberId
                                       select new
                                       {
                                           m,
                                           at,
                                           a
                                       }).ToList();

            grdDataDisplay.DataSource = categorizedProducts;

            grdDataDisplay.MasterTemplate.ShowTotals = true;

            GroupDescriptor groupDescriptor = new GroupDescriptor();
            groupDescriptor.GroupNames.Add("AnniversaryTypeName", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(groupDescriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();

            GridViewSummaryItem summaryItem = new GridViewSummaryItem("FirstName", "Total: {0:N0}", GridAggregateFunction.Count);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);
            this.grdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);
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

            string _saveAs = "Anniversary Listing";

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