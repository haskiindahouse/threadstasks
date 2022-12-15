namespace matrix
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
            this.matrixBox = new System.Windows.Forms.RichTextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.matrixSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matrix2Box = new System.Windows.Forms.RichTextBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.resBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // matrixBox
            // 
            this.matrixBox.Location = new System.Drawing.Point(1, 2);
            this.matrixBox.Name = "matrixBox";
            this.matrixBox.Size = new System.Drawing.Size(170, 141);
            this.matrixBox.TabIndex = 0;
            this.matrixBox.Text = "";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 156);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(105, 23);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Сгенерировать";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // matrixSize
            // 
            this.matrixSize.Location = new System.Drawing.Point(223, 156);
            this.matrixSize.Name = "matrixSize";
            this.matrixSize.Size = new System.Drawing.Size(52, 20);
            this.matrixSize.TabIndex = 2;
            this.matrixSize.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер матрицы";
            // 
            // matrix2Box
            // 
            this.matrix2Box.Location = new System.Drawing.Point(201, 0);
            this.matrix2Box.Name = "matrix2Box";
            this.matrix2Box.Size = new System.Drawing.Size(165, 143);
            this.matrix2Box.TabIndex = 5;
            this.matrix2Box.Text = "";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(141, 196);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(30, 13);
            this.timeLbl.TabIndex = 6;
            this.timeLbl.Text = "Time";
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(12, 191);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(105, 23);
            this.sortBtn.TabIndex = 7;
            this.sortBtn.Text = "Сортировать";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(372, 0);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(165, 143);
            this.resBox.TabIndex = 8;
            this.resBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 247);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.matrix2Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixSize);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.matrixBox);
            this.Name = "Form1";
            this.Text = "Перемножение матриц";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox matrixBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox matrixSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox matrix2Box;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.RichTextBox resBox;
    }
}

