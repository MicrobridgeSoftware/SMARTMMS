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
    public partial class MemberListingForm : Telerik.WinControls.UI.RadForm
    {
        List<Member> memberList;
        List<DisFellowshipReasons> memberStatus;
        List<Congregation> congregations;
        List<MaritalStatus> maritals;
        List<Zone> zoneList;

        public MemberListingForm()
        {
            InitializeComponent();
        }

        private void MemberListingForm_Load(object sender, EventArgs e)
        {
            memberList = new List<Member>();
            memberStatus = new List<DisFellowshipReasons>();
            congregations = new List<Congregation>();
            maritals = new List<MaritalStatus>();
            zoneList = new List<Zone>();

            using (MMSDbContext dbContext = new MMSDbContext())
            {
                memberList = dbContext.Members.AsNoTracking().ToList();
                memberStatus = dbContext.DisFellowshipReasons.AsNoTracking().ToList();
                congregations = dbContext.Congregations.AsNoTracking().ToList();
                maritals = dbContext.MaritalStatuses.AsNoTracking().ToList();
                zoneList = dbContext.Zones.AsNoTracking().ToList();
            }
            
            var displayList = (from m in memberList
                               join ms in memberStatus on m.MemberStatusId equals ms.DisFellowshipReasonsId 
                               join c in congregations on m.CongregationId equals c.CongregationId
                               join mstat in maritals on m.MaritalStatusId equals mstat.MaritalStatusId
                               join z in zoneList on m.ZoneId equals z.ZoneId
                               select new
                               {
                                   m,
                                   ms,
                                   c,
                                   mstat,
                                   z
                               }).ToList();

            grdDataDisplay.DataSource = displayList;// memberList;

            DateTime currentDate = DateTime.Today;

            for (int i = 0; i < grdDataDisplay.Rows.Count; i++)
            {
                DateTime bday = Convert.ToDateTime(grdDataDisplay.Rows[i].Cells["DateOfBith"].Value);

                int age = currentDate.Year - bday.Year;

                if (bday > currentDate.AddYears(-age))
                    age--;

                grdDataDisplay.Rows[i].Cells["Age"].Value = age;
            }

            grdDataDisplay.MasterTemplate.ShowTotals = true;

            GroupDescriptor groupDescriptor = new GroupDescriptor();
            groupDescriptor.GroupNames.Add("MemberStatus", ListSortDirection.Ascending);
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

            string _saveAs = "Member Listing";

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