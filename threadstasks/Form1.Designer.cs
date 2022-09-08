namespace threadstasks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sortBtn = new System.Windows.Forms.Button();
            this.arraySizeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unsortedListBox = new System.Windows.Forms.ListBox();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compareCountTxtBox = new System.Windows.Forms.TextBox();
            this.timeElapsedTxtBox = new System.Windows.Forms.TextBox();
            this.swapCountTxtBox = new System.Windows.Forms.TextBox();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(12, 278);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(165, 23);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // arraySizeTextBox
            // 
            this.arraySizeTextBox.Location = new System.Drawing.Point(77, 243);
            this.arraySizeTextBox.Name = "arraySizeTextBox";
            this.arraySizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.arraySizeTextBox.TabIndex = 1;
            this.arraySizeTextBox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "array size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "max";
            // 
            // unsortedListBox
            // 
            this.unsortedListBox.FormattingEnabled = true;
            this.unsortedListBox.ItemHeight = 15;
            this.unsortedListBox.Location = new System.Drawing.Point(183, 12);
            this.unsortedListBox.Name = "unsortedListBox";
            this.unsortedListBox.Size = new System.Drawing.Size(120, 289);
            this.unsortedListBox.TabIndex = 7;
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.ItemHeight = 15;
            this.sortedListBox.Location = new System.Drawing.Point(309, 12);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(120, 289);
            this.sortedListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "compare count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "swap count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "time elapsed";
            // 
            // compareCountTxtBox
            // 
            this.compareCountTxtBox.Location = new System.Drawing.Point(101, 12);
            this.compareCountTxtBox.Name = "compareCountTxtBox";
            this.compareCountTxtBox.Size = new System.Drawing.Size(76, 23);
            this.compareCountTxtBox.TabIndex = 12;
            // 
            // timeElapsedTxtBox
            // 
            this.timeElapsedTxtBox.Location = new System.Drawing.Point(101, 70);
            this.timeElapsedTxtBox.Name = "timeElapsedTxtBox";
            this.timeElapsedTxtBox.Size = new System.Drawing.Size(76, 23);
            this.timeElapsedTxtBox.TabIndex = 13;
            // 
            // swapCountTxtBox
            // 
            this.swapCountTxtBox.Location = new System.Drawing.Point(101, 41);
            this.swapCountTxtBox.Name = "swapCountTxtBox";
            this.swapCountTxtBox.Size = new System.Drawing.Size(76, 23);
            this.swapCountTxtBox.TabIndex = 14;
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(47, 210);
            this.minValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(44, 23);
            this.minValue.TabIndex = 15;
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(133, 210);
            this.maxValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(44, 23);
            this.maxValue.TabIndex = 16;
            this.maxValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 310);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.swapCountTxtBox);
            this.Controls.Add(this.timeElapsedTxtBox);
            this.Controls.Add(this.compareCountTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.unsortedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arraySizeTextBox);
            this.Controls.Add(this.sortBtn);
            this.Name = "Form1";
            this.Text = "Sorts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sortBtn;
        private TextBox arraySizeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox unsortedListBox;
        private ListBox sortedListBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox compareCountTxtBox;
        private TextBox timeElapsedTxtBox;
        private TextBox swapCountTxtBox;
        private NumericUpDown minValue;
        private NumericUpDown maxValue;
    }
}