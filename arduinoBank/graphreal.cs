using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace arduinoBank
{
    public partial class graphreal : DevExpress.XtraEditors.XtraUserControl
    {
     public DataTable dts {get;set;}
        public graphreal(DataTable dt)
        {
            InitializeComponent();
            dt = dts;
        }
        public graphreal()
        {
            InitializeComponent();
        }
        public void showgraph()
        {
            try
            {
                chartControl1.Series.Clear();
                Series series = new Series("ค่าฝุ่นPM2.5", ViewType.Bar);
                chartControl1.Series.Add(series);
                // Generate a data table and bind the series to it.
                series.DataSource = dts;

                // Specify data members to bind the series.
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "RUNNING";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "PM2.5" });
                SideBySideBarSeriesView view2 = series.View as SideBySideBarSeriesView;
                view2.Color = Color.Green;
            }
            catch (Exception Ex )
            {

                MessageBox.Show(Ex.Message);
            }
        }
        public void showgraphline()
        {
            try
            {
                chartControl1.Series.Clear();
                Series series = new Series("ค่าฝุ่นPM2.5", ViewType.Line);
                chartControl1.Series.Add(series);
                // Generate a data table and bind the series to it.
                series.DataSource = dts;

                // Specify data members to bind the series.
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "RUNNING";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "PM2.5" });
                LineSeriesView view2 = series.View as LineSeriesView;
                view2.Color = Color.Green;

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            try
            {
                if ((int)e.SeriesPoint.NumericalArgument > 0)
                {
                    e.SeriesDrawOptions.Color = Color.Green;

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
  
        }

        private void graphreal_Load(object sender, EventArgs e)
        {
            _rbBar.Checked = true;
        }


        private void checkradio()
        {
            if (_rbBar.Checked == true)
            {
                _rbLine.Checked = false;
            }
            if (_rbLine.Checked == true)
            {
                _rbBar.Checked = false;
            }
        }

        private void _rbBar_CheckedChanged(object sender, EventArgs e)
        {
            showgraph();
        }

        private void _rbLine_CheckedChanged(object sender, EventArgs e)
        {
            showgraphline();
        }
    }
}
