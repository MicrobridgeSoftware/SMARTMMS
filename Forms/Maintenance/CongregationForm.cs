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
    public partial class CongregationForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<Congregation> _congregations;
        //private ObservableCollection<Zone> _zones;
        private readonly ICongregationApplicationService _congregationsAppService;
        //private readonly IZoneApplicationService _zonesAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public CongregationForm(UserInfo userInfo, IUIManager uIManager, ICongregationApplicationService congregationAppService/*, IZoneApplicationService zoneAppService*/) : this()
        {
            _uIManager = uIManager;

            _congregationsAppService = congregationAppService;

            _userInfo = userInfo;

            //_zonesAppService = zoneAppService;
        }

        public CongregationForm()
        {
            InitializeComponent();
        }

        private void CongregationForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _congregationsAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _congregations = _congregationsAppService.GetAll();
            //_zones = _zonesAppService.GetAll();

            //bindingSourceZone.DataSource = _zones;
            bindingSource.DataSource = _congregations;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
