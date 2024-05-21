using Mbridge.SMARTMMS.Persistence;
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

namespace SMARTMMS.Forms.Popup_Dialogs
{
    public partial class FrmAdmit : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        private int memberId;
        private string memberName;
        private int userId;
        List<DisFellowshipReasons> status;

        public FrmAdmit()
        {
            InitializeComponent();
        }

        public FrmAdmit(int memberId, string memberName, int userId) : this()
        {
            this.memberId = memberId;
            this.memberName = memberName;
            this.userId = userId;
        }

        private void FrmAdmit_Load(object sender, EventArgs e)
        {
            dtpJoin.MaxDate = DateTime.Today.Date;
            dtpJoin.Value = DateTime.Today.Date;

            txtName.Text = memberName;
            status = new List<DisFellowshipReasons>();

            status = dbContext.DisFellowshipReasons.Where(x => x.IsActive == false).AsNoTracking().ToList();
            bindingSourceStatus.DataSource = status;

            this.ddlStatus.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        private void btnReAdmit_Click(object sender, EventArgs e)
        {
            if (ddlStatus.SelectedValue == null || Convert.ToInt32(ddlStatus.SelectedValue) == 0)
            {
                RadMessageBox.Show("A status is required to re-activate this member!", Application.ProductName);
                return;
            }

            MemberMovement memberMovement = new MemberMovement();
            memberMovement.CreationTime = DateTime.Now;
            memberMovement.CreatorUserId = userId;
            memberMovement.IsActive = true;
            memberMovement.MemberId = memberId;
            memberMovement.MembershipEffectiveDate = dtpJoin.Value;
            dbContext.MemberMovements.Add(memberMovement);

            var getMemberRecord = dbContext.Members.Where(x => x.MemberId == memberId).FirstOrDefault();

            if (getMemberRecord != null)
            {
                getMemberRecord.IsActive = true;
                getMemberRecord.LastMembershipEffectiveDate = dtpJoin.Value;
                getMemberRecord.MemberStatusId = Convert.ToInt32(ddlStatus.SelectedValue);
            }

            dbContext.SaveChanges();

            Close();
        }
    }
}