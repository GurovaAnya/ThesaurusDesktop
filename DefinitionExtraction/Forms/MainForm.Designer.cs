﻿namespace DefinitionExtraction
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТолькоДескрипторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТолькоАскрипторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеТерминыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddSynonymButton = new System.Windows.Forms.Button();
            this.addRelationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.terminView = new System.Windows.Forms.DataGridView();
            this.ClearButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteDefinitionButton = new System.Windows.Forms.Button();
            this.answersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.Label();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.definitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terminView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьТолькоДескрипторыToolStripMenuItem,
            this.показатьТолькоАскрипторыToolStripMenuItem,
            this.показатьВсеТерминыToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // показатьТолькоДескрипторыToolStripMenuItem
            // 
            this.показатьТолькоДескрипторыToolStripMenuItem.Name = "показатьТолькоДескрипторыToolStripMenuItem";
            this.показатьТолькоДескрипторыToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.показатьТолькоДескрипторыToolStripMenuItem.Text = "Показать только дескрипторы";
            // 
            // показатьТолькоАскрипторыToolStripMenuItem
            // 
            this.показатьТолькоАскрипторыToolStripMenuItem.Name = "показатьТолькоАскрипторыToolStripMenuItem";
            this.показатьТолькоАскрипторыToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.показатьТолькоАскрипторыToolStripMenuItem.Text = "Показать только аскрипторы";
            // 
            // показатьВсеТерминыToolStripMenuItem
            // 
            this.показатьВсеТерминыToolStripMenuItem.Name = "показатьВсеТерминыToolStripMenuItem";
            this.показатьВсеТерминыToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.показатьВсеТерминыToolStripMenuItem.Text = "Показать все термины";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьОтчетToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // показатьОтчетToolStripMenuItem
            // 
            this.показатьОтчетToolStripMenuItem.Name = "показатьОтчетToolStripMenuItem";
            this.показатьОтчетToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.показатьОтчетToolStripMenuItem.Text = "Показать отчет";
            this.показатьОтчетToolStripMenuItem.Click += new System.EventHandler(this.ПоказатьОтчетToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(828, 101);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(98, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить...";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(828, 43);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AddSynonymButton);
            this.panel1.Controls.Add(this.addRelationButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.InfoButton);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.terminView);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 544);
            this.panel1.TabIndex = 13;
            // 
            // AddSynonymButton
            // 
            this.AddSynonymButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSynonymButton.Enabled = false;
            this.AddSynonymButton.Location = new System.Drawing.Point(829, 179);
            this.AddSynonymButton.Name = "AddSynonymButton";
            this.AddSynonymButton.Size = new System.Drawing.Size(98, 43);
            this.AddSynonymButton.TabIndex = 21;
            this.AddSynonymButton.Text = "Добавить\r\nсиноним\r\n\r\n";
            this.AddSynonymButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSynonymButton.UseVisualStyleBackColor = true;
            this.AddSynonymButton.Click += new System.EventHandler(this.AddSynonymButton_Click);
            // 
            // addRelationButton
            // 
            this.addRelationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRelationButton.Enabled = false;
            this.addRelationButton.Location = new System.Drawing.Point(829, 130);
            this.addRelationButton.Name = "addRelationButton";
            this.addRelationButton.Size = new System.Drawing.Size(98, 43);
            this.addRelationButton.TabIndex = 18;
            this.addRelationButton.Text = "Добавить\r\nотношение\r\n";
            this.addRelationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRelationButton.UseVisualStyleBackColor = true;
            this.addRelationButton.Click += new System.EventHandler(this.AddRelationButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoButton.Location = new System.Drawing.Point(828, 314);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(98, 23);
            this.InfoButton.TabIndex = 14;
            this.InfoButton.Text = "Подробнее";
            this.InfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(759, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Расширенный поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // terminView
            // 
            this.terminView.AllowUserToAddRows = false;
            this.terminView.AllowUserToDeleteRows = false;
            this.terminView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminView.Location = new System.Drawing.Point(0, 43);
            this.terminView.Name = "terminView";
            this.terminView.ReadOnly = true;
            this.terminView.RowHeadersWidth = 51;
            this.terminView.RowTemplate.Height = 24;
            this.terminView.Size = new System.Drawing.Size(822, 294);
            this.terminView.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(397, 10);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Сбросить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(32, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(293, 22);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.deleteDefinitionButton);
            this.panel3.Controls.Add(this.answersPanel);
            this.panel3.Controls.Add(this.ChangeButton);
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 200);
            this.panel3.TabIndex = 20;
            // 
            // deleteDefinitionButton
            // 
            this.deleteDefinitionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteDefinitionButton.Enabled = false;
            this.deleteDefinitionButton.Location = new System.Drawing.Point(828, 35);
            this.deleteDefinitionButton.Name = "deleteDefinitionButton";
            this.deleteDefinitionButton.Size = new System.Drawing.Size(103, 44);
            this.deleteDefinitionButton.TabIndex = 23;
            this.deleteDefinitionButton.Text = "Удалить\r\nопределение\r\n";
            this.deleteDefinitionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDefinitionButton.UseVisualStyleBackColor = true;
            this.deleteDefinitionButton.Click += new System.EventHandler(this.DeleteDefinitionButton_Click);
            // 
            // answersPanel
            // 
            this.answersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answersPanel.Location = new System.Drawing.Point(3, 6);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(819, 180);
            this.answersPanel.TabIndex = 22;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeButton.Enabled = false;
            this.ChangeButton.Location = new System.Drawing.Point(828, 6);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(103, 23);
            this.ChangeButton.TabIndex = 20;
            this.ChangeButton.Text = "Изменить...";
            this.ChangeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Location = new System.Drawing.Point(758, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 40);
            this.panel2.TabIndex = 14;
            this.panel2.Click += new System.EventHandler(this.NameBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.NameBox_Click);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.AutoSize = true;
            this.NameBox.Location = new System.Drawing.Point(15, 9);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(48, 17);
            this.NameBox.TabIndex = 12;
            this.NameBox.Text = "Войти";
            this.NameBox.Click += new System.EventHandler(this.NameBox_Click);
            // 
            // descriptorsBindingSource
            // 
            this.descriptorsBindingSource.DataMember = "Descriptors";
            // 
            // descriptorsBindingSource1
            // 
            this.descriptorsBindingSource1.DataMember = "Descriptors";
            // 
            // definitionsBindingSource
            // 
            this.definitionsBindingSource.DataMember = "Definitions";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.terminView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        //private DEDatabaseDataSet dEDatabaseDataSet;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        //private DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView terminView;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТолькоДескрипторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТолькоАскрипторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеТерминыToolStripMenuItem;
        private System.Windows.Forms.BindingSource descriptorsBindingSource1;
        private System.Windows.Forms.BindingSource definitionsBindingSource;
        //private DEDatabaseDataSetTableAdapters.DefinitionsTableAdapter definitionsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button addRelationButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel answersPanel;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button deleteDefinitionButton;
        private System.Windows.Forms.ToolStripMenuItem показатьОтчетToolStripMenuItem;
        private System.Windows.Forms.Button AddSynonymButton;
    }
}

