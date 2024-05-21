using Mbridge.SMARTMMS.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Linq;
using System.Data.Entity;
using Telerik.Charting;

namespace SMARTMMS.Forms.Extracts
{
    public partial class GenderAnalysisForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();

        public GenderAnalysisForm()
        {
            InitializeComponent();
        }

        private void GenderAnalysisForm_Load(object sender, EventArgs e)
        {
            this.radChartView.AreaType = ChartAreaType.Pie;

            var members = dbContext.Members.Where(x => x.IsActive).AsNoTracking().ToList();

            radChartView.ShowTitle = true;
            radChartView.Title = "GENDER ANALYSIS - ALL CONGREGATIONS";

            PieSeries pieSeries = new PieSeries();

            pieSeries.DataPoints.Add(new PieDataPoint(Convert.ToDouble(members.Where(x=> x.Gender == "M").Count()), "Male"));
            pieSeries.ShowLabels = true;
            pieSeries.LegendTitleMember = "Male";

            pieSeries.DataPoints.Add(new PieDataPoint(Convert.ToDouble(members.Where(x => x.Gender == "F").Count()), "Female"));
            pieSeries.ShowLabels = true;
            pieSeries.LegendTitleMember = "Female";
            
            this.radChartView.Series.Add(pieSeries);
            this.radChartView.ChartElement.LegendElement.TitleElement.Font = new Font("Segoe UI", 10, FontStyle.Underline);
        }
    }
}
