using Mbridge.Common.Application.Authorization.Permissions;
using Mbridge.Common.Application.Authorization.Users;
using Mbridge.Common.Application.Authorization.Users.Dto;
using Mbridge.Common.Application.Navigation.NavigationItems;
using Mbridge.Common.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using Telerik.WinControls.UI;
using System.IO;
using System.Reflection;
using SMARTMMS.Util;

namespace SMARTMMS.Forms
{
    public partial class MainForm : Mbridge.Common.Presentation.Forms.MainForm
    {
        public MainForm(UserInfo userInfo, IPermissionAppService permissionAppService, StructureMap.IContainer iocContainer,
            INavigationItemAppService menuItemAppService, IUserAppService userAppService, DatabaseContext dbContext) : base(userInfo, permissionAppService, iocContainer,
            menuItemAppService, userAppService, dbContext)
        {
            InitializeComponent();
            Text = "SMART Member Management System";
            ThemeResolutionService.ApplicationThemeName = "Breeze";
        }
        public MainForm()
        {
            InitializeComponent();            
            //this.FormElement.TitleBar.CloseButton.Enabled = false;
        }

        //  private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}
        protected override void MenuItem_Click(object sender, EventArgs e)
        {

          //  var navigationItem = GetNavigationItem(sender);

           

                base.MenuItem_Click(sender, e);
          
            

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var option = RadMessageBox.Show("Are you sure you want to exit?", Application.ProductName, MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2);

            if (option != DialogResult.Yes)
                e.Cancel = true;

            base.OnClosing(e);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bgwTheme.RunWorkerAsync();
        }

        private void comboBoxElement_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadDropDownListElement _element = sender as RadDropDownListElement;

            string strTheme = _element.Text;

            Theme theme = ThemeResolutionService.GetTheme(strTheme);

            if (theme != null)
            {
                ThemeResolutionService.ApplicationThemeName = theme.Name;
            }
        }

        //private void BtnBackgroundImg_Click(object sender, EventArgs e)
        //{

        //}

        private void bgwTheme_DoWork(object sender, DoWorkEventArgs e)
        {
            var themefiles = Directory.GetFiles(System.Windows.Forms.Application.StartupPath, "Telerik.WinControls.Themes.*.dll");

            foreach (var theme in themefiles)
            {
                var themeAssembly = Assembly.LoadFile(theme);

                var themeType = themeAssembly.GetTypes().Where(_themes => typeof(RadThemeComponentBase).IsAssignableFrom(_themes)).FirstOrDefault();

                if (themeType != null)
                {
                    RadThemeComponentBase themeObject = (RadThemeComponentBase)Activator.CreateInstance(themeType);

                    if (themeObject != null)
                    {
                        themeObject.Load();
                    }
                }
            }

            MemoryManagement.FlushMemory();
        }

        private void bgwTheme_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var _themeList = ThemeRepository.AvailableThemeNames.ToList();
            string _defaultThemeName = string.Empty;

            RadDropDownListElement comboBoxElement = new RadDropDownListElement();
            comboBoxElement.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(comboBoxElement_SelectedIndexChanged);

            comboBoxElement.Items.Add("Default");

            foreach (var _theme in _themeList)
                comboBoxElement.Items.Add(_theme);

            comboBoxElement.MinSize = new Size(200, 20);
            this.radStatusStrip.Items.Add(comboBoxElement);

            _defaultThemeName = "Breeze";//"Office2010Blue";
            comboBoxElement.SelectedIndex = comboBoxElement.Items.IndexOf(comboBoxElement.Items.First(x => x.Text == _defaultThemeName));
        }
    }
}
