namespace LR_CPO8
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoffeeCheckBox = new System.Windows.Forms.CheckBox();
            this.CocoaCheckBox = new System.Windows.Forms.CheckBox();
            this.ChocolateCheckBox = new System.Windows.Forms.CheckBox();
            this.SugarCheckBox = new System.Windows.Forms.CheckBox();
            this.MilkCheckBox = new System.Windows.Forms.CheckBox();
            this.CreamCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.DrinkGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DrinkGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoffeeCheckBox
            // 
            this.CoffeeCheckBox.AutoSize = true;
            this.CoffeeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.CoffeeCheckBox.Name = "CoffeeCheckBox";
            this.CoffeeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CoffeeCheckBox.Size = new System.Drawing.Size(109, 19);
            this.CoffeeCheckBox.TabIndex = 0;
            this.CoffeeCheckBox.Text = "Кофе (50 руб.)";
            this.CoffeeCheckBox.UseVisualStyleBackColor = true;
            // 
            // CocoaCheckBox
            // 
            this.CocoaCheckBox.AutoSize = true;
            this.CocoaCheckBox.Location = new System.Drawing.Point(6, 41);
            this.CocoaCheckBox.Name = "CocoaCheckBox";
            this.CocoaCheckBox.Size = new System.Drawing.Size(111, 19);
            this.CocoaCheckBox.TabIndex = 1;
            this.CocoaCheckBox.Text = "Какао (35 руб.)";
            this.CocoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChocolateCheckBox
            // 
            this.ChocolateCheckBox.AutoSize = true;
            this.ChocolateCheckBox.Location = new System.Drawing.Point(6, 66);
            this.ChocolateCheckBox.Name = "ChocolateCheckBox";
            this.ChocolateCheckBox.Size = new System.Drawing.Size(128, 19);
            this.ChocolateCheckBox.TabIndex = 2;
            this.ChocolateCheckBox.Text = "Шоколад (20 руб.)";
            this.ChocolateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SugarCheckBox
            // 
            this.SugarCheckBox.AutoSize = true;
            this.SugarCheckBox.Location = new System.Drawing.Point(6, 19);
            this.SugarCheckBox.Name = "SugarCheckBox";
            this.SugarCheckBox.Size = new System.Drawing.Size(104, 19);
            this.SugarCheckBox.TabIndex = 3;
            this.SugarCheckBox.Text = "Сахар (2 руб.)";
            this.SugarCheckBox.UseVisualStyleBackColor = true;
            // 
            // MilkCheckBox
            // 
            this.MilkCheckBox.AutoSize = true;
            this.MilkCheckBox.Location = new System.Drawing.Point(6, 44);
            this.MilkCheckBox.Name = "MilkCheckBox";
            this.MilkCheckBox.Size = new System.Drawing.Size(114, 19);
            this.MilkCheckBox.TabIndex = 4;
            this.MilkCheckBox.Text = "Молоко (5 руб.)";
            this.MilkCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreamCheckBox
            // 
            this.CreamCheckBox.AutoSize = true;
            this.CreamCheckBox.Location = new System.Drawing.Point(6, 69);
            this.CreamCheckBox.Name = "CreamCheckBox";
            this.CreamCheckBox.Size = new System.Drawing.Size(111, 19);
            this.CreamCheckBox.TabIndex = 5;
            this.CreamCheckBox.Text = "Сливки (7 руб.)";
            this.CreamCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(10, 205);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(151, 23);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(168, 12);
            this.TotalTextBox.Multiline = true;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(227, 216);
            this.TotalTextBox.TabIndex = 8;
            // 
            // DrinkGroupBox
            // 
            this.DrinkGroupBox.Controls.Add(this.CoffeeCheckBox);
            this.DrinkGroupBox.Controls.Add(this.CocoaCheckBox);
            this.DrinkGroupBox.Controls.Add(this.ChocolateCheckBox);
            this.DrinkGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DrinkGroupBox.Name = "DrinkGroupBox";
            this.DrinkGroupBox.Size = new System.Drawing.Size(149, 91);
            this.DrinkGroupBox.TabIndex = 9;
            this.DrinkGroupBox.TabStop = false;
            this.DrinkGroupBox.Text = "Выберете напиток";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SugarCheckBox);
            this.groupBox1.Controls.Add(this.MilkCheckBox);
            this.groupBox1.Controls.Add(this.CreamCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберете добавки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DrinkGroupBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.OrderButton);
            this.Name = "Form1";
            this.Text = "Кофемашина";
            this.DrinkGroupBox.ResumeLayout(false);
            this.DrinkGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CoffeeCheckBox;
        private System.Windows.Forms.CheckBox CocoaCheckBox;
        private System.Windows.Forms.CheckBox ChocolateCheckBox;
        private System.Windows.Forms.CheckBox SugarCheckBox;
        private System.Windows.Forms.CheckBox MilkCheckBox;
        private System.Windows.Forms.CheckBox CreamCheckBox;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.GroupBox DrinkGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

