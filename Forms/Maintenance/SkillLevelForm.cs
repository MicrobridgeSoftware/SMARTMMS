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
    public partial class SkillLevelForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<SkillLevel> _skillLevel;
        private readonly ISkillLevelApplicationService _skillLevelService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public SkillLevelForm(UserInfo userInfo, IUIManager uIManager, ISkillLevelApplicationService skillLevelService) : this()
        {
            _uIManager = uIManager;

            _skillLevelService = skillLevelService;

            _userInfo = userInfo;
        }

        public SkillLevelForm()
        {
            InitializeComponent();
        }

        private void SkillLevelForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _skillLevelService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _skillLevel = _skillLevelService.GetAll();

            bindingSource.DataSource = _skillLevel;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
