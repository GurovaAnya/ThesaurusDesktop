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
    public partial class AscriptorForm : Form
    {
        public AscriptorForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            DBQueries db = new DBQueries();
            ReturnState rs = db.AddAscriptor((int)descriptorBox.SelectedValue, ascriptorBox.Text);
            if (rs == ReturnState.Success)
                MessageBox.Show("Аскриптор добавлен");
            else if (rs == ReturnState.UniqueConstraintError)
                MessageBox.Show("Данный аскриптор уже существует");
            else
                MessageBox.Show("Ошибка подключения к базе данных");
        }

        private void AscriptorForm_Load(object sender, EventArgs e)
        {
            DBQueries db = new DBQueries();
            descriptorBox.DataSource = db.GetTermins().Tables[0].DefaultView;
            descriptorBox.DisplayMember = "Дескриптор";
            descriptorBox.ValueMember = "id";
        }
    }
}
