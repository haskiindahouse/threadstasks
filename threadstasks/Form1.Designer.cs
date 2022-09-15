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
            this.bubbleSort = new System.Windows.Forms.ListBox();
            this.quickSort = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.compareCountTxtBox = new System.Windows.Forms.TextBox();
            this.timeElapsedTxtBox = new System.Windows.Forms.TextBox();
            this.swapCountTxtBox = new System.Windows.Forms.TextBox();
            this.minValue = new System.Windows.Forms.NumericUpDown();
            this.maxValue = new System.Windows.Forms.NumericUpDown();
            this.successivelyRdnBtn = new System.Windows.Forms.RadioButton();
            this.parallelyRdnBtn = new System.Windows.Forms.RadioButton();
            this.shellSort = new System.Windows.Forms.ListBox();
            this.bubbleGroupBox = new System.Windows.Forms.GroupBox();
            this.shellGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.quickSortGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.quickGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValue)).BeginInit();
            this.bubbleGroupBox.SuspendLayout();
            this.shellGroupBox.SuspendLayout();
            this.quickSortGroupBox.SuspendLayout();
            this.quickGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(12, 398);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(165, 23);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // arraySizeTextBox
            // 
            this.arraySizeTextBox.Location = new System.Drawing.Point(77, 50);
            this.arraySizeTextBox.Name = "arraySizeTextBox";
            this.arraySizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.arraySizeTextBox.TabIndex = 1;
            this.arraySizeTextBox.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "array size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "max";
            // 
            // bubbleSort
            // 
            this.bubbleSort.FormattingEnabled = true;
            this.bubbleSort.ItemHeight = 15;
            this.bubbleSort.Location = new System.Drawing.Point(189, 12);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(120, 289);
            this.bubbleSort.TabIndex = 7;
            // 
            // quickSort
            // 
            this.quickSort.FormattingEnabled = true;
            this.quickSort.ItemHeight = 15;
            this.quickSort.Location = new System.Drawing.Point(567, 12);
            this.quickSort.Name = "quickSort";
            this.quickSort.Size = new System.Drawing.Size(120, 289);
            this.quickSort.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "compare count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "swap count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "time elapsed";
            // 
            // compareCountTxtBox
            // 
            this.compareCountTxtBox.Location = new System.Drawing.Point(100, 22);
            this.compareCountTxtBox.Name = "compareCountTxtBox";
            this.compareCountTxtBox.Size = new System.Drawing.Size(76, 23);
            this.compareCountTxtBox.TabIndex = 12;
            // 
            // timeElapsedTxtBox
            // 
            this.timeElapsedTxtBox.Location = new System.Drawing.Point(100, 80);
            this.timeElapsedTxtBox.Name = "timeElapsedTxtBox";
            this.timeElapsedTxtBox.Size = new System.Drawing.Size(76, 23);
            this.timeElapsedTxtBox.TabIndex = 13;
            // 
            // swapCountTxtBox
            // 
            this.swapCountTxtBox.Location = new System.Drawing.Point(100, 51);
            this.swapCountTxtBox.Name = "swapCountTxtBox";
            this.swapCountTxtBox.Size = new System.Drawing.Size(76, 23);
            this.swapCountTxtBox.TabIndex = 14;
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(47, 17);
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
            this.maxValue.Location = new System.Drawing.Point(133, 17);
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
            // successivelyRdnBtn
            // 
            this.successivelyRdnBtn.AutoSize = true;
            this.successivelyRdnBtn.Location = new System.Drawing.Point(13, 113);
            this.successivelyRdnBtn.Name = "successivelyRdnBtn";
            this.successivelyRdnBtn.Size = new System.Drawing.Size(89, 19);
            this.successivelyRdnBtn.TabIndex = 17;
            this.successivelyRdnBtn.TabStop = true;
            this.successivelyRdnBtn.Text = "successively";
            this.successivelyRdnBtn.UseVisualStyleBackColor = true;
            // 
            // parallelyRdnBtn
            // 
            this.parallelyRdnBtn.AutoSize = true;
            this.parallelyRdnBtn.Location = new System.Drawing.Point(13, 148);
            this.parallelyRdnBtn.Name = "parallelyRdnBtn";
            this.parallelyRdnBtn.Size = new System.Drawing.Size(69, 19);
            this.parallelyRdnBtn.TabIndex = 18;
            this.parallelyRdnBtn.TabStop = true;
            this.parallelyRdnBtn.Text = "parallely";
            this.parallelyRdnBtn.UseVisualStyleBackColor = true;
            // 
            // shellSort
            // 
            this.shellSort.FormattingEnabled = true;
            this.shellSort.ItemHeight = 15;
            this.shellSort.Location = new System.Drawing.Point(378, 12);
            this.shellSort.Name = "shellSort";
            this.shellSort.Size = new System.Drawing.Size(120, 289);
            this.shellSort.TabIndex = 19;
            // 
            // bubbleGroupBox
            // 
            this.bubbleGroupBox.Controls.Add(this.compareCountTxtBox);
            this.bubbleGroupBox.Controls.Add(this.label4);
            this.bubbleGroupBox.Controls.Add(this.label5);
            this.bubbleGroupBox.Controls.Add(this.label6);
            this.bubbleGroupBox.Controls.Add(this.timeElapsedTxtBox);
            this.bubbleGroupBox.Controls.Add(this.swapCountTxtBox);
            this.bubbleGroupBox.Location = new System.Drawing.Point(183, 318);
            this.bubbleGroupBox.Name = "bubbleGroupBox";
            this.bubbleGroupBox.Size = new System.Drawing.Size(183, 111);
            this.bubbleGroupBox.TabIndex = 20;
            this.bubbleGroupBox.TabStop = false;
            this.bubbleGroupBox.Text = "bubble sort";
            // 
            // shellGroupBox
            // 
            this.shellGroupBox.Controls.Add(this.textBox1);
            this.shellGroupBox.Controls.Add(this.quickSortGroupBox);
            this.shellGroupBox.Controls.Add(this.label7);
            this.shellGroupBox.Controls.Add(this.label8);
            this.shellGroupBox.Controls.Add(this.label9);
            this.shellGroupBox.Controls.Add(this.textBox2);
            this.shellGroupBox.Controls.Add(this.textBox3);
            this.shellGroupBox.Location = new System.Drawing.Point(372, 318);
            this.shellGroupBox.Name = "shellGroupBox";
            this.shellGroupBox.Size = new System.Drawing.Size(183, 111);
            this.shellGroupBox.TabIndex = 21;
            this.shellGroupBox.TabStop = false;
            this.shellGroupBox.Text = "shell sort";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 23);
            this.textBox1.TabIndex = 12;
            // 
            // quickSortGroupBox
            // 
            this.quickSortGroupBox.Controls.Add(this.textBox4);
            this.quickSortGroupBox.Controls.Add(this.label10);
            this.quickSortGroupBox.Controls.Add(this.label11);
            this.quickSortGroupBox.Controls.Add(this.label12);
            this.quickSortGroupBox.Controls.Add(this.textBox5);
            this.quickSortGroupBox.Controls.Add(this.textBox6);
            this.quickSortGroupBox.Location = new System.Drawing.Point(182, 13);
            this.quickSortGroupBox.Name = "quickSortGroupBox";
            this.quickSortGroupBox.Size = new System.Drawing.Size(183, 111);
            this.quickSortGroupBox.TabIndex = 22;
            this.quickSortGroupBox.TabStop = false;
            this.quickSortGroupBox.Text = "quick sort";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(100, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 23);
            this.textBox4.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "compare count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "swap count";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "time elapsed";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(100, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 23);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(100, 51);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 23);
            this.textBox6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "compare count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "swap count";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "time elapsed";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 23);
            this.textBox3.TabIndex = 14;
            // 
            // quickGroupBox
            // 
            this.quickGroupBox.Controls.Add(this.textBox7);
            this.quickGroupBox.Controls.Add(this.groupBox2);
            this.quickGroupBox.Controls.Add(this.label16);
            this.quickGroupBox.Controls.Add(this.label17);
            this.quickGroupBox.Controls.Add(this.label18);
            this.quickGroupBox.Controls.Add(this.textBox11);
            this.quickGroupBox.Controls.Add(this.textBox12);
            this.quickGroupBox.Location = new System.Drawing.Point(561, 318);
            this.quickGroupBox.Name = "quickGroupBox";
            this.quickGroupBox.Size = new System.Drawing.Size(183, 111);
            this.quickGroupBox.TabIndex = 22;
            this.quickGroupBox.TabStop = false;
            this.quickGroupBox.Text = "quick sort";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(100, 22);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 23);
            this.textBox7.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Location = new System.Drawing.Point(182, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 111);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "quick sort";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(100, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 23);
            this.textBox8.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "compare count";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "swap count";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "time elapsed";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(100, 80);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 23);
            this.textBox9.TabIndex = 13;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(100, 51);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 23);
            this.textBox10.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "compare count";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "swap count";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "time elapsed";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(100, 80);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 23);
            this.textBox11.TabIndex = 13;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(100, 51);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(76, 23);
            this.textBox12.TabIndex = 14;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 361);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(165, 23);
            this.generate.TabIndex = 23;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 444);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.quickGroupBox);
            this.Controls.Add(this.shellGroupBox);
            this.Controls.Add(this.bubbleGroupBox);
            this.Controls.Add(this.shellSort);
            this.Controls.Add(this.parallelyRdnBtn);
            this.Controls.Add(this.successivelyRdnBtn);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.quickSort);
            this.Controls.Add(this.bubbleSort);
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
            this.bubbleGroupBox.ResumeLayout(false);
            this.bubbleGroupBox.PerformLayout();
            this.shellGroupBox.ResumeLayout(false);
            this.shellGroupBox.PerformLayout();
            this.quickSortGroupBox.ResumeLayout(false);
            this.quickSortGroupBox.PerformLayout();
            this.quickGroupBox.ResumeLayout(false);
            this.quickGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sortBtn;
        private TextBox arraySizeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox bubbleSort;
        private ListBox quickSort;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox compareCountTxtBox;
        private TextBox timeElapsedTxtBox;
        private TextBox swapCountTxtBox;
        private NumericUpDown minValue;
        private NumericUpDown maxValue;
        private RadioButton successivelyRdnBtn;
        private RadioButton parallelyRdnBtn;
        private ListBox shellSort;
        private GroupBox bubbleGroupBox;
        private GroupBox shellGroupBox;
        private TextBox textBox1;
        private GroupBox quickSortGroupBox;
        private TextBox textBox4;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox quickGroupBox;
        private TextBox textBox7;
        private GroupBox groupBox2;
        private TextBox textBox8;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button generate;
    }
}