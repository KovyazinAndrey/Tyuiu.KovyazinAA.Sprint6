namespace Tyuiu.KovyazinAA.Sprint6.Task2.V24
{
    partial class FormMain
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxDataInput = new GroupBox();
            textBox2 = new TextBox();
            textBoxEndNum = new TextBox();
            textBoxStart = new TextBox();
            textBoxStartNum = new TextBox();
            button1 = new Button();
            groupBoxResult = new GroupBox();
            dataGridView1 = new DataGridView();
            ColX = new DataGridViewTextBoxColumn();
            ColFunc = new DataGridViewTextBoxColumn();
            groupBoxTask.SuspendLayout();
            groupBoxDataInput.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(526, 295);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(514, 263);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции F(x) на заданном диапазоне [-5; 5] с шагом 1.\r\nПроизвести проверку деления на ноль. Значения округлить до двух знаков после запятой.\r\n\r\n";
            // 
            // groupBoxDataInput
            // 
            groupBoxDataInput.Controls.Add(textBox2);
            groupBoxDataInput.Controls.Add(textBoxEndNum);
            groupBoxDataInput.Controls.Add(textBoxStart);
            groupBoxDataInput.Controls.Add(textBoxStartNum);
            groupBoxDataInput.Location = new Point(12, 313);
            groupBoxDataInput.Name = "groupBoxDataInput";
            groupBoxDataInput.Size = new Size(326, 125);
            groupBoxDataInput.TabIndex = 1;
            groupBoxDataInput.TabStop = false;
            groupBoxDataInput.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 59);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Конец шага:";
            // 
            // textBoxEndNum
            // 
            textBoxEndNum.Location = new Point(170, 92);
            textBoxEndNum.Name = "textBoxEndNum";
            textBoxEndNum.ReadOnly = true;
            textBoxEndNum.Size = new Size(125, 27);
            textBoxEndNum.TabIndex = 3;
            textBoxEndNum.Text = "5";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 59);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 4;
            textBoxStart.Text = "Старт шага:";
            // 
            // textBoxStartNum
            // 
            textBoxStartNum.Location = new Point(6, 92);
            textBoxStartNum.Name = "textBoxStartNum";
            textBoxStartNum.ReadOnly = true;
            textBoxStartNum.Size = new Size(125, 27);
            textBoxStartNum.TabIndex = 0;
            textBoxStartNum.Text = "-5";
            // 
            // button1
            // 
            button1.Location = new Point(344, 350);
            button1.Name = "button1";
            button1.Size = new Size(194, 71);
            button1.TabIndex = 2;
            button1.Text = "Выполнить\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += FormMain_Load;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridView1);
            groupBoxResult.Location = new Point(544, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(428, 426);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColX, ColFunc });
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(124, 394);
            dataGridView1.TabIndex = 0;
            // 
            // ColX
            // 
            ColX.HeaderText = "X";
            ColX.MinimumWidth = 6;
            ColX.Name = "ColX";
            ColX.Width = 50;
            // 
            // ColFunc
            // 
            ColFunc.HeaderText = "F(x)";
            ColFunc.MinimumWidth = 6;
            ColFunc.Name = "ColFunc";
            ColFunc.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(button1);
            Controls.Add(groupBoxDataInput);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 24 | Ковязин А.А.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxDataInput.ResumeLayout(false);
            groupBoxDataInput.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxDataInput;
        private TextBox textBox2;
        private TextBox textBoxEndNum;
        private TextBox textBoxStart;
        private TextBox textBoxStartNum;
        private Button button1;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColX;
        private DataGridViewTextBoxColumn ColFunc;
    }
}
