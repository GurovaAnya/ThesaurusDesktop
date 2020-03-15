﻿using System;
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
    public partial class AddRelationForm : Form
    {
        public AddRelationForm()
        {
            InitializeComponent();
        }

        private void AddRelationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Relation_types". При необходимости она может быть перемещена или удалена.
            this.relation_typesTableAdapter.Fill(this.dEDatabaseDataSet.Relation_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Descriptors". При необходимости она может быть перемещена или удалена.
            this.descriptorsTableAdapter.Fill(this.dEDatabaseDataSet.Descriptors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Definitions". При необходимости она может быть перемещена или удалена.
            this.definitionsTableAdapter.Fill(this.dEDatabaseDataSet.Definitions);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (DB db = new DB())
            {
                if (db.AddRelation((int)descriptor1Box.SelectedValue, (int)descriptor2Box.SelectedValue, (int)relationBox.SelectedValue)) ;
            }
        }
    }
}
