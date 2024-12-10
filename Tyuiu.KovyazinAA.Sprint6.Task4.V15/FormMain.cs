using System.IO;
using Tyuiu.KovyazinAA.Sprint6.Task4.V15.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDoMath_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBoxStartNum.Text);
            int end = Convert.ToInt32(textBoxEndNum.Text);
            int len = ds.GetMassFunction(start, end).Length;

            double[] ArrayValue;
            ArrayValue = new double[len];

            ArrayValue = ds.GetMassFunction(start, end);

            this.chartFunc.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunc.ChartAreas[0].AxisY.Title = "Ось Y";

            textBoxResult.Text = "";
            chartFunc.Series[0].Points.Clear();

            for (int i = 0; i < len; i++)
            {
                this.chartFunc.Series[0].Points.AddXY(start, ArrayValue[i]);
                textBoxResult.AppendText(ArrayValue[i] + Environment.NewLine);
                start++;
            }
        }

        private void buttonSaveInFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V15.txt");
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте? ", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла ","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
