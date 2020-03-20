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
    public partial class ChoseDecsriptorForm : Form
    {
        public int DefinitionId { get; set; }
        //public int DescriptorID { get; set; }
        public int StartChar { get; set; }
        public ChoseDecsriptorForm()
        {
            InitializeComponent();
            
        }

        private void ChoseDecsriptorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dEDatabaseDataSet.Descriptors". При необходимости она может быть перемещена или удалена.
            //this.descriptorsTableAdapter.Fill(this.dEDatabaseDataSet.Descriptors);
            DBQueries dB = new DBQueries();
            comboBox1.DataSource = dB.GetTermins().Tables[0];
            comboBox1.DisplayMember = "Дескриптор";
            comboBox1.ValueMember = "id";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DBQueries db = new DBQueries();
            db.AddLink(DefinitionId, (int)comboBox1.SelectedValue, StartChar);
        }
    }
}
