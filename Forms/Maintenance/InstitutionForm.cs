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
    public partial class InstitutionForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<Institution> _institutions;
        private readonly IInstitutionsApplicationService _institutionAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public InstitutionForm(UserInfo userInfo, IUIManager uIManager, IInstitutionsApplicationService institutionAppService) : this()
        {
            _uIManager = uIManager;

            _institutionAppService = institutionAppService;

            _userInfo = userInfo;
        }

        public InstitutionForm()
        {
            InitializeComponent();
        }

        private void InstitutionForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _institutionAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _institutions = _institutionAppService.GetAll();

            bindingSource.DataSource = _institutions;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
