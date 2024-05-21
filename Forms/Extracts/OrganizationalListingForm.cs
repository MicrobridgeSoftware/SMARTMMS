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
using Telerik.WinControls.Export;
using Telerik.WinControls.UI.Export;

namespace SMARTMMS.Forms.Extracts
{
    public partial class OrganizationalListingForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<MemberPost> memberPosts;
        List<Congregation> congregations;

        public OrganizationalListingForm()
        {
            InitializeComponent();
        }

        private void OrganizationalListingForm_Load(object sender, EventArgs e)
        {
            memberPosts = new List<MemberPost>();
            congregations = new List<Congregation>();
            List<Member> members = new List<Member>();

            memberPosts = dbContext.MemberPosts.AsNoTracking().ToList();
            members = dbContext.Members.AsNoTracking().ToList();
            congregations = dbContext.Congregations.AsNoTracking().ToList();

            var categorizedProducts = (from mp in memberPosts join m in members on mp.MemberId equals m.MemberId
                                       join c in congregations on m.CongregationId equals c.CongregationId                                       
                                       select new
                                       {
                                           m,
                                           c,
                                           mp
                                       }).ToList();

            grdDataDisplay.DataSource = categorizedProducts;

            //grdDataDisplay.DataSource = memberPosts;
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

            string _saveAs = "Organizational Listing";

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
