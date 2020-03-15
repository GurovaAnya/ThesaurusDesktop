using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DefinitionExtraction
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            User user = new User(firstNameBox.Text, lastNameBox.Text, emailBox.Text, pass1Box.Text);
            if (ProcessTextBoxes())
                if(db.AddUser(user))
                {
                    CurrentSession.CurrentUser = user;
                    this.Close();
                }
                else
                    MessageBox.Show("Произошла ошибка подключения к базе данных. Повторите попытку.");
        }

        private bool ProcessTextBoxes()
        {
            bool validText = true;
            if (firstNameBox.Text==null|| firstNameBox.TextLength < 1) validText = false;
            else if (firstNameBox.TextLength > 20) validText = false;
            if (lastNameBox.Text == null || lastNameBox.TextLength < 1) validText = false;
            else if (lastNameBox.TextLength > 20) validText = false;
            if (pass1Box.Text == null||pass1Box.Text != pass2Box.Text) validText = false;
            if (emailBox.Text==null||!Regex.IsMatch(emailBox.Text, @"\S+@\S+\.\S+")) {validText = false; }
                return validText;
        }

    }
}
