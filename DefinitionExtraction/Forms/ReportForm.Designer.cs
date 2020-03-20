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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statsDataGrid = new System.Windows.Forms.DataGridView();
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadReport = new System.Windows.Forms.Button();
            this.allTimeBox = new System.Windows.Forms.CheckBox();
            this.EndDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.statsChart.Legends.Add(legend2);
            this.statsChart.Location = new System.Drawing.Point(416, 149);
            this.statsChart.Name = "statsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Users";
            this.statsChart.Series.Add(series2);
            this.statsChart.Size = new System.Drawing.Size(372, 375);
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
            this.statsDataGrid.Location = new System.Drawing.Point(16, 149);
            this.statsDataGrid.Name = "statsDataGrid";
            this.statsDataGrid.ReadOnly = true;
            this.statsDataGrid.RowHeadersWidth = 51;
            this.statsDataGrid.RowTemplate.Height = 24;
            this.statsDataGrid.Size = new System.Drawing.Size(379, 375);
            this.statsDataGrid.TabIndex = 1;
            // 
            // reportBox
            // 
            this.reportBox.FormattingEnabled = true;
            this.reportBox.Items.AddRange(new object[] {
            "Пользователи",
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
            // allTimeBox
            // 
            this.allTimeBox.AutoSize = true;
            this.allTimeBox.Location = new System.Drawing.Point(19, 106);
            this.allTimeBox.Name = "allTimeBox";
            this.allTimeBox.Size = new System.Drawing.Size(117, 21);
            this.allTimeBox.TabIndex = 40;
            this.allTimeBox.Text = "За все время";
            this.allTimeBox.UseVisualStyleBackColor = true;
            this.allTimeBox.CheckedChanged += new System.EventHandler(this.allTimeBox_CheckedChanged);
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(71, 77);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(151, 22);
            this.EndDateBox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "По";
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(71, 49);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(151, 22);
            this.StartDateBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "С";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(349, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 41;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.allTimeBox);
            this.Controls.Add(this.EndDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartDateBox);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.CheckBox allTimeBox;
        private System.Windows.Forms.DateTimePicker EndDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker StartDateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
    }
}