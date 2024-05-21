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

namespace SMARTMMS.Forms.Maintenance
{
    public partial class SkillForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<Skill> _skills;
        private ObservableCollection<SkillType> _skillTypes;
        private readonly ISkillApplicationService _skillsAppService;
        private readonly ISkillTypeApplicationService _skillTypesAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public SkillForm(UserInfo userInfo, IUIManager uIManager, ISkillApplicationService skillAppService, ISkillTypeApplicationService skillTypeAppService) : this()
        {
            _uIManager = uIManager;

            _skillsAppService = skillAppService;

            _userInfo = userInfo;

            _skillTypesAppService = skillTypeAppService;
        }

        public SkillForm()
        {
            InitializeComponent();
        }

        private void SkillForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _skillsAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _skills = _skillsAppService.GetAll();
            _skillTypes = _skillTypesAppService.GetAll();

            bindingSourceSkillType.DataSource = _skillTypes;
            bindingSource.DataSource = _skills;            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
