namespace DefinitionExtraction
{
    partial class SearchBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEDatabaseDataSet = new DefinitionExtraction.DEDatabaseDataSet();
            this.definitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.definitionsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DefinitionsTableAdapter();
            this.descriptorsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Type_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(377, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Type_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид связи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Термин";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.descriptorsBindingSource;
            this.comboBox3.DisplayMember = "Descriptor_content";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(90, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 24);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "Descriptor_content";
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
            // definitionsBindingSource
            // 
            this.definitionsBindingSource.DataMember = "Definitions";
            this.definitionsBindingSource.DataSource = this.dEDatabaseDataSet;
            // 
            // definitionsTableAdapter
            // 
            this.definitionsTableAdapter.ClearBeforeFill = true;
            // 
            // descriptorsTableAdapter
            // 
            this.descriptorsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "С";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(610, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(610, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "По";
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Type_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(377, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "Type_name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Пользователь";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.descriptorsBindingSource;
            this.comboBox4.DisplayMember = "Descriptor_content";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(90, 11);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 24);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "Descriptor_content";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Сущность";
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(782, 87);
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        private DEDatabaseDataSet dEDatabaseDataSet;
        private System.Windows.Forms.BindingSource definitionsBindingSource;
        private DEDatabaseDataSetTableAdapters.DefinitionsTableAdapter definitionsTableAdapter;
        private DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
    }
}
