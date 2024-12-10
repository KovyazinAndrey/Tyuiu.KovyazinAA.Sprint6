namespace Tyuiu.KovyazinAA.Sprint6.Task4.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxInputData = new GroupBox();
            textBoxEndNum = new TextBox();
            textBoxStartNum = new TextBox();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBoxOutputData = new GroupBox();
            textBoxResult = new TextBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDoMath = new Button();
            buttonSaveInFile = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxInputData.SuspendLayout();
            groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(467, 161);
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
            textBoxTask.Size = new Size(455, 135);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(textBoxEndNum);
            groupBoxInputData.Controls.Add(textBoxStartNum);
            groupBoxInputData.Controls.Add(textBoxEnd);
            groupBoxInputData.Controls.Add(textBoxStart);
            groupBoxInputData.Location = new Point(485, 12);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(303, 161);
            groupBoxInputData.TabIndex = 1;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxEndNum
            // 
            textBoxEndNum.Location = new Point(172, 87);
            textBoxEndNum.Name = "textBoxEndNum";
            textBoxEndNum.ReadOnly = true;
            textBoxEndNum.Size = new Size(125, 27);
            textBoxEndNum.TabIndex = 3;
            textBoxEndNum.Text = "5";
            // 
            // textBoxStartNum
            // 
            textBoxStartNum.Location = new Point(6, 87);
            textBoxStartNum.Name = "textBoxStartNum";
            textBoxStartNum.ReadOnly = true;
            textBoxStartNum.Size = new Size(125, 27);
            textBoxStartNum.TabIndex = 2;
            textBoxStartNum.Text = "-5";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(172, 26);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.ReadOnly = true;
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 1;
            textBoxEnd.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "Старт шага:";
            // 
            // groupBoxOutputData
            // 
            groupBoxOutputData.Controls.Add(textBoxResult);
            groupBoxOutputData.Location = new Point(18, 179);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(341, 348);
            groupBoxOutputData.TabIndex = 2;
            groupBoxOutputData.TabStop = false;
            groupBoxOutputData.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(329, 316);
            textBoxResult.TabIndex = 0;
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunc.Legends.Add(legend1);
            chartFunc.Location = new Point(381, 179);
            chartFunc.Name = "chartFunc";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc.Series.Add(series1);
            chartFunc.Size = new Size(680, 348);
            chartFunc.TabIndex = 3;
            chartFunc.Text = "График функции";
            title1.Name = "График Функции";
            title1.Text = "График функции";
            chartFunc.Titles.Add(title1);
            // 
            // buttonDoMath
            // 
            buttonDoMath.Location = new Point(794, 22);
            buttonDoMath.Name = "buttonDoMath";
            buttonDoMath.Size = new Size(119, 151);
            buttonDoMath.TabIndex = 4;
            buttonDoMath.Text = "Выполнить";
            buttonDoMath.UseVisualStyleBackColor = true;
            buttonDoMath.Click += buttonDoMath_Click;
            // 
            // buttonSaveInFile
            // 
            buttonSaveInFile.Location = new Point(919, 22);
            buttonSaveInFile.Name = "buttonSaveInFile";
            buttonSaveInFile.Size = new Size(142, 151);
            buttonSaveInFile.TabIndex = 5;
            buttonSaveInFile.Text = "Сохранить";
            buttonSaveInFile.UseVisualStyleBackColor = true;
            buttonSaveInFile.Click += buttonSaveInFile_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 539);
            Controls.Add(buttonSaveInFile);
            Controls.Add(buttonDoMath);
            Controls.Add(chartFunc);
            Controls.Add(groupBoxOutputData);
            Controls.Add(groupBoxInputData);
            Controls.Add(groupBoxTask);
            MaximumSize = new Size(1104, 586);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 15 | Ковязин А.А.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            groupBoxOutputData.ResumeLayout(false);
            groupBoxOutputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxInputData;
        private TextBox textBoxStart;
        private TextBox textBoxEndNum;
        private TextBox textBoxStartNum;
        private TextBox textBoxEnd;
        private GroupBox groupBoxOutputData;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private Button buttonDoMath;
        private Button buttonSaveInFile;
    }
}
