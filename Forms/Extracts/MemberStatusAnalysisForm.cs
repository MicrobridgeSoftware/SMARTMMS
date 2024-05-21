using Mbridge.SMARTMMS.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SMARTMMS.Forms.Extracts
{
    public partial class MemberStatusAnalysisForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<DisFellowshipReasons> status;

        public MemberStatusAnalysisForm()
        {
            InitializeComponent();
        }

        private void MemberStatusAnalysisForm_Load(object sender, EventArgs e)
        {
            this.radChartView.AreaType = ChartAreaType.Pie;
            List<int> statusIds = new List<int>();
            status = new List<DisFellowshipReasons>();

            var members = dbContext.Members.Where(x => x.IsActive).AsNoTracking().ToList();
            status = dbContext.DisFellowshipReasons.AsNoTracking().ToList();
            statusIds = members.Select(x => x.MemberStatusId).Distinct().ToList();

            radChartView.ShowTitle = true;
            radChartView.Title = "MEMBER STATUS ANALYSIS - ALL CONGREGATIONS";

            PieSeries pieSeries = new PieSeries();

            foreach (int id in statusIds)
            {
                //PieSeries pieSeries = new PieSeries();
                string statusName = status.Where(x => x.DisFellowshipReasonsId == id).Select(x => x.ReasonComment).FirstOrDefault();

                pieSeries.DataPoints.Add(new PieDataPoint(Convert.ToDouble(members.Where(x => x.MemberStatusId == id).Count()), statusName.Trim()));
                pieSeries.ShowLabels = true;
                pieSeries.LegendTitleMember = statusName.Trim();
                
                this.radChartView.Series.Add(pieSeries);
            }

            this.radChartView.ChartElement.LegendElement.TitleElement.Font = new Font("Segoe UI", 10, FontStyle.Underline);
        }
    }
}
