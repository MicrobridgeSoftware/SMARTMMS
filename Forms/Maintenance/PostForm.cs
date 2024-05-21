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
    public partial class PostForm : Telerik.WinControls.UI.RadForm
    {
        private ObservableCollection<Post> _posts;
        private readonly IPostApplicationService _postAppService;
        private readonly UserInfo _userInfo;
        private readonly IUIManager _uIManager;
       
        public PostForm(UserInfo userInfo, IUIManager uIManager, IPostApplicationService postAppService) : this()
        {

            _uIManager = uIManager;

            _postAppService = postAppService;

            _userInfo = userInfo;


        }

        public PostForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {
            bindingNavigatorControl1.Savable = _postAppService;

            grdData.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            _posts = _postAppService.GetAll();

            bindingSource.DataSource = _posts;
        }
    }
}
