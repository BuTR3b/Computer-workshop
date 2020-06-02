namespace Books
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxFindGenre = new System.Windows.Forms.TextBox();
            this.buttonFindGenre = new System.Windows.Forms.Button();
            this.buttonFIndAuthor = new System.Windows.Forms.Button();
            this.textBoxFindAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Жанр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(96, 22);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(96, 49);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(96, 80);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 6;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(96, 112);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(22, 178);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(121, 149);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Вывести";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBoxFindGenre
            // 
            this.textBoxFindGenre.Location = new System.Drawing.Point(110, 217);
            this.textBoxFindGenre.Name = "textBoxFindGenre";
            this.textBoxFindGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindGenre.TabIndex = 10;
            // 
            // buttonFindGenre
            // 
            this.buttonFindGenre.Location = new System.Drawing.Point(230, 217);
            this.buttonFindGenre.Name = "buttonFindGenre";
            this.buttonFindGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonFindGenre.TabIndex = 11;
            this.buttonFindGenre.Text = "Найти";
            this.buttonFindGenre.UseVisualStyleBackColor = true;
            this.buttonFindGenre.Click += new System.EventHandler(this.buttonFindGenre_Click);
            // 
            // buttonFIndAuthor
            // 
            this.buttonFIndAuthor.Location = new System.Drawing.Point(230, 254);
            this.buttonFIndAuthor.Name = "buttonFIndAuthor";
            this.buttonFIndAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonFIndAuthor.TabIndex = 13;
            this.buttonFIndAuthor.Text = "Найти";
            this.buttonFIndAuthor.UseVisualStyleBackColor = true;
            this.buttonFIndAuthor.Click += new System.EventHandler(this.buttonFIndAuthor_Click);
            // 
            // textBoxFindAuthor
            // 
            this.textBoxFindAuthor.Location = new System.Drawing.Point(110, 257);
            this.textBoxFindAuthor.Name = "textBoxFindAuthor";
            this.textBoxFindAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindAuthor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Поиск по жанру";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Поиск по автору";
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(353, 21);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(294, 256);
            this.textBoxShow.TabIndex = 16;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(121, 178);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Книги до 2000 года";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(22, 149);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Гистограмма";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFIndAuthor);
            this.Controls.Add(this.textBoxFindAuthor);
            this.Controls.Add(this.buttonFindGenre);
            this.Controls.Add(this.textBoxFindGenre);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxFindGenre;
        private System.Windows.Forms.Button buttonFindGenre;
        private System.Windows.Forms.Button buttonFIndAuthor;
        private System.Windows.Forms.TextBox textBoxFindAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
    }
}

