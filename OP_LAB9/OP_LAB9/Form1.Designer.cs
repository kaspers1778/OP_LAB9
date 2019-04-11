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
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_words = new System.Windows.Forms.DataGridView();
            this.OutputWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_words)).BeginInit();
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
            this.dgv_Output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Amount});
            this.dgv_Output.Location = new System.Drawing.Point(12, 43);
            this.dgv_Output.Name = "dgv_Output";
            this.dgv_Output.RowTemplate.Height = 24;
            this.dgv_Output.Size = new System.Drawing.Size(325, 426);
            this.dgv_Output.TabIndex = 1;
            this.dgv_Output.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Output_CellContentClick);
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Letter";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // dgv_words
            // 
            this.dgv_words.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_words.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutputWords,
            this.amountOfWords});
            this.dgv_words.Location = new System.Drawing.Point(365, 43);
            this.dgv_words.Name = "dgv_words";
            this.dgv_words.RowTemplate.Height = 24;
            this.dgv_words.Size = new System.Drawing.Size(321, 426);
            this.dgv_words.TabIndex = 2;
            this.dgv_words.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_words_CellContentClick);
            // 
            // OutputWords
            // 
            this.OutputWords.HeaderText = "Word";
            this.OutputWords.Name = "OutputWords";
            // 
            // amountOfWords
            // 
            this.amountOfWords.HeaderText = "Amount";
            this.amountOfWords.Name = "amountOfWords";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.dgv_words);
            this.Controls.Add(this.dgv_Output);
            this.Controls.Add(this.btn_OpenFile);
            this.Name = "Form1";
            this.Text = "OP_LAB9";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_words)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.DataGridView dgv_Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridView dgv_words;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfWords;
    }
}

