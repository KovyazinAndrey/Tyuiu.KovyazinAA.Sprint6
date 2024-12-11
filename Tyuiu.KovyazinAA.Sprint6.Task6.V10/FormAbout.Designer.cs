namespace Tyuiu.KovyazinAA.Sprint6.Task6.V10
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo = new Label();
            buttonOk_KovyazinAA = new Button();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(12, 9);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(385, 180);
            labelInfo.TabIndex = 0;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // buttonOk_KovyazinAA
            // 
            buttonOk_KovyazinAA.Location = new Point(344, 195);
            buttonOk_KovyazinAA.Name = "buttonOk_KovyazinAA";
            buttonOk_KovyazinAA.Size = new Size(94, 29);
            buttonOk_KovyazinAA.TabIndex = 1;
            buttonOk_KovyazinAA.Text = "Ok";
            buttonOk_KovyazinAA.UseVisualStyleBackColor = true;
            buttonOk_KovyazinAA.Click += buttonOk_KovyazinAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 236);
            Controls.Add(buttonOk_KovyazinAA);
            Controls.Add(labelInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(468, 283);
            MinimizeBox = false;
            MinimumSize = new Size(468, 283);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Button buttonOk_KovyazinAA;
    }
}