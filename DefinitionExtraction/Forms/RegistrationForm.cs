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
            this.CenterToScreen();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            User user = new User(firstNameBox.Text, lastNameBox.Text, emailBox.Text, pass1Box.Text);
            if (ProcessTextBoxes())
            {
                ReturnState rs = db.AddUser(user);
                if (rs == ReturnState.Success)
                {
                    CurrentSession.CurrentUser = user;
                    this.Close();
                }
                else if(rs == ReturnState.UniqueConstraintError)
                {
                    emailErrorLabel.Text = "Пользователь с таким email уже существует";
                    emailErrorLabel.Visible = true;
                }
                else
                    MessageBox.Show("Произошла ошибка подключения к базе данных. Повторите попытку."); 
            }
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

        private void emailBox_Leave(object sender, EventArgs e)
        {
            emailErrorLabel.Visible = !Regex.IsMatch(emailBox.Text, @"\S+@\S+\.\S+");
            emailErrorLabel.Text = "Неверный формат email";
        }

        private void pass2Box_Leave(object sender, EventArgs e)
        {
            passErrorLabel.Visible = pass1Box.Text != pass2Box.Text;
        }

        private void firstNameBox_Leave(object sender, EventArgs e)
        {
            firstNameErrorLabel.Visible = firstNameBox.Text.Length == 0;
        }

        private void lastNameBox_Leave(object sender, EventArgs e)
        {
            lastNameErrorLabel.Visible = lastNameBox.Text.Length == 0;

        }

        private void pass1Box_Leave(object sender, EventArgs e)
        {
            firstPassErrorLabel.Visible = pass1Box.Text.Length == 0;

        }
    }
}
