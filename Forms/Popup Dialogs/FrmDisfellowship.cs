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
    public partial class FrmDisfellowship : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<DisFellowshipReasons> fellowshipReasons;
        private int memberId;
        private string memberName;
        private int userId;

        public FrmDisfellowship()
        {
            InitializeComponent();
        }

        public FrmDisfellowship(int memberId, string memberName, int userId) : this()
        {
            this.memberId = memberId;
            this.memberName = memberName;
            this.userId = userId;
        }

        private void FrmDisfellowship_Load(object sender, EventArgs e)
        {
            dtpEnd.MaxDate = DateTime.Today.Date;
            dtpEnd.Value = DateTime.Today.Date;

            txtName.Text = memberName;

            fellowshipReasons = new List<DisFellowshipReasons>();
            fellowshipReasons = dbContext.DisFellowshipReasons.Where(x => x.IsActive).AsNoTracking().ToList();
            bindingSource.DataSource = fellowshipReasons;

            this.ddlReason.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        private void btnReAdmit_Click(object sender, EventArgs e)
        {
            var getRecord = dbContext.MemberMovements.Where(x => x.MemberId == memberId && x.IsActive).FirstOrDefault();

            if (ddlReason.SelectedValue == null || Convert.ToInt32(ddlReason.SelectedValue) == 0)
            {
                RadMessageBox.Show("A reason is required to continue!", Application.ProductName);
                return;
            }

            if (getRecord != null)
            {
                getRecord.IsActive = false;
                getRecord.MembershipEndDate = dtpEnd.Value;
                getRecord.DisFellowshipReasonId = Convert.ToInt32(ddlReason.SelectedValue);
                getRecord.LastModifiedTime = DateTime.Now;
                getRecord.LastModifierUserId = userId;

                var getMemberRecord = dbContext.Members.Where(x => x.MemberId == memberId).FirstOrDefault();

                if (getMemberRecord != null)                
                    getMemberRecord.IsActive = false;

                dbContext.SaveChanges();

                Close();
            }
            else
                RadMessageBox.Show("No record found for this member!", Application.ProductName);
        }
    }
}