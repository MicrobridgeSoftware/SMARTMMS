using Mbridge.Common.Core.Authorization.Users;
using Mbridge.SMARTMMS.Persistence;
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
using Telerik.WinControls.Export;
using Telerik.WinControls.UI.Export;

namespace SMARTMMS.Forms.Extracts
{
    public partial class NonMemberDiaryEnrtyForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<User> userList = new List<User>();
        List<DiaryNotes> diaryNotesList;

        public NonMemberDiaryEnrtyForm()
        {
            InitializeComponent();
        }

        private void NonMemberDiaryEnrtyForm_Load(object sender, EventArgs e)
        {
            //dtpStartDate.MaxDate = DateTime.Today.Date;
            dtpStartDate.Value = DateTime.Today.Date;
            userList = dbContext.Users.AsNoTracking().ToList();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            diaryNotesList = dbContext.DiaryNotes.Where(x => x.MemberId == 0 && 
                             DbFunctions.TruncateTime(x.ReferenceDate) >= dtpStartDate.Value &&
                             DbFunctions.TruncateTime(x.ReferenceDate) <= dtpEndDate.Value)
                             .AsNoTracking().ToList();

            var diaryEntries = (from notes in diaryNotesList
                                join users in userList on notes.CreatorUserId equals users.UserId
                                select new
                                {
                                    notes,
                                    users
                                }).ToList();

            grdDataDisplay.DataSource = diaryEntries;
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

            string _saveAs = "Diary Notes";

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
    }
}