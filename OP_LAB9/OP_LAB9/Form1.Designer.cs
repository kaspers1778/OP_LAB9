namespace OP_LAB9
{
    partial class Form1
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
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.dgv_Output = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(12, 12);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(99, 25);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open file";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // dgv_Output
            // 
            this.dgv_Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Output.Location = new System.Drawing.Point(293, 12);
            this.dgv_Output.Name = "dgv_Output";
            this.dgv_Output.RowTemplate.Height = 24;
            this.dgv_Output.Size = new System.Drawing.Size(479, 426);
            this.dgv_Output.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 319);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgv_Output);
            this.Controls.Add(this.btn_OpenFile);
            this.Name = "Form1";
            this.Text = "OP_LAB9";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.DataGridView dgv_Output;
        private System.Windows.Forms.TextBox textBox1;
    }
}

