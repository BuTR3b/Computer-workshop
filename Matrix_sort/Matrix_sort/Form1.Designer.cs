namespace CP_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ShowArray = new System.Windows.Forms.Button();
            this.BubbleSortRows = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BubbleSortColums = new System.Windows.Forms.Button();
            this.BubbleSortRowsMax = new System.Windows.Forms.Button();
            this.BubbleSortColumsMax = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InsertColumnsSort = new System.Windows.Forms.Button();
            this.InsertRowsSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "столбцы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 142);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 150);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(198, 142);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 150);
            this.textBox4.TabIndex = 5;
            // 
            // ShowArray
            // 
            this.ShowArray.Location = new System.Drawing.Point(13, 64);
            this.ShowArray.Name = "ShowArray";
            this.ShowArray.Size = new System.Drawing.Size(105, 25);
            this.ShowArray.TabIndex = 6;
            this.ShowArray.Text = "Вывести";
            this.ShowArray.UseVisualStyleBackColor = true;
            this.ShowArray.Click += new System.EventHandler(this.ShowArray_Click);
            // 
            // BubbleSortRows
            // 
            this.BubbleSortRows.Location = new System.Drawing.Point(400, 39);
            this.BubbleSortRows.Name = "BubbleSortRows";
            this.BubbleSortRows.Size = new System.Drawing.Size(105, 25);
            this.BubbleSortRows.TabIndex = 7;
            this.BubbleSortRows.Text = "Строке";
            this.BubbleSortRows.UseVisualStyleBackColor = true;
            this.BubbleSortRows.Click += new System.EventHandler(this.BubbleSortRows_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Несортированный";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сортированный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сортировать по";
            // 
            // BubbleSortColums
            // 
            this.BubbleSortColums.Location = new System.Drawing.Point(400, 70);
            this.BubbleSortColums.Name = "BubbleSortColums";
            this.BubbleSortColums.Size = new System.Drawing.Size(105, 25);
            this.BubbleSortColums.TabIndex = 11;
            this.BubbleSortColums.Text = "Столбцу";
            this.BubbleSortColums.UseVisualStyleBackColor = true;
            this.BubbleSortColums.Click += new System.EventHandler(this.BubbleSortColums_Click);
            // 
            // BubbleSortRowsMax
            // 
            this.BubbleSortRowsMax.Location = new System.Drawing.Point(400, 101);
            this.BubbleSortRowsMax.Name = "BubbleSortRowsMax";
            this.BubbleSortRowsMax.Size = new System.Drawing.Size(105, 25);
            this.BubbleSortRowsMax.TabIndex = 12;
            this.BubbleSortRowsMax.Text = "Строке (max)";
            this.BubbleSortRowsMax.UseVisualStyleBackColor = true;
            this.BubbleSortRowsMax.Click += new System.EventHandler(this.BubbleSortRowsMax_Click);
            // 
            // BubbleSortColumsMax
            // 
            this.BubbleSortColumsMax.Location = new System.Drawing.Point(396, 132);
            this.BubbleSortColumsMax.Name = "BubbleSortColumsMax";
            this.BubbleSortColumsMax.Size = new System.Drawing.Size(113, 25);
            this.BubbleSortColumsMax.TabIndex = 13;
            this.BubbleSortColumsMax.Text = "Столбцу (max)";
            this.BubbleSortColumsMax.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Пузырьком";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Вставкой";
            // 
            // InsertColumnsSort
            // 
            this.InsertColumnsSort.Location = new System.Drawing.Point(533, 70);
            this.InsertColumnsSort.Name = "InsertColumnsSort";
            this.InsertColumnsSort.Size = new System.Drawing.Size(105, 25);
            this.InsertColumnsSort.TabIndex = 16;
            this.InsertColumnsSort.Text = "Столбцу";
            this.InsertColumnsSort.UseVisualStyleBackColor = true;
            this.InsertColumnsSort.Click += new System.EventHandler(this.InsertColumnsSort_Click);
            // 
            // InsertRowsSort
            // 
            this.InsertRowsSort.Location = new System.Drawing.Point(533, 39);
            this.InsertRowsSort.Name = "InsertRowsSort";
            this.InsertRowsSort.Size = new System.Drawing.Size(105, 25);
            this.InsertRowsSort.TabIndex = 15;
            this.InsertRowsSort.Text = "Строке";
            this.InsertRowsSort.UseVisualStyleBackColor = true;
            this.InsertRowsSort.Click += new System.EventHandler(this.InsertRowsSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InsertColumnsSort);
            this.Controls.Add(this.InsertRowsSort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BubbleSortColumsMax);
            this.Controls.Add(this.BubbleSortRowsMax);
            this.Controls.Add(this.BubbleSortColums);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BubbleSortRows);
            this.Controls.Add(this.ShowArray);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ShowArray;
        private System.Windows.Forms.Button BubbleSortRows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BubbleSortColums;
        private System.Windows.Forms.Button BubbleSortRowsMax;
        private System.Windows.Forms.Button BubbleSortColumsMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button InsertColumnsSort;
        private System.Windows.Forms.Button InsertRowsSort;
    }
}

