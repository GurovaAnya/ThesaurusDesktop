﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            answersPanel.Controls.Clear();
            Termin termin = db.GetTermin((int)terminView.Rows[terminView.SelectedCells[0].RowIndex].Cells["id"].Value);
            foreach(Definition def in termin.Definitions)
            {
                TerminControl tc = new TerminControl();
                tc.Descriptor = termin.Descriptor;
                tc.Definition = def.Content;
                tc.Ascriptors = termin.Ascriptors;
                tc.definitionId = def.ID;
                tc.DefinitionLocation = new int[] { def.StartLine, def.StartChar, def.EndLine, def.EndChar };
                tc.DescriptorLocation = new int[] { termin.StartLine, termin.StartChar, termin.EndLine, termin.EndChar };
                tc.Click += new EventHandler(ItemClick);
                answersPanel.Controls.Add(tc);
            }
            ItemClick(answersPanel.Controls[0], null);
            ChangeButton.Enabled = CurrentSession.CurrentUser != null;
        }

        private TerminControl CheckedItem;
        private void ItemClick(object sender, EventArgs e)
        {
            if (CheckedItem != null)
                CheckedItem.BorderStyle = BorderStyle.FixedSingle;
            CheckedItem = (TerminControl)sender;
            CheckedItem.BorderStyle = BorderStyle.Fixed3D;
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
            bool reg = CurrentSession.CurrentUser != null;
            if (reg)
            {
                this.NameBox.Text = CurrentSession.CurrentUser.FirstName + " " + CurrentSession.CurrentUser.LastName;
            }
            else
                this.NameBox.Text = "Войти";
            DeleteButton.Enabled = reg;
            AddButton.Enabled = reg;
            ChangeButton.Enabled = reg;
            addRelationButton.Enabled = reg;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRelationButton_Click(object sender, EventArgs e)
        {
            AddRelationForm arf = new AddRelationForm();
            arf.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //answersPanel.Controls;
            DescriptorForm df = new DescriptorForm();
            Termin t = new Termin()
            {
                Descriptor = CheckedItem.Descriptor,
                StartLine = CheckedItem.DescriptorLocation[0],
                StartChar = CheckedItem.DescriptorLocation[1],
                EndLine = CheckedItem.DescriptorLocation[2],
                EndChar = CheckedItem.DescriptorLocation[3]
            };
            df.Termin = t;
            Definition d = new Definition()
            {
                ID = CheckedItem.definitionId,
                Content = CheckedItem.Definition,
                StartLine = CheckedItem.DefinitionLocation[0],
                StartChar = CheckedItem.DefinitionLocation[1],
                EndLine = CheckedItem.DefinitionLocation[2],
                EndChar = CheckedItem.DefinitionLocation[3]
            };
            df.id = CheckedItem.definitionId;
            df.Definition = d;
            df.Show();
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    MessageBox.Show("Добавлено определений: "+ ExcelProc.ExcelP(filePath));
                }
            }
            ShowTermins();
        }
    }
}