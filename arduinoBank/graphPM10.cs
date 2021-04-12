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
    public partial class graphPM10 : DevExpress.XtraEditors.XtraUserControl
    {
        public DataTable dts { get; set; }
        public graphPM10()
        {
            InitializeComponent();
        }
        public graphPM10(DataTable dt)
        {
            InitializeComponent();
            dts = dt;
        }
        public void showgraph()
        {
            try
            {
                chartControl1.Series.Clear();
                Series series = new Series("ค่าฝุ่นPM10", ViewType.Bar);
                chartControl1.Series.Add(series);
                // Generate a data table and bind the series to it.
                series.DataSource = dts;

                // Specify data members to bind the series.
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "RUNNING";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "PM10" });
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void checkradio()
        {
            if(_rbBar.Checked == true)
            {
                _rbLine.Checked = false;
            }
            if (_rbLine.Checked == true )
            {
                _rbBar.Checked = false;
            }
        }
        private void showgrapline()
        {
            try
            {
                chartControl1.Series.Clear();
                Series series = new Series("ค่าฝุ่นPM10", ViewType.Line);
                chartControl1.Series.Add(series);
                // Generate a data table and bind the series to it.
                series.DataSource = dts;

                // Specify data members to bind the series.
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "RUNNING";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "PM10" });
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void graphPM10_Load(object sender, EventArgs e)
        {
            _rbBar.Checked = true;
        }

        private void _rbBar_CheckedChanged(object sender, EventArgs e)
        {
            showgraph();
        }

        private void _rbLine_CheckedChanged(object sender, EventArgs e)
        {
            showgrapline();
        }
    }
}
