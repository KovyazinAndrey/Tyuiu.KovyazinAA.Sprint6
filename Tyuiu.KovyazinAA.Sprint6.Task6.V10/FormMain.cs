using Tyuiu.KovyazinAA.Sprint6.Task6.V10.Lib;

namespace Tyuiu.KovyazinAA.Sprint6.Task6.V10
{
    public partial class FormMain_KovyazinAA : Form
    {
        public FormMain_KovyazinAA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInputData.Text = File.ReadAllText(openFilePath);
            groupBoxInputData.Text = groupBoxInputData.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutputData.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
