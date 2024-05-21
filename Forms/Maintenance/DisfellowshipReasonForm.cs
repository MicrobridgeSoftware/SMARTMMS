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
    public partial class DisfellowshipReasonForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<DisFellowshipReasons> _disfellowshipReasons;
        private readonly IDisFellowshipReasonsApplicationService _reasonAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public DisfellowshipReasonForm(UserInfo userInfo, IUIManager uIManager, IDisFellowshipReasonsApplicationService reasonAppService) : this()
        {
            _uIManager = uIManager;

            _reasonAppService = reasonAppService;

            _userInfo = userInfo;
        }

        public DisfellowshipReasonForm()
        {
            InitializeComponent();
        }

        private void DisfellowshipReasonForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _reasonAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _disfellowshipReasons = _reasonAppService.GetAll();

            bindingSource.DataSource = _disfellowshipReasons;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}