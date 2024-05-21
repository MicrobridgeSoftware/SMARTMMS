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
    public partial class ZoneForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<Zone> _zones;
        private readonly IZoneApplicationService _zoneAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public ZoneForm(UserInfo userInfo, IUIManager uIManager, IZoneApplicationService zoneAppService) : this()
        {

            _uIManager = uIManager;

            _zoneAppService = zoneAppService;

            _userInfo = userInfo;

        }

        public ZoneForm()
        {
            InitializeComponent();
        }

        private void ZoneForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _zoneAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _zones = _zoneAppService.GetAll();

            bindingSource.DataSource = _zones;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
