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
    public partial class AnniversaryTypeForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<AnniversaryType> _anniversaryTypes;
        private readonly IAnniversaryTypeApplicationService _anniversaryTypeAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public AnniversaryTypeForm(UserInfo userInfo, IUIManager uIManager, IAnniversaryTypeApplicationService anniversaryTypeAppService) : this()
        {
            _uIManager = uIManager;

            _anniversaryTypeAppService = anniversaryTypeAppService;

            _userInfo = userInfo;
        }

        public AnniversaryTypeForm()
        {
            InitializeComponent();
        }

        private void AnniversaryTypeForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _anniversaryTypeAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _anniversaryTypes = _anniversaryTypeAppService.GetAll();

            bindingSource.DataSource = _anniversaryTypes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
