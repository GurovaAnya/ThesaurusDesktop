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
        //List<Query> queries = new List<Query>();
        Query query;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Relation_types". При необходимости она может быть перемещена или удалена.
            this.relation_typesTableAdapter.Fill(this.dEDatabaseDataSet.Relation_types);
            this.descriptorsTableAdapter.Fill(this.dEDatabaseDataSet.Descriptors);
            mineCheckBox.Visible = CurrentSession.CurrentUser != null;
            QueryGrid.Columns["mineColumn"].Visible = CurrentSession.CurrentUser != null;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem.ToString() == "Дескриптор")
                RelationTypeBox.Enabled = true;
            else RelationTypeBox.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (CheckFields())
            {
                QueryGrid.Rows.Add();
                QueryGrid.Rows[0].Cells["objectColumn"].Value = ObjectBox.SelectedItem;
                QueryGrid.Rows[0].Cells["descriptorColumn"].Value = DescriptorBox.SelectedItem;
                QueryGrid.Rows[0].Cells["relationColumn"].Value = RelationTypeBox.SelectedItem;
                QueryGrid.Rows[0].Cells["mineColumn"].Value = mineCheckBox.Checked;

                if (allTimeBox.Checked) 
                {
                    query = new Query((ObjectType)Enum.Parse(typeof(ObjectType), ObjectBox.SelectedItem.ToString(), true),
                        (int)DescriptorBox.SelectedValue, (int)RelationTypeBox.SelectedValue, mineCheckBox.Checked);
                    QueryGrid.Rows[0].Cells["startColumn"].Value = string.Empty;
                    QueryGrid.Rows[0].Cells["endColumn"].Value = string.Empty;
                }
                else
                {
                    query= new Query((ObjectType)Enum.Parse(typeof(ObjectType), ObjectBox.SelectedItem.ToString(), true),
                        (int)DescriptorBox.SelectedValue, (int)RelationTypeBox.SelectedValue, 
                        mineCheckBox.Checked, StartDateBox.Value, EndDateBox.Value);
                    
                    QueryGrid.Rows[0].Cells["startColumn"].Value = StartDateBox.Value;
                    QueryGrid.Rows[0].Cells["endColumn"].Value = EndDateBox.Value;
                }

            }
        }

        private bool CheckFields()
        {
            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            StartDateBox.Enabled = !allTimeBox.Checked;
            EndDateBox.Enabled = !allTimeBox.Checked;
        }

        private void RelationTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            List<Termin> termins;
            if(QueryGrid.Rows[0].Cells["objectColumn"].Value.ToString()=="Дескриптор")
            using (DB db = new DB())
            {
                termins= db.DescriptorComplexQuery(query);
                ShowInfo(termins);
            }
        }

        private void ShowInfo(List<Termin> termins)
        {
            answersPanel.Controls.Clear();
            if (termins.Count == 0)
            {
                MessageBox.Show("Поиск не дал результатов");
                return;
            }
            foreach (Termin termin in termins)
            {
                foreach (Definition def in termin.Definitions)
                {
                    TerminControl tc = new TerminControl();
                    tc.Descriptor = termin.Descriptor;
                    tc.Definition = def.Content;
                    tc.Ascriptors = termin.Ascriptors;
                    tc.definitionId = def.ID;
                    tc.DefinitionLocation = new int[] { def.StartLine, def.StartChar, def.EndLine, def.EndChar };
                    tc.DescriptorLocation = new int[] { termin.StartLine, termin.StartChar, termin.EndLine, termin.EndChar };
                    answersPanel.Controls.Add(tc);
                }
            }
        }
    }
}
