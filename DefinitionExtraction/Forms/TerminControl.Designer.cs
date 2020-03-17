namespace DefinitionExtraction
{
    partial class TerminControl
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
            this.descriptorBox = new System.Windows.Forms.Label();
            this.relatorBox = new System.Windows.Forms.Label();
            this.ascriptorsBox = new System.Windows.Forms.Label();
            this.definitionBox = new System.Windows.Forms.Label();
            this.definitionLocationBox = new System.Windows.Forms.Label();
            this.descriptorLocationBox = new System.Windows.Forms.Label();
            this.relationsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // descriptorBox
            // 
            this.descriptorBox.AutoSize = true;
            this.descriptorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptorBox.Location = new System.Drawing.Point(11, 10);
            this.descriptorBox.Name = "descriptorBox";
            this.descriptorBox.Size = new System.Drawing.Size(92, 20);
            this.descriptorBox.TabIndex = 0;
            this.descriptorBox.Text = "Descriptor";
            // 
            // relatorBox
            // 
            this.relatorBox.AutoSize = true;
            this.relatorBox.Location = new System.Drawing.Point(12, 47);
            this.relatorBox.Name = "relatorBox";
            this.relatorBox.Size = new System.Drawing.Size(59, 17);
            this.relatorBox.TabIndex = 1;
            this.relatorBox.Text = "(relator)";
            // 
            // ascriptorsBox
            // 
            this.ascriptorsBox.AutoSize = true;
            this.ascriptorsBox.Location = new System.Drawing.Point(12, 67);
            this.ascriptorsBox.Name = "ascriptorsBox";
            this.ascriptorsBox.Size = new System.Drawing.Size(71, 17);
            this.ascriptorsBox.TabIndex = 2;
            this.ascriptorsBox.Text = "Ascriptors";
            // 
            // definitionBox
            // 
            this.definitionBox.AutoSize = true;
            this.definitionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.definitionBox.Location = new System.Drawing.Point(12, 88);
            this.definitionBox.Name = "definitionBox";
            this.definitionBox.Size = new System.Drawing.Size(69, 18);
            this.definitionBox.TabIndex = 3;
            this.definitionBox.Text = "Definition";
            // 
            // definitionLocationBox
            // 
            this.definitionLocationBox.AutoSize = true;
            this.definitionLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.definitionLocationBox.Location = new System.Drawing.Point(12, 133);
            this.definitionLocationBox.Name = "definitionLocationBox";
            this.definitionLocationBox.Size = new System.Drawing.Size(44, 15);
            this.definitionLocationBox.TabIndex = 4;
            this.definitionLocationBox.Text = "0 0 0 0";
            // 
            // descriptorLocationBox
            // 
            this.descriptorLocationBox.AutoSize = true;
            this.descriptorLocationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptorLocationBox.Location = new System.Drawing.Point(12, 30);
            this.descriptorLocationBox.Name = "descriptorLocationBox";
            this.descriptorLocationBox.Size = new System.Drawing.Size(44, 15);
            this.descriptorLocationBox.TabIndex = 5;
            this.descriptorLocationBox.Text = "0 0 0 0";
            // 
            // relationsBox
            // 
            this.relationsBox.Location = new System.Drawing.Point(15, 152);
            this.relationsBox.Name = "relationsBox";
            this.relationsBox.Size = new System.Drawing.Size(671, 96);
            this.relationsBox.TabIndex = 6;
            this.relationsBox.Text = "";
            // 
            // TerminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.relationsBox);
            this.Controls.Add(this.descriptorLocationBox);
            this.Controls.Add(this.definitionLocationBox);
            this.Controls.Add(this.definitionBox);
            this.Controls.Add(this.ascriptorsBox);
            this.Controls.Add(this.relatorBox);
            this.Controls.Add(this.descriptorBox);
            this.Name = "TerminControl";
            this.Size = new System.Drawing.Size(719, 272);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptorBox;
        private System.Windows.Forms.Label relatorBox;
        private System.Windows.Forms.Label ascriptorsBox;
        private System.Windows.Forms.Label definitionBox;
        private System.Windows.Forms.Label definitionLocationBox;
        private System.Windows.Forms.Label descriptorLocationBox;
        private System.Windows.Forms.RichTextBox relationsBox;
    }
}
