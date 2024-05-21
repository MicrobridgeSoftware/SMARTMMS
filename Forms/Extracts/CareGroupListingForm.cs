using Mbridge.SMARTMMS.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class CareGroupListingForm : Telerik.WinControls.UI.RadForm
    {
        List<CareGroup> careGroupList;
        List<Member> memberList;

        public CareGroupListingForm()
        {
            InitializeComponent();
        }

        private void CareGroupListingForm_Load(object sender, EventArgs e)
        {
            careGroupList = new List<CareGroup>();
            memberList = new List<Member>();
            Dictionary<short, int> careGroupIds = new Dictionary<short, int>();

            using (MMSDbContext dbContext = new MMSDbContext())
            {
                careGroupList = dbContext.CareGroups.AsNoTracking().ToList();
                memberList = dbContext.Members.AsNoTracking().ToList();
            }

            var categorizedProducts = (from c in careGroupList
                                       join m in memberList on c.CareGroupId equals m.CareGroupId
                                       select new
                                       {
                                          c,
                                           m
                                       }).ToList();

            var GroupsWithLeaders = careGroupList.Where(x => x.LeadMemberId != null).ToList();

            foreach (var group in GroupsWithLeaders)
                careGroupIds.Add(group.CareGroupId, Convert.ToInt32(group.LeadMemberId));

            grdDataDisplay.DataSource = categorizedProducts;

            foreach(var id in careGroupIds)
            {
                var gridList = grdDataDisplay.Rows.Where(x => Convert.ToInt16(x.Cells["CareGroupId"].Value) == id.Key).ToList();
                var leadMemberDetails = memberList.Where(x => x.MemberId == id.Value).FirstOrDefault();

                if (gridList.Count > 0)
                    foreach (var row in gridList)
                        row.Cells["LeadBy"].Value = leadMemberDetails.FirstName.Trim() + " " + leadMemberDetails.LastName.Trim();
            }

            grdDataDisplay.MasterTemplate.ShowTotals = true;

            GroupDescriptor groupDescriptor = new GroupDescriptor();
            groupDescriptor.GroupNames.Add("CareGroupName", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(groupDescriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();

            GridViewSummaryItem summaryItem = new GridViewSummaryItem("MemberNo", "Total: {0:N0}", GridAggregateFunction.Count);
            GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            summaryRowItem.Add(summaryItem);
            this.grdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);
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

            string _saveAs = "Care Group Listing";

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
