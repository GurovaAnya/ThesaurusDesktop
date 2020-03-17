namespace DefinitionExtraction
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.pass2Box = new System.Windows.Forms.TextBox();
            this.pass1Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.firstPassErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(146, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Регистрация";
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(156, 337);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(111, 23);
            this.logInButton.TabIndex = 13;
            this.logInButton.Text = "Регистрация";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // pass2Box
            // 
            this.pass2Box.Location = new System.Drawing.Point(159, 275);
            this.pass2Box.Name = "pass2Box";
            this.pass2Box.Size = new System.Drawing.Size(278, 22);
            this.pass2Box.TabIndex = 12;
            this.pass2Box.Leave += new System.EventHandler(this.Pass2Box_Leave);
            // 
            // pass1Box
            // 
            this.pass1Box.Location = new System.Drawing.Point(159, 225);
            this.pass1Box.Name = "pass1Box";
            this.pass1Box.Size = new System.Drawing.Size(278, 22);
            this.pass1Box.TabIndex = 11;
            this.pass1Box.Leave += new System.EventHandler(this.Pass1Box_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Повторите пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пароль";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(159, 77);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(278, 22);
            this.firstNameBox.TabIndex = 18;
            this.firstNameBox.Leave += new System.EventHandler(this.FirstNameBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(159, 125);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(278, 22);
            this.lastNameBox.TabIndex = 20;
            this.lastNameBox.Leave += new System.EventHandler(this.LastNameBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Фамилия";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(159, 173);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(278, 22);
            this.emailBox.TabIndex = 22;
            this.emailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Email";
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(152, 198);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(167, 17);
            this.emailErrorLabel.TabIndex = 23;
            this.emailErrorLabel.Text = "Неверный формат email";
            this.emailErrorLabel.Visible = false;
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passErrorLabel.Location = new System.Drawing.Point(159, 305);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(153, 17);
            this.passErrorLabel.TabIndex = 24;
            this.passErrorLabel.Text = "Пароли не совпадают";
            this.passErrorLabel.Visible = false;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.AutoSize = true;
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(159, 102);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(137, 17);
            this.firstNameErrorLabel.TabIndex = 25;
            this.firstNameErrorLabel.Text = "Поле не заполнено";
            this.firstNameErrorLabel.Visible = false;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.AutoSize = true;
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(159, 153);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(137, 17);
            this.lastNameErrorLabel.TabIndex = 26;
            this.lastNameErrorLabel.Text = "Поле не заполнено";
            this.lastNameErrorLabel.Visible = false;
            // 
            // firstPassErrorLabel
            // 
            this.firstPassErrorLabel.AutoSize = true;
            this.firstPassErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstPassErrorLabel.Location = new System.Drawing.Point(159, 250);
            this.firstPassErrorLabel.Name = "firstPassErrorLabel";
            this.firstPassErrorLabel.Size = new System.Drawing.Size(137, 17);
            this.firstPassErrorLabel.TabIndex = 27;
            this.firstPassErrorLabel.Text = "Поле не заполнено";
            this.firstPassErrorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 388);
            this.Controls.Add(this.firstPassErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.passErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.pass2Box);
            this.Controls.Add(this.pass1Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox pass2Box;
        private System.Windows.Forms.TextBox pass1Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstPassErrorLabel;
    }
}