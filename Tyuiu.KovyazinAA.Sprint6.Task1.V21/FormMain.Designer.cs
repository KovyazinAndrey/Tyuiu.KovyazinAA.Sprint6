namespace Tyuiu.KovyazinAA.Sprint6.Task1.V21
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
            textBoxStartNum = new TextBox();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxInputData = new GroupBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            textBoxEndNum = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonResult = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxInputData.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStartNum
            // 
            textBoxStartNum.Location = new Point(6, 57);
            textBoxStartNum.Name = "textBoxStartNum";
            textBoxStartNum.ReadOnly = true;
            textBoxStartNum.Size = new Size(125, 27);
            textBoxStartNum.TabIndex = 1;
            textBoxStartNum.Text = "-5";
            textBoxStartNum.TextChanged += textBox2_TextChanged;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(526, 330);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(514, 298);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции F(x) на заданном диапазоне [-5; 5] с шагом 1.\r\nПроизвести проверку деления на ноль. Значения округлить до двух знаков после запятой.";
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(textBoxEnd);
            groupBoxInputData.Controls.Add(textBoxStart);
            groupBoxInputData.Controls.Add(textBoxEndNum);
            groupBoxInputData.Controls.Add(textBoxStartNum);
            groupBoxInputData.Location = new Point(12, 348);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(339, 90);
            groupBoxInputData.TabIndex = 3;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(167, 24);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.ReadOnly = true;
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 6;
            textBoxEnd.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 5;
            textBoxStart.Text = "Старт шага:";
            // 
            // textBoxEndNum
            // 
            textBoxEndNum.Location = new Point(167, 57);
            textBoxEndNum.Name = "textBoxEndNum";
            textBoxEndNum.ReadOnly = true;
            textBoxEndNum.Size = new Size(125, 27);
            textBoxEndNum.TabIndex = 4;
            textBoxEndNum.Text = "5";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(544, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(286, 426);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10F);
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(274, 394);
            textBoxResult.TabIndex = 0;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(357, 348);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(175, 90);
            buttonResult.TabIndex = 5;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += textBox2_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 450);
            Controls.Add(buttonResult);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxInputData);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 21 | Ковязин А.А.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxStartNum;
        private GroupBox groupBoxTask;
        private GroupBox groupBox1;
        private GroupBox groupBoxInputData;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private TextBox textBoxEndNum;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button button1;
        private Button button2;
        private Button buttonResult;
    }
}
