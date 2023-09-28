namespace SuongSuon.UI
{
    partial class BC_BanHang
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.cbo_loaiBC_DT = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_BC_Loai_BC = new System.Windows.Forms.ComboBox();
            this.cbo_BC_DT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new DevExpress.XtraEditors.VScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_loaiBC_DT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_loaiBC_DT
            // 
            this.cbo_loaiBC_DT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo_loaiBC_DT.Controls.Add(this.chart1);
            this.cbo_loaiBC_DT.Controls.Add(this.cbo_BC_Loai_BC);
            this.cbo_loaiBC_DT.Controls.Add(this.cbo_BC_DT);
            this.cbo_loaiBC_DT.Controls.Add(this.label5);
            this.cbo_loaiBC_DT.Controls.Add(this.label2);
            this.cbo_loaiBC_DT.Controls.Add(this.label1);
            this.cbo_loaiBC_DT.Location = new System.Drawing.Point(22, 68);
            this.cbo_loaiBC_DT.Name = "cbo_loaiBC_DT";
            this.cbo_loaiBC_DT.Size = new System.Drawing.Size(620, 531);
            this.cbo_loaiBC_DT.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(57, 124);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(477, 227);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // cbo_BC_Loai_BC
            // 
            this.cbo_BC_Loai_BC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BC_Loai_BC.FormattingEnabled = true;
            this.cbo_BC_Loai_BC.Items.AddRange(new object[] {
            "Báo cáo bán hàng theo thời gian",
            "Báo cáo bán hàng theo nhân viên",
            "Báo cáo bán hàng theo sản phẩm",
            "báo cáo bán hàng theo đơn hàng",
            "Báo cáo bán hàng theo chi nhánh",
            "Báo cáo bán hàng theo nguồn bán hàng",
            "Báo cáo bán hàng theo khách hàng",
            "Báo cáo bán hàng theo nhóm khách hàng",
            "Báo cáo bán hàng theo thuế",
            ""});
            this.cbo_BC_Loai_BC.Location = new System.Drawing.Point(46, 412);
            this.cbo_BC_Loai_BC.Name = "cbo_BC_Loai_BC";
            this.cbo_BC_Loai_BC.Size = new System.Drawing.Size(488, 24);
            this.cbo_BC_Loai_BC.TabIndex = 2;
            // 
            // cbo_BC_DT
            // 
            this.cbo_BC_DT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BC_DT.FormattingEnabled = true;
            this.cbo_BC_DT.Items.AddRange(new object[] {
            "Theo ngày giao hàng",
            "Theo nguồn bán hàng"});
            this.cbo_BC_DT.Location = new System.Drawing.Point(57, 80);
            this.cbo_BC_DT.Name = "cbo_BC_DT";
            this.cbo_BC_DT.Size = new System.Drawing.Size(158, 24);
            this.cbo_BC_DT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "6,383,000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "7 ngày qua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOANH THU CỬA HÀNG";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1308, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(12, 1081);
            this.vScrollBar1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "7 ngày qua";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(667, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 531);
            this.panel2.TabIndex = 0;
            // 
            // chartControl1
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "-0.889439808604539;0.409960567580027;-0.202062267380602;0;0.454296353190708;0.841" +
    "463670629604;-0.292495665759672;0;0.0501163680562901;-0.351953440159392;-0.93467" +
    "4876956061;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Location = new System.Drawing.Point(37, 110);
            this.chartControl1.Name = "chartControl1";
            series2.Name = "Series 1";
            series2.SeriesID = 0;
            series2.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(547, 282);
            this.chartControl1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tình trạng bán hàng theo thời gian",
            "Tình trạng bán hàng theo nhân viên",
            "Tình trạng bán hàng theo vận đơn/phiếu hàng",
            "Tình trạng bán hàng theo đối tác vận chuyển",
            "Tình trạng bán hàng theo chi nhánh/cửa hàng",
            "Tình trạng bán hàng theo khách hàng",
            "Tình trạng bán hàng theo kênh bán hàng",
            "Tình trạng bán hàng theo nguồn hàng"});
            this.comboBox2.Location = new System.Drawing.Point(37, 412);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(547, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo tình trạng",
            "Top đối tác vận chuyển"});
            this.comboBox1.Location = new System.Drawing.Point(37, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(33, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "THÔNG TIN GIAO HÀNG";
            // 
            // BC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbo_loaiBC_DT);
            this.Name = "BC_BanHang";
            this.Size = new System.Drawing.Size(1320, 1081);
            this.cbo_loaiBC_DT.ResumeLayout(false);
            this.cbo_loaiBC_DT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cbo_loaiBC_DT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbo_BC_DT;
        private DevExpress.XtraEditors.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox cbo_BC_Loai_BC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label label6;
    }
}
