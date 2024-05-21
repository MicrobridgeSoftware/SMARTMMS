using Mbridge.Common.Application.Authorization.Users.Dto;
using Mbridge.Common.Presentation.Utilities;
using Mbridge.SMARTMMS.Persistence;
using MBridge.SMARTMMS.Application.Posts;
using SMARTMMS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SMARTMMS.Forms.Maintenance
{
    public partial class ChurchDiaryForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<Member> members;
        List<MemberDefinition> memberListing;

        private readonly IDiaryNotesApplicationService _diaryAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public ChurchDiaryForm(UserInfo userInfo, IUIManager uIManager, IDiaryNotesApplicationService diaryAppService) : this()
        {
            _uIManager = uIManager;
            _diaryAppService = diaryAppService;
            _userInfo = userInfo;
        }
        public ChurchDiaryForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkEntryType_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkEntryType.Checked)
            {
                ddlMember.Enabled = true;
                ddlMember.SelectedIndex = 0;
            }
            else
            {
                ddlMember.Enabled = false;
                ddlMember.SelectedIndex = -1;
            }
        }

        private void ChurchDiaryForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today.Date;
            //dtpDate.MaxDate = DateTime.Today.Date;
            members = new List<Member>();
            memberListing = new List<MemberDefinition>();

            members = dbContext.Members.Where(x => x.IsActive).AsNoTracking().ToList();

            foreach (Member member in members)
                memberListing.Add(new MemberDefinition { memberId = member.MemberId, memberName = member.FirstName.Trim() + " " + member.LastName.Trim() });

            memberListing = memberListing.OrderBy(x => x.memberName).ToList();

            bindingSourceMember.DataSource = memberListing;

            ddlMember.SelectedIndex = -1;
            this.ddlMember.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = RadMessageBox.Show("Are you sure you want to commit this entry to the database?", Application.ProductName, MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                if (chkEntryType.Checked)
                {
                    if (ddlMember.SelectedValue == null || Convert.ToInt32(ddlMember.SelectedValue) == 0)
                    {
                        RadMessageBox.Show("A member is required for this entry!", Application.ProductName);
                        return;
                    }
                }

                if (txtEntry.Text.Trim() == string.Empty)
                {
                    RadMessageBox.Show("The details of the entry is required to continue!", Application.ProductName);
                    return;
                }

                try
                {
                    DiaryNotes notes = new DiaryNotes();
                    notes.CreationTime = DateTime.Now;
                    notes.CreatorUserId = _userInfo.UserId;

                    if (chkEntryType.Checked == true)
                        notes.MemberId = Convert.ToInt32(ddlMember.SelectedValue);
                    else
                        notes.MemberId = 0;

                    notes.Notes = txtEntry.Text.Trim();
                    notes.ReferenceDate = dtpDate.Value;
                    dbContext.DiaryNotes.Add(notes);
                    dbContext.SaveChanges();

                    RadMessageBox.Show("Entry created successfully!", Application.ProductName);

                    dtpDate.Value = DateTime.Today.Date;
                    chkEntryType.Checked = false;
                    txtEntry.Text = string.Empty;
                }
                catch (Exception _exp)
                {
                    RadMessageBox.Show(_exp.InnerException == null ? _exp.Message : _exp.InnerException.Message);
                }
            }
        }
    }
}