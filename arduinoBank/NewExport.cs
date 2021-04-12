using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Spreadsheet;

namespace arduinoBank
{
    public partial class NewExport : DevExpress.XtraEditors.XtraForm
    {
        DataTable dts = new DataTable();
        dtExcell de = new dtExcell();
        graphreal g1 = new graphreal();
        GraphPM1cs gPM1 = new GraphPM1cs();
        graphPM10 gPM10 = new graphPM10();
        graphTemp gtemp = new graphTemp();

        public NewExport(DataTable dt)
        {
            InitializeComponent();
            dts = dt;
            de.dts = dt;
            g1.dts = dt;
            gPM10.dts = dt;
            gPM1.dts = dt;
            gtemp.dts = dt;
        }

        private void NewExport_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            //-------------------------
            de.Dock = DockStyle.Fill;
            de.showgraph();
            g1.Dock = DockStyle.Fill;
      //      g1.showgraph();
            gPM1.Dock = DockStyle.Fill;
         //   gPM1.showgraph();
            gPM10.Dock = DockStyle.Fill;
        //    gPM10.showgraph();
            gtemp.Dock = DockStyle.Fill;
           // gtemp.showgraph();
            panel3.Controls.Clear();
            panel3.Controls.Add(de);
        }

        private void exportExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dts.Rows.Count <= 0)
            {
                return;
            }
            try
            {
                using (SaveFileDialog sa = new SaveFileDialog())
                {
                    sa.Filter = "Execl files (*.xls)|*.xls";
                    sa.FilterIndex = 0;
                    sa.Title = "Export Excel File To";
                    if (sa.ShowDialog() == DialogResult.OK)
                    {
                        Workbook wb = new Workbook();
                        wb.Worksheets[0].Import(dts, true, 0, 0);
                        wb.SaveDocument(sa.FileName, DevExpress.Spreadsheet.DocumentFormat.Xls);
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {

            }
        }

        private void graphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(panel2.Visible)
                {
                    panel2.Visible = false;
                    graphsToolStripMenuItem.BackColor = DefaultBackColor;
                    panel3.Controls.Clear();
                    panel3.Controls.Add(de);
                }
                else
                {
                    panel2.Visible = true;
                    graphsToolStripMenuItem.BackColor = Color.LightBlue;
                    pM25ToolStripMenuItem.BackColor = DefaultBackColor;
                    pM1ToolStripMenuItem.BackColor = DefaultBackColor;
                    pM10ToolStripMenuItem.BackColor = DefaultBackColor;
                    tEMPToolStripMenuItem.BackColor = DefaultBackColor;

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void pM25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(g1);
                pM25ToolStripMenuItem.BackColor = Color.LightBlue;
                pM1ToolStripMenuItem.BackColor = DefaultBackColor;
                pM10ToolStripMenuItem.BackColor = DefaultBackColor;
                tEMPToolStripMenuItem.BackColor = DefaultBackColor; 
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void pM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(gPM1);
                pM25ToolStripMenuItem.BackColor = DefaultBackColor;
                pM1ToolStripMenuItem.BackColor = Color.LightBlue;
                pM10ToolStripMenuItem.BackColor = DefaultBackColor;
                tEMPToolStripMenuItem.BackColor = DefaultBackColor;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void pM10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(gPM10);
                pM25ToolStripMenuItem.BackColor = DefaultBackColor;
                pM1ToolStripMenuItem.BackColor = DefaultBackColor; 
                pM10ToolStripMenuItem.BackColor = Color.LightBlue;
                tEMPToolStripMenuItem.BackColor = DefaultBackColor;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void tEMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(gtemp);
                pM25ToolStripMenuItem.BackColor = DefaultBackColor;
                pM1ToolStripMenuItem.BackColor = DefaultBackColor;
                pM10ToolStripMenuItem.BackColor = DefaultBackColor;
                tEMPToolStripMenuItem.BackColor = Color.LightBlue;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}