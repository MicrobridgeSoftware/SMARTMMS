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
    public partial class TitleOfCourtesyForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<TitleOfCourtesy> _titleOfCourtesies;
        private readonly ITitleApplicationService _titleAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;

        public TitleOfCourtesyForm(UserInfo userInfo, IUIManager uIManager, ITitleApplicationService titleAppService) : this()
        {
            _uIManager = uIManager;

            _titleAppService = titleAppService;

            _userInfo = userInfo;
        }

        public TitleOfCourtesyForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TitleOfCourtesyForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _titleAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _titleOfCourtesies = _titleAppService.GetAll();

            bindingSource.DataSource = _titleOfCourtesies;
        }
    }
}
