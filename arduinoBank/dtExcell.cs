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

namespace arduinoBank
{
    public partial class dtExcell : DevExpress.XtraEditors.XtraUserControl
    {
        public DataTable dts { get; set; }
        public dtExcell()
        {
            InitializeComponent();
        }
        public dtExcell(DataTable dt)
        {
            InitializeComponent();
        }
        public void showgraph()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = dts;
        }
    }
}
