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
    public partial class MemberSkillsForm : Telerik.WinControls.UI.RadForm
    {
        List<Member> memberList;
        List<MemberSkill> memberSkillsList;
        List<Skill> SkillsList;
        List<SkillLevel> skillLevelsList;
        List<SkillType> skillTypeList;
        List<Congregation> congregationList;

        public MemberSkillsForm()
        {
            InitializeComponent();
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

            string _saveAs = "Member skills";

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

        private void MemberSkillsForm_Load(object sender, EventArgs e)
        {
            memberSkillsList = new List<MemberSkill>();
            memberList = new List<Member>();
            SkillsList = new List<Skill>();
            skillLevelsList = new List<SkillLevel>();
            skillTypeList = new List<SkillType>();
            congregationList = new List<Congregation>();

            using (MMSDbContext dbContext = new MMSDbContext())
            {
                memberSkillsList = dbContext.MemberSkills.AsNoTracking().ToList();
                memberList = dbContext.Members.AsNoTracking().ToList();
                SkillsList = dbContext.Skills.AsNoTracking().ToList();
                skillLevelsList = dbContext.SkillLevels.AsNoTracking().ToList();
                skillTypeList = dbContext.SkillTypes.AsNoTracking().ToList();
                congregationList = dbContext.Congregations.AsNoTracking().ToList();
            }

            var categorizedProducts = (from msl in memberSkillsList
                                       join m in memberList on msl.MemberId equals m.MemberId
                                       join sl in SkillsList on msl.SkillId equals sl.SkillId
                                       join sll in skillLevelsList on msl.SkillLevelId equals sll.SkillLevelId
                                       join stl in skillTypeList on sl.SkillTypeId equals stl.SkillTypeId
                                       join cl in congregationList on m.CongregationId equals cl.CongregationId
                                       select new
                                       {
                                           msl,
                                           m,
                                           sl,
                                           sll,
                                           stl,
                                           cl
                                       }).ToList();

            grdDataDisplay.DataSource = categorizedProducts;

            grdDataDisplay.MasterTemplate.ShowTotals = true;

            GroupDescriptor groupDescriptor = new GroupDescriptor();
            groupDescriptor.GroupNames.Add("SkillTypeName", ListSortDirection.Ascending);
            this.grdDataDisplay.GroupDescriptors.Add(groupDescriptor);
            grdDataDisplay.MasterTemplate.ExpandAllGroups();

            //GridViewSummaryItem summaryItem = new GridViewSummaryItem("FirstName", "Total: {0:N0}", GridAggregateFunction.Count);
            //GridViewSummaryRowItem summaryRowItem = new GridViewSummaryRowItem();
            //summaryRowItem.Add(summaryItem);
            //this.grdDataDisplay.SummaryRowsBottom.Add(summaryRowItem);
        }
    }
}
