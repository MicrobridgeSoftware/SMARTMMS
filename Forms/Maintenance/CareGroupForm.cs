using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Mbridge.Common.Application.Authorization.Users.Dto;
using Mbridge.Common.Presentation.Utilities;
using MBridge.SMARTMMS.Application.Posts;
using System.Collections.ObjectModel;
using Mbridge.SMARTMMS.Persistence;
using SMARTMMS.Util;

namespace SMARTMMS.Forms.Maintenance
{
    public partial class CareGroupForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<CareGroup> _careGroups;
        private readonly ICareGroupApplicationService _careGroupAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;
        private readonly IMemberApplicationService _memberAppService;
        private ObservableCollection<Member> members;
        List<MemberDefinition> memberDefinitions = new List<MemberDefinition>();

        public CareGroupForm(UserInfo userInfo, IUIManager uIManager, ICareGroupApplicationService careGroupAppService, IMemberApplicationService memberAppService) : this()
        {

            _uIManager = uIManager;

            _careGroupAppService = careGroupAppService;

            _userInfo = userInfo;

            _memberAppService = memberAppService;
        }

        public CareGroupForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CareGroupForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _careGroupAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _careGroups = _careGroupAppService.GetAll();
            members = _memberAppService.GetAll();

            foreach (Member member in members)
                memberDefinitions.Add(new MemberDefinition { memberId = member.MemberId, memberName = member.FirstName.Trim() + " " + member.LastName.Trim() });

            bindingSourceMember.DataSource = memberDefinitions;
            bindingSource.DataSource = _careGroups;
        }
    }
}
