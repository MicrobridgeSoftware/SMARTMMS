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
    public partial class RelationTypeForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<RelationType> _relTypes;
        private readonly IRelationTypeApplicationService _relTypeAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public RelationTypeForm(UserInfo userInfo, IUIManager uIManager, IRelationTypeApplicationService relTypeAppService) : this()
        {

            _uIManager = uIManager;

            _relTypeAppService = relTypeAppService;

            _userInfo = userInfo;

        }

        public RelationTypeForm()
        {
            InitializeComponent();
        }

        private void RelationTypeForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _relTypeAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _relTypes = _relTypeAppService.GetAll();

            bindingSource.DataSource = _relTypes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
