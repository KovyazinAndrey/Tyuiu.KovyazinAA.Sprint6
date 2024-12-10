namespace Tyuiu.KovyazinAA.Sprint6.Task5.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonDone = new Button();
            buttonOpenInputFile = new Button();
            groupBoxOutputData = new GroupBox();
            dataGridViewOutputData = new DataGridView();
            chartNums = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartNums).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(631, 108);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(619, 76);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Прочитать данные из файла InPutFileTask5V1.txt. Вывести в dataGridView все положительные числа. Постоить диаграмму по этим значениям.\r\n";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(649, 27);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(134, 87);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenInputFile
            // 
            buttonOpenInputFile.Location = new Point(789, 27);
            buttonOpenInputFile.Name = "buttonOpenInputFile";
            buttonOpenInputFile.Size = new Size(114, 87);
            buttonOpenInputFile.TabIndex = 2;
            buttonOpenInputFile.Text = "Открыть файл";
            buttonOpenInputFile.UseVisualStyleBackColor = true;
            buttonOpenInputFile.Click += buttonOpenInputFile_Click;
            // 
            // groupBoxOutputData
            // 
            groupBoxOutputData.Controls.Add(dataGridViewOutputData);
            groupBoxOutputData.Location = new Point(12, 126);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(171, 312);
            groupBoxOutputData.TabIndex = 3;
            groupBoxOutputData.TabStop = false;
            groupBoxOutputData.Text = "Вывод данных";
            // 
            // dataGridViewOutputData
            // 
            dataGridViewOutputData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutputData.Location = new Point(6, 26);
            dataGridViewOutputData.Name = "dataGridViewOutputData";
            dataGridViewOutputData.RowHeadersWidth = 51;
            dataGridViewOutputData.Size = new Size(159, 280);
            dataGridViewOutputData.TabIndex = 0;
            // 
            // chartNums
            // 
            chartArea1.Name = "ChartArea1";
            chartNums.ChartAreas.Add(chartArea1);
            chartNums.Location = new Point(189, 126);
            chartNums.Name = "chartNums";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartNums.Series.Add(series1);
            chartNums.Size = new Size(714, 322);
            chartNums.TabIndex = 4;
            chartNums.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 450);
            Controls.Add(chartNums);
            Controls.Add(groupBoxOutputData);
            Controls.Add(buttonOpenInputFile);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 1 | Ковязин А.А.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartNums).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Button buttonDone;
        private Button buttonOpenInputFile;
        private GroupBox groupBoxOutputData;
        private DataGridView dataGridViewOutputData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNums;
    }
}
