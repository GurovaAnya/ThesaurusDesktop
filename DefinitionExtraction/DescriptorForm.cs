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
        public DescriptorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (CheckFields())
                if (db.AddDescriptor(descriptorBox.Text, 
                    Int32.Parse(startLineD.Text), Int32.Parse(StartCharD.Text), Int32.Parse(EndLineD.Text), Int32.Parse(EndCharD.Text),
                    DescriptionBox.Text,
                    Int32.Parse(StartLineBox.Text), Int32.Parse(StartCharBox.Text), Int32.Parse(EndLineBox.Text), Int32.Parse(EndCharBox.Text),
                    RelatorBox.Text))
                    MessageBox.Show("Определение добавлено!");
                else
                    MessageBox.Show("Ошибка подключения к базе данных");
                
        }

        private bool CheckFields()
        {
            return true;
        }
    }
}
