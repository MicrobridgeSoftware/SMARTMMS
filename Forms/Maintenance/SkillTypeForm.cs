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
    public partial class SkillTypeForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<SkillType> _skillTypes;
        private readonly ISkillTypeApplicationService _skillTypeAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public SkillTypeForm(UserInfo userInfo, IUIManager uIManager, ISkillTypeApplicationService skillTypeAppService) : this()
        {
            _uIManager = uIManager;

            _skillTypeAppService = skillTypeAppService;

            _userInfo = userInfo;
        }

        public SkillTypeForm()
        {
            InitializeComponent();
        }
        
        private void SkillTypeForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _skillTypeAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _skillTypes = _skillTypeAppService.GetAll();

            bindingSource.DataSource = _skillTypes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
