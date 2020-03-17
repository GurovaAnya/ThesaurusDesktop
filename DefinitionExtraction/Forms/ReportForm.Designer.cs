namespace DefinitionExtraction.Forms
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statsDataGrid = new System.Windows.Forms.DataGridView();
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.statsChart.Legends.Add(legend3);
            this.statsChart.Location = new System.Drawing.Point(416, 68);
            this.statsChart.Name = "statsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Users";
            this.statsChart.Series.Add(series3);
            this.statsChart.Size = new System.Drawing.Size(372, 353);
            this.statsChart.TabIndex = 0;
            this.statsChart.Text = "chart1";
            // 
            // statsDataGrid
            // 
            this.statsDataGrid.AllowUserToAddRows = false;
            this.statsDataGrid.AllowUserToDeleteRows = false;
            this.statsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.statsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsDataGrid.Location = new System.Drawing.Point(13, 68);
            this.statsDataGrid.Name = "statsDataGrid";
            this.statsDataGrid.ReadOnly = true;
            this.statsDataGrid.RowHeadersWidth = 51;
            this.statsDataGrid.RowTemplate.Height = 24;
            this.statsDataGrid.Size = new System.Drawing.Size(379, 353);
            this.statsDataGrid.TabIndex = 1;
            // 
            // reportBox
            // 
            this.reportBox.FormattingEnabled = true;
            this.reportBox.Items.AddRange(new object[] {
            "Пользователи",
            "Дескрипторы",
            "Определения"});
            this.reportBox.Location = new System.Drawing.Point(165, 16);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(150, 24);
            this.reportBox.TabIndex = 2;
            this.reportBox.SelectedIndexChanged += new System.EventHandler(this.ReportBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Составить отчет для";
            // 
            // loadReport
            // 
            this.loadReport.Location = new System.Drawing.Point(612, 16);
            this.loadReport.Name = "loadReport";
            this.loadReport.Size = new System.Drawing.Size(163, 23);
            this.loadReport.TabIndex = 4;
            this.loadReport.Text = "Выгрузить отчет";
            this.loadReport.UseVisualStyleBackColor = true;
            this.loadReport.Click += new System.EventHandler(this.LoadReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.statsDataGrid);
            this.Controls.Add(this.statsChart);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart statsChart;
        private System.Windows.Forms.DataGridView statsDataGrid;
        private System.Windows.Forms.ComboBox reportBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadReport;
    }
}