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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allTimeBox = new System.Windows.Forms.CheckBox();
            this.mineCheckBox = new System.Windows.Forms.CheckBox();
            this.EndDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptorBox = new System.Windows.Forms.ComboBox();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEDatabaseDataSet = new DefinitionExtraction.DEDatabaseDataSet();
            this.RelationTypeBox = new System.Windows.Forms.ComboBox();
            this.relationtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.DescriptorLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.descriptorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.UsersTableAdapter();
            this.descriptorsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter();
            this.relation_typesTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.Relation_typesTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ascriptortypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationtypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascriptortypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.allTimeBox);
            this.panel1.Controls.Add(this.mineCheckBox);
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
            this.panel1.Size = new System.Drawing.Size(820, 100);
            this.panel1.TabIndex = 9;
            // 
            // allTimeBox
            // 
            this.allTimeBox.AutoSize = true;
            this.allTimeBox.Location = new System.Drawing.Point(609, 72);
            this.allTimeBox.Name = "allTimeBox";
            this.allTimeBox.Size = new System.Drawing.Size(107, 19);
            this.allTimeBox.TabIndex = 35;
            this.allTimeBox.Text = "За все время";
            this.allTimeBox.UseVisualStyleBackColor = true;
            this.allTimeBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // mineCheckBox
            // 
            this.mineCheckBox.AutoSize = true;
            this.mineCheckBox.Location = new System.Drawing.Point(293, 55);
            this.mineCheckBox.Name = "mineCheckBox";
            this.mineCheckBox.Size = new System.Drawing.Size(127, 19);
            this.mineCheckBox.TabIndex = 34;
            this.mineCheckBox.Text = "Добавлено мной";
            this.mineCheckBox.UseVisualStyleBackColor = true;
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(661, 43);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(151, 20);
            this.EndDateBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "По";
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(661, 15);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(151, 20);
            this.StartDateBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "С";
            // 
            // DescriptorBox
            // 
            this.DescriptorBox.DataSource = this.descriptorsBindingSource;
            this.DescriptorBox.DisplayMember = "Descriptor_content";
            this.DescriptorBox.FormattingEnabled = true;
            this.DescriptorBox.Location = new System.Drawing.Point(98, 18);
            this.DescriptorBox.Name = "DescriptorBox";
            this.DescriptorBox.Size = new System.Drawing.Size(151, 24);
            this.DescriptorBox.TabIndex = 25;
            this.DescriptorBox.ValueMember = "ID";
            // 
            // descriptorsBindingSource
            // 
            this.descriptorsBindingSource.DataMember = "Descriptors";
            this.descriptorsBindingSource.DataSource = this.dEDatabaseDataSet;
            // 
            // dEDatabaseDataSet
            // 
            this.dEDatabaseDataSet.DataSetName = "DEDatabaseDataSet";
            this.dEDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.RelationTypeBox.ValueMember = "ID";
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
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Вид связи";
            // 
            // DescriptorLabel
            // 
            this.DescriptorLabel.AutoSize = true;
            this.DescriptorLabel.Location = new System.Drawing.Point(7, 18);
            this.DescriptorLabel.Name = "DescriptorLabel";
            this.DescriptorLabel.Size = new System.Drawing.Size(75, 30);
            this.DescriptorLabel.TabIndex = 22;
            this.DescriptorLabel.Text = "Связанный\r\nдескриптор";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(342, 118);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Найти";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // descriptorsBindingSource1
            // 
            this.descriptorsBindingSource1.DataMember = "Descriptors";
            this.descriptorsBindingSource1.DataSource = this.dEDatabaseDataSet;
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
            // descriptorsTableAdapter
            // 
            this.descriptorsTableAdapter.ClearBeforeFill = true;
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
            // answersPanel
            // 
            this.answersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answersPanel.AutoScroll = true;
            this.answersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.answersPanel.Location = new System.Drawing.Point(22, 187);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(812, 248);
            this.answersPanel.TabIndex = 12;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 447);
            this.Controls.Add(this.answersPanel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationtypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ascriptortypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DEDatabaseDataSet dEDatabaseDataSet;
        private System.Windows.Forms.BindingSource ascriptortypesBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.BindingSource relationtypesBindingSource;
        private DEDatabaseDataSetTableAdapters.Relation_typesTableAdapter relation_typesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.CheckBox mineCheckBox;
        private System.Windows.Forms.CheckBox allTimeBox;
        private System.Windows.Forms.FlowLayoutPanel answersPanel;
    }
}