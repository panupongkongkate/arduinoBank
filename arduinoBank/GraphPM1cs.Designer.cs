namespace arduinoBank
{
    partial class GraphPM1cs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this._rbLine = new System.Windows.Forms.RadioButton();
            this._rbBar = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(911, 504);
            this.chartControl1.TabIndex = 5;
            this.chartControl1.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl1_CustomDrawSeriesPoint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._rbLine);
            this.panel1.Controls.Add(this._rbBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 45);
            this.panel1.TabIndex = 8;
            // 
            // _rbLine
            // 
            this._rbLine.AutoSize = true;
            this._rbLine.Location = new System.Drawing.Point(94, 12);
            this._rbLine.Name = "_rbLine";
            this._rbLine.Size = new System.Drawing.Size(83, 21);
            this._rbLine.TabIndex = 1;
            this._rbLine.Text = "กราฟเส้น";
            this._rbLine.UseVisualStyleBackColor = true;
            this._rbLine.CheckedChanged += new System.EventHandler(this._rbLine_CheckedChanged);
            // 
            // _rbBar
            // 
            this._rbBar.AutoSize = true;
            this._rbBar.Location = new System.Drawing.Point(3, 12);
            this._rbBar.Name = "_rbBar";
            this._rbBar.Size = new System.Drawing.Size(85, 21);
            this._rbBar.TabIndex = 0;
            this._rbBar.Text = "กราฟแท่ง";
            this._rbBar.UseVisualStyleBackColor = true;
            this._rbBar.CheckedChanged += new System.EventHandler(this._rbBar_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 504);
            this.panel2.TabIndex = 9;
            // 
            // GraphPM1cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GraphPM1cs";
            this.Size = new System.Drawing.Size(911, 549);
            this.Load += new System.EventHandler(this.GraphPM1cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton _rbLine;
        private System.Windows.Forms.RadioButton _rbBar;
        private System.Windows.Forms.Panel panel2;
    }
}
