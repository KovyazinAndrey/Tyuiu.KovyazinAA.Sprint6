namespace Tyuiu.KovyazinAA.Sprint6.Task7.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask = new Panel();
            buttonInfo = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panelInputData = new Panel();
            groupBoxInput = new GroupBox();
            dataGridViewIn = new DataGridView();
            splitter1 = new Splitter();
            panelOutputData = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelInputData.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelOutputData.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(buttonInfo);
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Controls.Add(buttonSaveFile);
            panelTask.Controls.Add(buttonDone);
            panelTask.Controls.Add(buttonOpenFile);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(921, 172);
            panelTask.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.Image = (Image)resources.GetObject("buttonInfo.Image");
            buttonInfo.Location = new Point(795, 3);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(123, 70);
            buttonInfo.TabIndex = 4;
            toolTipButton.SetToolTip(buttonInfo, "Информация о программе");
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Bottom;
            groupBoxTask.Location = new Point(0, 74);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(921, 98);
            groupBoxTask.TabIndex = 3;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(3, 23);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(915, 72);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Cursor = Cursors.Hand;
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(254, 3);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(128, 70);
            buttonSaveFile.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSaveFile, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            buttonSaveFile.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(135, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(115, 70);
            buttonDone.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone, "Выполнить обработку данных");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Cursor = Cursors.Hand;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(3, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(126, 70);
            buttonOpenFile.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpenFile, "Открыть фаул для обработки в формате CSV");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // panelInputData
            // 
            panelInputData.Controls.Add(groupBoxInput);
            panelInputData.Dock = DockStyle.Left;
            panelInputData.Location = new Point(0, 172);
            panelInputData.Name = "panelInputData";
            panelInputData.Size = new Size(382, 373);
            panelInputData.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewIn);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(382, 373);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 23);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(376, 347);
            dataGridViewIn.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(382, 172);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 373);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelOutputData
            // 
            panelOutputData.BackColor = SystemColors.Control;
            panelOutputData.Controls.Add(groupBoxOutput);
            panelOutputData.Dock = DockStyle.Fill;
            panelOutputData.Location = new Point(386, 172);
            panelOutputData.Name = "panelOutputData";
            panelOutputData.Size = new Size(535, 373);
            panelOutputData.TabIndex = 3;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOut);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(535, 373);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 23);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(529, 347);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 545);
            Controls.Add(panelOutputData);
            Controls.Add(splitter1);
            Controls.Add(panelInputData);
            Controls.Add(panelTask);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 8 | Ковязин.А.А.";
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelInputData.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelOutputData.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private Panel panelInputData;
        private Splitter splitter1;
        private Panel panelOutputData;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Button buttonSaveFile;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonInfo;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewIn;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewOut;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
