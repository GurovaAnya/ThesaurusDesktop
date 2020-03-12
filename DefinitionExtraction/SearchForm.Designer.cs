namespace DefinitionExtraction
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            this.ascriptortypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEDatabaseDataSet = new DefinitionExtraction.DEDatabaseDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QueryGrid = new System.Windows.Forms.DataGridView();
            this.objectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mineColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allTimeBox = new System.Windows.Forms.CheckBox();
            this.mineCheckBox = new System.Windows.Forms.CheckBox();
            this.ObjectBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptorBox = new System.Windows.Forms.ComboBox();
            this.descriptorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RelationTypeBox = new System.Windows.Forms.ComboBox();
            this.relationtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.DescriptorLabel = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptorsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            this.relation_typesTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.Relation_typesTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ascriptortypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationtypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dEDatabaseDataSet
            // 
            this.dEDatabaseDataSet.DataSetName = "DEDatabaseDataSet";
            this.dEDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 124);
            this.dataGridView1.TabIndex = 3;
            // 
            // QueryGrid
            // 
            this.QueryGrid.AllowUserToAddRows = false;
            this.QueryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectColumn,
            this.descriptorColumn,
            this.relationColumn,
            this.mineColumn,
            this.startColumn,
            this.endColumn});
            this.QueryGrid.Location = new System.Drawing.Point(22, 166);
            this.QueryGrid.Name = "QueryGrid";
            this.QueryGrid.ReadOnly = true;
            this.QueryGrid.RowHeadersWidth = 51;
            this.QueryGrid.RowTemplate.Height = 24;
            this.QueryGrid.Size = new System.Drawing.Size(812, 98);
            this.QueryGrid.TabIndex = 6;
            // 
            // objectColumn
            // 
            this.objectColumn.HeaderText = "Сущность";
            this.objectColumn.MinimumWidth = 6;
            this.objectColumn.Name = "objectColumn";
            this.objectColumn.ReadOnly = true;
            this.objectColumn.Width = 125;
            // 
            // descriptorColumn
            // 
            this.descriptorColumn.HeaderText = "Связанный дескриптор";
            this.descriptorColumn.MinimumWidth = 6;
            this.descriptorColumn.Name = "descriptorColumn";
            this.descriptorColumn.ReadOnly = true;
            this.descriptorColumn.Width = 125;
            // 
            // relationColumn
            // 
            this.relationColumn.HeaderText = "Вид связи";
            this.relationColumn.MinimumWidth = 6;
            this.relationColumn.Name = "relationColumn";
            this.relationColumn.ReadOnly = true;
            this.relationColumn.Width = 125;
            // 
            // mineColumn
            // 
            this.mineColumn.HeaderText = "Добавлено мной";
            this.mineColumn.MinimumWidth = 6;
            this.mineColumn.Name = "mineColumn";
            this.mineColumn.ReadOnly = true;
            this.mineColumn.Width = 125;
            // 
            // startColumn
            // 
            this.startColumn.HeaderText = "С";
            this.startColumn.MinimumWidth = 6;
            this.startColumn.Name = "startColumn";
            this.startColumn.ReadOnly = true;
            this.startColumn.Width = 125;
            // 
            // endColumn
            // 
            this.endColumn.HeaderText = "По";
            this.endColumn.MinimumWidth = 6;
            this.endColumn.Name = "endColumn";
            this.endColumn.ReadOnly = true;
            this.endColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Запрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.allTimeBox);
            this.panel1.Controls.Add(this.mineCheckBox);
            this.panel1.Controls.Add(this.ObjectBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EndDateBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StartDateBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DescriptorBox);
            this.panel1.Controls.Add(this.RelationTypeBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DescriptorLabel);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 100);
            this.panel1.TabIndex = 9;
            // 
            // allTimeBox
            // 
            this.allTimeBox.AutoSize = true;
            this.allTimeBox.Location = new System.Drawing.Point(609, 72);
            this.allTimeBox.Name = "allTimeBox";
            this.allTimeBox.Size = new System.Drawing.Size(117, 21);
            this.allTimeBox.TabIndex = 35;
            this.allTimeBox.Text = "За все время";
            this.allTimeBox.UseVisualStyleBackColor = true;
            this.allTimeBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mineCheckBox
            // 
            this.mineCheckBox.AutoSize = true;
            this.mineCheckBox.Location = new System.Drawing.Point(293, 55);
            this.mineCheckBox.Name = "mineCheckBox";
            this.mineCheckBox.Size = new System.Drawing.Size(141, 21);
            this.mineCheckBox.TabIndex = 34;
            this.mineCheckBox.Text = "Добавлено мной";
            this.mineCheckBox.UseVisualStyleBackColor = true;
            // 
            // ObjectBox
            // 
            this.ObjectBox.FormattingEnabled = true;
            this.ObjectBox.Items.AddRange(new object[] {
            "Дескриптор",
            "Аскриптор",
            "Темин",
            "Связь"});
            this.ObjectBox.Location = new System.Drawing.Point(98, 15);
            this.ObjectBox.Name = "ObjectBox";
            this.ObjectBox.Size = new System.Drawing.Size(151, 24);
            this.ObjectBox.TabIndex = 33;
            this.ObjectBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Сущность";
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(661, 43);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(151, 22);
            this.EndDateBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "По";
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(661, 15);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(151, 22);
            this.StartDateBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "С";
            // 
            // DescriptorBox
            // 
            this.DescriptorBox.DataSource = this.descriptorsBindingSource;
            this.DescriptorBox.DisplayMember = "Descriptor_content";
            this.DescriptorBox.FormattingEnabled = true;
            this.DescriptorBox.Location = new System.Drawing.Point(98, 51);
            this.DescriptorBox.Name = "DescriptorBox";
            this.DescriptorBox.Size = new System.Drawing.Size(151, 24);
            this.DescriptorBox.TabIndex = 25;
            this.DescriptorBox.ValueMember = "Descriptor_content";
            // 
            // descriptorsBindingSource1
            // 
            this.descriptorsBindingSource1.DataMember = "Descriptors";
            this.descriptorsBindingSource1.DataSource = this.dEDatabaseDataSet;
            // 
            // RelationTypeBox
            // 
            this.RelationTypeBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.relationtypesBindingSource, "Type_name", true));
            this.RelationTypeBox.DataSource = this.relationtypesBindingSource;
            this.RelationTypeBox.DisplayMember = "Type_name";
            this.RelationTypeBox.FormattingEnabled = true;
            this.RelationTypeBox.Location = new System.Drawing.Point(399, 17);
            this.RelationTypeBox.Name = "RelationTypeBox";
            this.RelationTypeBox.Size = new System.Drawing.Size(151, 24);
            this.RelationTypeBox.TabIndex = 24;
            this.RelationTypeBox.ValueMember = "Type_name";
            this.RelationTypeBox.SelectedIndexChanged += new System.EventHandler(this.RelationTypeBox_SelectedIndexChanged);
            // 
            // relationtypesBindingSource
            // 
            this.relationtypesBindingSource.DataMember = "Relation_types";
            this.relationtypesBindingSource.DataSource = this.dEDatabaseDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Вид связи";
            // 
            // DescriptorLabel
            // 
            this.DescriptorLabel.AutoSize = true;
            this.DescriptorLabel.Location = new System.Drawing.Point(7, 51);
            this.DescriptorLabel.Name = "DescriptorLabel";
            this.DescriptorLabel.Size = new System.Drawing.Size(85, 34);
            this.DescriptorLabel.TabIndex = 22;
            this.DescriptorLabel.Text = "Связанный\r\nдескриптор";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dEDatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // descriptorsBindingSource
            // 
            this.descriptorsBindingSource.DataMember = "Descriptors";
            this.descriptorsBindingSource.DataSource = this.dEDatabaseDataSet;
            // 
            // descriptorsTableAdapter
            // 
            this.descriptorsTableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(342, 118);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить условие";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.Location = new System.Drawing.Point(689, 271);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(145, 23);
            this.QueryButton.TabIndex = 11;
            this.QueryButton.Text = "Выполнить запрос";
            this.QueryButton.UseVisualStyleBackColor = true;
            // 
            // relation_typesTableAdapter
            // 
            this.relation_typesTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.dEDatabaseDataSet;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 447);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QueryGrid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ascriptortypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationtypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DEDatabaseDataSet dEDatabaseDataSet;
        private System.Windows.Forms.BindingSource ascriptortypesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView QueryGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ObjectBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker EndDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker StartDateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DescriptorBox;
        private System.Windows.Forms.ComboBox RelationTypeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label DescriptorLabel;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DEDatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        private DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.BindingSource descriptorsBindingSource1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.BindingSource relationtypesBindingSource;
        private DEDatabaseDataSetTableAdapters.Relation_typesTableAdapter relation_typesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.CheckBox mineCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mineColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endColumn;
        private System.Windows.Forms.CheckBox allTimeBox;
    }
}