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
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportBox.SelectedIndex = 0;
        }

        private void UserStatistics()
        {
            using (DB db = new DB())
            {
                DataView userinfo = db.GetUserStatistics().Tables[0].DefaultView;
                statsDataGrid.DataSource = userinfo;
                statsChart.DataSource = userinfo;
                statsChart.Series["Users"].XValueMember = "Имя";
                statsChart.Series["Users"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                statsChart.Series["Users"].YValueMembers = "Добавлено определений";
                statsChart.Series["Users"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
        }

        private void ReportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportBox.SelectedItem.ToString() == "Пользователи")
                UserStatistics();
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
    }
}
