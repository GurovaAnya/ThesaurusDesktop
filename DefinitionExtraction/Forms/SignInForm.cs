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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void LogInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            DBQueries db = new DBQueries();
            User user = new User(loginBox.Text, passwordBox.Text);
            if (db.LogIn(user)&& user.RightPass(passwordBox.Text))
            {
                    CurrentSession.CurrentUser = user;
                    this.Close();
                    this.Hide();
            }
            else 
                errorLabel.Text= "Неверный логин или пароль";
        }
    }
}
