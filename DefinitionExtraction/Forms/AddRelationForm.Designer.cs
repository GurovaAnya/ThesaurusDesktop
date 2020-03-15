namespace DefinitionExtraction
{
    partial class AddRelationForm
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
            this.descriptor1Box = new System.Windows.Forms.ComboBox();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEDatabaseDataSet = new DefinitionExtraction.DEDatabaseDataSet();
            this.relationBox = new System.Windows.Forms.ComboBox();
            this.relationtypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptor2Box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.definitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.definitionsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DefinitionsTableAdapter();
            this.descriptorsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter();
            this.relation_typesTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.Relation_typesTableAdapter();
            this.descriptorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationtypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptor1Box
            // 
            this.descriptor1Box.DataSource = this.descriptorsBindingSource;
            this.descriptor1Box.DisplayMember = "Descriptor_content";
            this.descriptor1Box.FormattingEnabled = true;
            this.descriptor1Box.Location = new System.Drawing.Point(25, 71);
            this.descriptor1Box.Name = "descriptor1Box";
            this.descriptor1Box.Size = new System.Drawing.Size(121, 24);
            this.descriptor1Box.TabIndex = 0;
            this.descriptor1Box.ValueMember = "ID";
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
            // relationBox
            // 
            this.relationBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.relationtypesBindingSource, "ID", true));
            this.relationBox.DataSource = this.relationtypesBindingSource;
            this.relationBox.DisplayMember = "Type_name";
            this.relationBox.FormattingEnabled = true;
            this.relationBox.Location = new System.Drawing.Point(179, 71);
            this.relationBox.Name = "relationBox";
            this.relationBox.Size = new System.Drawing.Size(121, 24);
            this.relationBox.TabIndex = 1;
            this.relationBox.ValueMember = "ID";
            // 
            // relationtypesBindingSource
            // 
            this.relationtypesBindingSource.DataMember = "Relation_types";
            this.relationtypesBindingSource.DataSource = this.dEDatabaseDataSet;
            // 
            // descriptor2Box
            // 
            this.descriptor2Box.DataSource = this.descriptorsBindingSource1;
            this.descriptor2Box.DisplayMember = "Descriptor_content";
            this.descriptor2Box.FormattingEnabled = true;
            this.descriptor2Box.Location = new System.Drawing.Point(338, 71);
            this.descriptor2Box.Name = "descriptor2Box";
            this.descriptor2Box.Size = new System.Drawing.Size(121, 24);
            this.descriptor2Box.TabIndex = 2;
            this.descriptor2Box.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Добавить отношение";
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
            // relation_typesTableAdapter
            // 
            this.relation_typesTableAdapter.ClearBeforeFill = true;
            // 
            // descriptorsBindingSource1
            // 
            this.descriptorsBindingSource1.DataMember = "Descriptors";
            this.descriptorsBindingSource1.DataSource = this.dEDatabaseDataSet;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(200, 111);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 23);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 146);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptor2Box);
            this.Controls.Add(this.relationBox);
            this.Controls.Add(this.descriptor1Box);
            this.Name = "AddRelationForm";
            this.Text = "AddRelationForm";
            this.Load += new System.EventHandler(this.AddRelationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationtypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.definitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox descriptor1Box;
        private System.Windows.Forms.ComboBox relationBox;
        private System.Windows.Forms.ComboBox descriptor2Box;
        private System.Windows.Forms.Label label3;
        private DEDatabaseDataSet dEDatabaseDataSet;
        private System.Windows.Forms.BindingSource definitionsBindingSource;
        private DEDatabaseDataSetTableAdapters.DefinitionsTableAdapter definitionsTableAdapter;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        private DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.BindingSource relationtypesBindingSource;
        private DEDatabaseDataSetTableAdapters.Relation_typesTableAdapter relation_typesTableAdapter;
        private System.Windows.Forms.BindingSource descriptorsBindingSource1;
        private System.Windows.Forms.Button addButton;
    }
}