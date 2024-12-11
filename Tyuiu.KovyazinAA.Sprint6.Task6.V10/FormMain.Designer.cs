namespace Tyuiu.KovyazinAA.Sprint6.Task6.V10
{
    partial class FormMain_KovyazinAA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KovyazinAA));
            openFileDialogTask = new OpenFileDialog();
            toolTipHelp = new ToolTip(components);
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            panelTaskAndButtons = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panel1 = new Panel();
            groupBoxInputData = new GroupBox();
            textBoxInputData = new TextBox();
            splitter1 = new Splitter();
            panel2 = new Panel();
            groupBoxOutputData = new GroupBox();
            textBoxOutputData = new TextBox();
            panelTaskAndButtons.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxInputData.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutputData.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipHelp
            // 
            toolTipHelp.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackgroundImage = (Image)resources.GetObject("buttonHelp.BackgroundImage");
            buttonHelp.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.Location = new Point(673, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(117, 84);
            buttonHelp.TabIndex = 3;
            toolTipHelp.SetToolTip(buttonHelp, "Сведения о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackgroundImage = (Image)resources.GetObject("buttonOpenFile.BackgroundImage");
            buttonOpenFile.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile.Cursor = Cursors.Hand;
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(142, 84);
            buttonOpenFile.TabIndex = 1;
            toolTipHelp.SetToolTip(buttonOpenFile, "Выбрать файл.\r\nВыберите нужный фаул для обработки.\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(160, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(124, 84);
            buttonDone.TabIndex = 2;
            toolTipHelp.SetToolTip(buttonDone, "Производит поиск в файле слов содержащих \"w\" и выводит строки с ними.\r\n");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // panelTaskAndButtons
            // 
            panelTaskAndButtons.Controls.Add(buttonHelp);
            panelTaskAndButtons.Controls.Add(buttonDone);
            panelTaskAndButtons.Controls.Add(buttonOpenFile);
            panelTaskAndButtons.Controls.Add(groupBoxTask);
            panelTaskAndButtons.Dock = DockStyle.Top;
            panelTaskAndButtons.Location = new Point(0, 0);
            panelTaskAndButtons.Name = "panelTaskAndButtons";
            panelTaskAndButtons.Size = new Size(802, 202);
            panelTaskAndButtons.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Bottom;
            groupBoxTask.Location = new Point(0, 102);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(802, 100);
            groupBoxTask.TabIndex = 0;
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
            textBoxTask.Size = new Size(796, 74);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxInputData);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 251);
            panel1.TabIndex = 1;
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(textBoxInputData);
            groupBoxInputData.Dock = DockStyle.Fill;
            groupBoxInputData.Location = new Point(0, 0);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(298, 251);
            groupBoxInputData.TabIndex = 0;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = "Ввод";
            // 
            // textBoxInputData
            // 
            textBoxInputData.Dock = DockStyle.Fill;
            textBoxInputData.Location = new Point(3, 23);
            textBoxInputData.Multiline = true;
            textBoxInputData.Name = "textBoxInputData";
            textBoxInputData.ReadOnly = true;
            textBoxInputData.ScrollBars = ScrollBars.Vertical;
            textBoxInputData.Size = new Size(292, 225);
            textBoxInputData.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(298, 202);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 251);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutputData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(302, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 251);
            panel2.TabIndex = 3;
            // 
            // groupBoxOutputData
            // 
            groupBoxOutputData.Controls.Add(textBoxOutputData);
            groupBoxOutputData.Dock = DockStyle.Fill;
            groupBoxOutputData.Location = new Point(0, 0);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(500, 251);
            groupBoxOutputData.TabIndex = 0;
            groupBoxOutputData.TabStop = false;
            groupBoxOutputData.Text = "Вывод";
            // 
            // textBoxOutputData
            // 
            textBoxOutputData.Dock = DockStyle.Fill;
            textBoxOutputData.Location = new Point(3, 23);
            textBoxOutputData.Multiline = true;
            textBoxOutputData.Name = "textBoxOutputData";
            textBoxOutputData.ReadOnly = true;
            textBoxOutputData.ScrollBars = ScrollBars.Vertical;
            textBoxOutputData.Size = new Size(494, 225);
            textBoxOutputData.TabIndex = 0;
            // 
            // FormMain_KovyazinAA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(panel2);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(panelTaskAndButtons);
            MinimumSize = new Size(820, 500);
            Name = "FormMain_KovyazinAA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 10 | Ковязин А.А.";
            panelTaskAndButtons.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutputData.ResumeLayout(false);
            groupBoxOutputData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipHelp;
        private Panel panelTaskAndButtons;
        private GroupBox groupBoxTask;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private TextBox textBoxTask;
        private Panel panel1;
        private Splitter splitter1;
        private GroupBox groupBoxInputData;
        private TextBox textBoxInputData;
        private Panel panel2;
        private GroupBox groupBoxOutputData;
        private TextBox textBoxOutputData;
    }
}
