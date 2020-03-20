using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitionExtraction.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            allTimeBox.Checked = true;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportBox.SelectedIndex = 0;
        }

        private void UserStatistics()
        {
            DBQueries db = new DBQueries();
            DataView userinfo;
            if (allTimeBox.Checked)
                userinfo = db.GetUserStatistics().Tables[0].DefaultView;
            else userinfo = db.GetUserStatistics(StartDateBox.Value, EndDateBox.Value).Tables[0].DefaultView;
            statsDataGrid.DataSource = userinfo;
            statsChart.DataSource = userinfo;
            statsChart.Series["Users"].XValueMember = "Имя";
            statsChart.Series["Users"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            statsChart.Series["Users"].YValueMembers = "Добавлено определений";
            statsChart.Series["Users"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            statsChart.Visible = true;
            statsDataGrid.Width = this.Width *4/10;
        }

        private void DescriptorStatictics()
        {
            DBQueries db = new DBQueries();
            DataView descInfo;
            if (allTimeBox.Checked)
                descInfo = db.GetDescStatistics().Tables[0].DefaultView;
            else descInfo = db.GetDescStatistics(StartDateBox.Value, EndDateBox.Value).Tables[0].DefaultView;
            statsDataGrid.DataSource = descInfo;
            statsChart.Visible = false;
            statsDataGrid.Width =this.Width*9/10;
        }

        private void ReportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStats();
        }

        private void LoadReport_Click(object sender, EventArgs e)
        {
            if (statsDataGrid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < statsDataGrid.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = statsDataGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < statsDataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < statsDataGrid.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = statsDataGrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void allTimeBox_CheckedChanged(object sender, EventArgs e)
        {
            StartDateBox.Enabled = !allTimeBox.Checked;
            EndDateBox.Enabled = !allTimeBox.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            GetStats();   
        }

        private void GetStats()
        {
            if (reportBox.SelectedItem.ToString() == "Пользователи")
                UserStatistics();
            else DescriptorStatictics();
        }
    }
}
