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
    public partial class GraphPM1cs : DevExpress.XtraEditors.XtraUserControl
    {
        public DataTable dts { get; set; }
        public GraphPM1cs()
        {
            InitializeComponent();
        }
        public GraphPM1cs(DataTable dt)
        {
            InitializeComponent();
            dts = dt ;
        }
        public void showgraph()
        {
            try
            {
                chartControl1.Series.Clear();
                Series series = new Series("ค่าฝุ่นPM1", ViewType.Bar);
                chartControl1.Series.Add(series);
                // Generate a data table and bind the series to it.
                series.DataSource = dts;

                // Specify data members to bind the series.
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "RUNNING";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "PM1" });
                SideBySideBarSeriesView view2 = series.View as SideBySideBarSeriesView;
                view2.Color = Color.Chocolate;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

        }
        public void showgraphline()
        {
            try
            {
                chartControl1.Series.Clear();
                Series series = new Series("ค่าฝุ่นPM1", ViewType.Line);
                chartControl1.Series.Add(series);
                // Generate a data table and bind the series to it.
                series.DataSource = dts;

                // Specify data members to bind the series.
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "RUNNING";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "PM1" });
                LineSeriesView view2 = series.View as LineSeriesView;
                view2.Color = Color.Chocolate;
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
                    e.SeriesDrawOptions.Color = Color.Chocolate;

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void GraphPM1cs_Load(object sender, EventArgs e)
        {
            checkradio();
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
