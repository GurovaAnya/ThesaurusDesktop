using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitionExtraction
{
    public partial class MainForm : Form
    {
        DB db;

        public MainForm()
        {
            InitializeComponent();
            db = new DB();
            ShowTermins();
        }
        


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Definitions". При необходимости она может быть перемещена или удалена.
           // this.definitionsTableAdapter.Fill(this.dEDatabaseDataSet.Definitions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Descriptors". При необходимости она может быть перемещена или удалена.
            //this.descriptorsTableAdapter.Fill(this.dEDatabaseDataSet.Descriptors);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DescriptorForm df = new DescriptorForm();
            df.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ShowTermins(string like = "")
        {
            terminView.DataSource = db.GetTermins(like).Tables[0].DefaultView;
            terminView.Columns["id"].Visible = false;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ShowTermins(searchBox.Text);
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (terminView.SelectedRows.Count>0)
                for(int i= terminView.SelectedRows.Count-1; i<=0;i++)
                if (db.DeleteTermins(terminView.SelectedRows[i].Cells[1].Value.ToString()))
                    MessageBox.Show("Удалено!");
                else MessageBox.Show("Ошибка подключения к базе данных \nНе удалось удалить элемент "+ terminView.SelectedRows[i].Cells[1].Value.ToString());
            ShowTermins(searchBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTermins();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            
            InfoView.Rows.Clear();
            Termin termin = db.GetTermin((int)terminView.Rows[terminView.SelectedCells[0].RowIndex].Cells["id"].Value);
            
                InfoView.ColumnCount = 1;
                InfoView.Rows.Add(termin.Descriptor);
                if (!string.IsNullOrEmpty(termin.Relator.Trim()))
                    InfoView.Rows.Add("(" + termin.Relator + ")");

                InfoView.Rows.Add("Начало: строка "+termin.StartLine + ", символ: " + termin.StartChar);
                InfoView.Rows.Add("Конец: строка " + termin.StartLine + ", символ: " + termin.StartChar);
            foreach (Definition def in termin.Definitions)
            {
                InfoView.Rows.Add("Определение: " + def.Content);
                InfoView.Rows.Add("Начало: строка " + def.StartLine + ", символ: " + def.StartChar);
                InfoView.Rows.Add("Конец: строка " + def.StartLine + ", символ: " + def.StartChar);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void NameBox_Click(object sender, EventArgs e)
        {
            if (CurrentSession.CurrentUser == null)
            {
                SignInForm sif = new SignInForm();
                sif.Show();

            }

            else if (MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CurrentSession.CurrentUser = null;
        }

        public void OnUserChanged(object sender, EventArgs args)
        {
            if (CurrentSession.CurrentUser!=null)
            this.NameBox.Text = CurrentSession.CurrentUser.FirstName + " " + CurrentSession.CurrentUser.LastName;
            else
                this.NameBox.Text = "Войти";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
