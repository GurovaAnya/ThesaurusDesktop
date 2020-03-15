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
    public partial class DescriptorForm : Form
    {
        public int id;
        public bool Changing = false;
        public Termin Termin { get; set; }
        public Definition Definition { get; set; }
        public DescriptorForm()
        {
            InitializeComponent();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
                if (Changing)
                    Change();
                else Add();
                   
        }

        private void Change()
        {
            using (DB db = new DB())
            {
                if (db.ChangeDescription(id, descriptorBox.Text,
                        Int32.Parse(startLineD.Text), Int32.Parse(StartCharD.Text), Int32.Parse(EndLineD.Text), Int32.Parse(EndCharD.Text),
                        DefinitionBox.Text,
                        Int32.Parse(StartLineBox.Text), Int32.Parse(StartCharBox.Text), Int32.Parse(EndLineBox.Text), Int32.Parse(EndCharBox.Text),
                        RelatorBox.Text))
                    MessageBox.Show("Определение изменено!");
                else
                    MessageBox.Show("Ошибка подключения к базе данных");
            }
        }

        private void Add()
        {
            using (DB db = new DB())
            {
                if (db.AddDescriptor(descriptorBox.Text,
                        Int32.Parse(startLineD.Text), Int32.Parse(StartCharD.Text), Int32.Parse(EndLineD.Text), Int32.Parse(EndCharD.Text),
                        DefinitionBox.Text,
                        Int32.Parse(StartLineBox.Text), Int32.Parse(StartCharBox.Text), Int32.Parse(EndLineBox.Text), Int32.Parse(EndCharBox.Text),
                        RelatorBox.Text))
                    MessageBox.Show("Определение добавлено!");
                else
                    MessageBox.Show("Ошибка подключения к базе данных");
            }
        }

        private bool CheckFields()
        {
            return true;
        }

        private void DescriptorForm_Load(object sender, EventArgs e)
        {
            if (Termin != null)
            {
                Changing = true;
                descriptorBox.Text = Termin.Descriptor;
                RelatorBox.Text = Termin.Relator;
                StartLineBox.Text = Termin.StartLine.ToString();
                StartCharBox.Text = Termin.StartChar.ToString();
                EndLineBox.Text = Termin.EndLine.ToString();
                EndCharBox.Text = Termin.EndChar.ToString();
                DefinitionBox.Text = Definition.Content;
                startLineD.Text = Definition.StartLine.ToString();
                StartCharD.Text = Definition.StartChar.ToString();
                EndLineD.Text = Definition.EndLine.ToString();
                EndCharD.Text = Definition.EndChar.ToString();
            }
        }
    }
}
