namespace arduinoBank
{
    partial class NewExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.pM25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pM10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.graphPM101 = new arduinoBank.graphPM10();
            this.graphPM1cs1 = new arduinoBank.GraphPM1cs();
            this.graphTemp1 = new arduinoBank.graphTemp();
            this.graphreal1 = new arduinoBank.graphreal();
            this.dtExcell1 = new arduinoBank.dtExcell();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportExcelToolStripMenuItem,
            this.graphsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportExcelToolStripMenuItem
            // 
            this.exportExcelToolStripMenuItem.Name = "exportExcelToolStripMenuItem";
            this.exportExcelToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exportExcelToolStripMenuItem.Text = "Export Excel";
            this.exportExcelToolStripMenuItem.Click += new System.EventHandler(this.exportExcelToolStripMenuItem_Click);
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.graphsToolStripMenuItem.Text = "Graphs";
            this.graphsToolStripMenuItem.Click += new System.EventHandler(this.graphsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 32);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 33);
            this.panel2.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pM25ToolStripMenuItem,
            this.pM1ToolStripMenuItem,
            this.pM10ToolStripMenuItem,
            this.tEMPToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1188, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // pM25ToolStripMenuItem
            // 
            this.pM25ToolStripMenuItem.Name = "pM25ToolStripMenuItem";
            this.pM25ToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.pM25ToolStripMenuItem.Text = "PM2.5";
            this.pM25ToolStripMenuItem.Click += new System.EventHandler(this.pM25ToolStripMenuItem_Click);
            // 
            // pM1ToolStripMenuItem
            // 
            this.pM1ToolStripMenuItem.Name = "pM1ToolStripMenuItem";
            this.pM1ToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.pM1ToolStripMenuItem.Text = "PM1";
            this.pM1ToolStripMenuItem.Click += new System.EventHandler(this.pM1ToolStripMenuItem_Click);
            // 
            // pM10ToolStripMenuItem
            // 
            this.pM10ToolStripMenuItem.Name = "pM10ToolStripMenuItem";
            this.pM10ToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.pM10ToolStripMenuItem.Text = "PM10";
            this.pM10ToolStripMenuItem.Click += new System.EventHandler(this.pM10ToolStripMenuItem_Click);
            // 
            // tEMPToolStripMenuItem
            // 
            this.tEMPToolStripMenuItem.Name = "tEMPToolStripMenuItem";
            this.tEMPToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.tEMPToolStripMenuItem.Text = "TEMP";
            this.tEMPToolStripMenuItem.Click += new System.EventHandler(this.tEMPToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.graphPM101);
            this.panel3.Controls.Add(this.graphPM1cs1);
            this.panel3.Controls.Add(this.graphTemp1);
            this.panel3.Controls.Add(this.graphreal1);
            this.panel3.Controls.Add(this.dtExcell1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 556);
            this.panel3.TabIndex = 4;
            // 
            // graphPM101
            // 
            this.graphPM101.dts = null;
            this.graphPM101.Location = new System.Drawing.Point(830, 152);
            this.graphPM101.Name = "graphPM101";
            this.graphPM101.Size = new System.Drawing.Size(320, 154);
            this.graphPM101.TabIndex = 4;
            this.graphPM101.Visible = false;
            // 
            // graphPM1cs1
            // 
            this.graphPM1cs1.dts = null;
            this.graphPM1cs1.Location = new System.Drawing.Point(366, 256);
            this.graphPM1cs1.Name = "graphPM1cs1";
            this.graphPM1cs1.Size = new System.Drawing.Size(380, 167);
            this.graphPM1cs1.TabIndex = 3;
            this.graphPM1cs1.Visible = false;
            // 
            // graphTemp1
            // 
            this.graphTemp1.dts = null;
            this.graphTemp1.Location = new System.Drawing.Point(62, 199);
            this.graphTemp1.Name = "graphTemp1";
            this.graphTemp1.Size = new System.Drawing.Size(212, 186);
            this.graphTemp1.TabIndex = 2;
            this.graphTemp1.Visible = false;
            // 
            // graphreal1
            // 
            this.graphreal1.dts = null;
            this.graphreal1.Location = new System.Drawing.Point(401, 59);
            this.graphreal1.Name = "graphreal1";
            this.graphreal1.Size = new System.Drawing.Size(338, 146);
            this.graphreal1.TabIndex = 1;
            this.graphreal1.Visible = false;
            // 
            // dtExcell1
            // 
            this.dtExcell1.dts = null;
            this.dtExcell1.Location = new System.Drawing.Point(62, 39);
            this.dtExcell1.Name = "dtExcell1";
            this.dtExcell1.Size = new System.Drawing.Size(241, 127);
            this.dtExcell1.TabIndex = 0;
            // 
            // NewExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewExport";
            this.Text = "NewExport";
            this.Load += new System.EventHandler(this.NewExport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pM25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pM1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pM10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEMPToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private dtExcell dtExcell1;
        private graphPM10 graphPM101;
        private GraphPM1cs graphPM1cs1;
        private graphTemp graphTemp1;
        private graphreal graphreal1;
    }
}