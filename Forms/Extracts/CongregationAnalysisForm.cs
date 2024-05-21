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
    public partial class CongregationAnalysisForm : Telerik.WinControls.UI.RadForm
    {
        MMSDbContext dbContext = new MMSDbContext();
        List<Member> memberList;
        List<Congregation> congregationList;

        public CongregationAnalysisForm()
        {
            InitializeComponent();
        }

        private void CongregationAnalysisForm_Load(object sender, EventArgs e)
        {
            memberList = new List<Member>();
            List<short> congregationIdList = new List<short>();
            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            congregationList = new List<Congregation>();

            this.radChartView.AreaType = ChartAreaType.Cartesian;

            memberList = dbContext.Members.Where(x => x.IsActive).AsNoTracking().ToList();
            congregationList = dbContext.Congregations.AsNoTracking().ToList();

            congregationIdList = memberList.Select(x => x.CongregationId).Distinct().ToList();

            foreach(short congregationId in congregationIdList)
            {
                string congregationName = congregationList.Where(x => x.CongregationId == congregationId).Select(x => x.CongregationName.Trim()).First();
                int congregationCount = memberList.Where(x => x.CongregationId == congregationId).Count();
                keyValues.Add(congregationName, congregationCount);
            }
                         
            radChartView.ShowTitle = true;
            radChartView.Title = "CONGREGATION ANALYSIS";
            //radChartView
            //radChartView.ShowPanZoom = true;

            foreach (var keys in keyValues.OrderBy(x => x.Value))
            {
                string congName = keys.Key;
                int congId = congregationList.Where(x => x.CongregationName.Trim().Equals(congName)).Select(x => x.CongregationId).FirstOrDefault();
                int maleGenderCount = memberList.Where(x => x.CongregationId == congId && x.Gender.Equals("M")).Count();
                int fMaleGenderCount = memberList.Where(x => x.CongregationId == congId && x.Gender.Equals("F")).Count();

                BarSeries barSeries = new BarSeries();
                barSeries.Name = "Male";//keys.Key;
                barSeries.ShowLabels = true;
                barSeries.LegendTitle = "Male";//keys.Key;

                barSeries.CombineMode = ChartSeriesCombineMode.Stack;

                //barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(keys.Value), keys.Key));
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(maleGenderCount), keys.Key));
                this.radChartView.Series.Add(barSeries);

                BarSeries barSeries1 = new BarSeries();
                barSeries1.Name = "Female";//keys.Key;
                barSeries1.ShowLabels = true;
                barSeries1.LegendTitle = "Female";//keys.Key;

                barSeries1.CombineMode = ChartSeriesCombineMode.Stack;

                //barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(keys.Value), keys.Key));
                barSeries1.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(fMaleGenderCount), keys.Key));
                this.radChartView.Series.Add(barSeries1);
                //this.radChartView.ChartElement.LegendElement.TitleElement.Font = new Font("Segoe UI", 10, FontStyle.Underline);
            }

            this.radChartView.ChartElement.LegendElement.TitleElement.Font = new Font("Segoe UI", 10, FontStyle.Underline);
        }
    }
}