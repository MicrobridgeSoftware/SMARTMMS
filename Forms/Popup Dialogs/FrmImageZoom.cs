using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mbridge.SMARTMMS.Persistence;
using Telerik.WinControls;

namespace SMARTMMS.Forms.Popup_Dialogs
{
    public partial class FrmImageZoom : Telerik.WinControls.UI.RadForm
    {
        private List<MemberAttachment> attachments;

        public FrmImageZoom()
        {
            InitializeComponent();
        }

        public FrmImageZoom(List<MemberAttachment> attachments) : this()
        {
            this.attachments = attachments;
        }

        private void FrmImageZoom_Load(object sender, EventArgs e)
        {
            grd.DataSource = attachments;
            grd.TableElement.RowHeight = 490;
        }
    }
}
