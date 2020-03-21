namespace DefinitionExtraction
{
    partial class AscriptorForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.ascriptorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEDatabaseDataSet = new DefinitionExtraction.DEDatabaseDataSet();
            this.descriptorsTableAdapter = new DefinitionExtraction.DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter();
            this.descriptorBox = new System.Windows.Forms.ComboBox();
            this.descriptorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Связанный дескриптор";
            // 
            // ascriptorBox
            // 
            this.ascriptorBox.Location = new System.Drawing.Point(196, 78);
            this.ascriptorBox.Name = "ascriptorBox";
            this.ascriptorBox.Size = new System.Drawing.Size(168, 22);
            this.ascriptorBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Аскриптор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(67, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Добавление аскриптора";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(136, 163);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(111, 23);
            this.signInButton.TabIndex = 27;
            this.signInButton.Text = "Добавить ";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
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
            // descriptorsTableAdapter
            // 
            this.descriptorsTableAdapter.ClearBeforeFill = true;
            // 
            // descriptorBox
            // 
            this.descriptorBox.DataSource = this.descriptorsBindingSource1;
            this.descriptorBox.DisplayMember = "Descriptor_content";
            this.descriptorBox.FormattingEnabled = true;
            this.descriptorBox.Location = new System.Drawing.Point(197, 119);
            this.descriptorBox.Name = "descriptorBox";
            this.descriptorBox.Size = new System.Drawing.Size(167, 24);
            this.descriptorBox.TabIndex = 32;
            this.descriptorBox.ValueMember = "ID";
            // 
            // descriptorsBindingSource1
            // 
            this.descriptorsBindingSource1.DataMember = "Descriptors";
            this.descriptorsBindingSource1.DataSource = this.dEDatabaseDataSet;
            // 
            // AscriptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 206);
            this.Controls.Add(this.descriptorBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ascriptorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signInButton);
            this.Name = "AscriptorForm";
            this.Text = "AscriptorForm";
            this.Load += new System.EventHandler(this.AscriptorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ascriptorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signInButton;
        private DEDatabaseDataSet dEDatabaseDataSet;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        private DEDatabaseDataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.ComboBox descriptorBox;
        private System.Windows.Forms.BindingSource descriptorsBindingSource1;
    }
}