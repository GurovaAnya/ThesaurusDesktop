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
    public partial class SearchForm : Form
    {
        Query query;
        public SearchForm()
        {
            InitializeComponent();
            DBQueries db = new DBQueries();
            DescriptorBox.DataSource = db.GetTermins().Tables[0].DefaultView;
            DescriptorBox.DisplayMember = "Дескриптор";
            DescriptorBox.ValueMember = "id";
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Relation_types". При необходимости она может быть перемещена или удалена.
            this.relation_typesTableAdapter.Fill(this.dEDatabaseDataSet.Relation_types);
            mineCheckBox.Visible = CurrentSession.CurrentUser != null;
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem.ToString() == "Дескриптор")
                RelationTypeBox.Enabled = true;
            else RelationTypeBox.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {

                if (allTimeBox.Checked) 
                    query = new Query((int)DescriptorBox.SelectedValue, (int)RelationTypeBox.SelectedValue, mineCheckBox.Checked);
                else
                    query= new Query((int)DescriptorBox.SelectedValue, (int)RelationTypeBox.SelectedValue, 
                        mineCheckBox.Checked, StartDateBox.Value, EndDateBox.Value);

                List<Termin> termins = new List<Termin>();
                DBQueries db = new DBQueries();
                termins = db.DescriptorComplexQuery(query);
                ShowInfo(termins);

            }
        }

        private bool CheckFields()
        {
            return true;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            StartDateBox.Enabled = !allTimeBox.Checked;
            EndDateBox.Enabled = !allTimeBox.Checked;
        }


        private void ShowInfo(List<Termin> termins)
        {
            answersPanel.Controls.Clear();
            if (termins.Count == 0)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text = "Поиск не дал результатов";
                answersPanel.Controls.Add(label);
                return;
            }
            foreach (Termin termin in termins)
            {
                foreach (Definition def in termin.Definitions)
                {
                    TerminControl tc = new TerminControl
                    {
                        Descriptor = termin.Descriptor,
                        Definition = def.Content,
                        Ascriptors = termin.Ascriptors,
                        definitionId = def.ID,
                        DefinitionLocation = new int[] { def.StartLine, def.StartChar, def.EndLine, def.EndChar },
                        DescriptorLocation = new int[] { termin.StartLine, termin.StartChar, termin.EndLine, termin.EndChar },
                        Relations = termin.Relations,
                        Links = def.Links
                    };
                    answersPanel.Controls.Add(tc);
                }
            }
        }
    }
}
