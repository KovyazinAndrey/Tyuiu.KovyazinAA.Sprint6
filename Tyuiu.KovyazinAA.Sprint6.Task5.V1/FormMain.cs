using Tyuiu.KovyazinAA.Sprint6.Task5.V1.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task5.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V1.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewOutputData.ColumnCount = 2;
            dataGridViewOutputData.Columns[0].Width = 20;
            dataGridViewOutputData.Columns[1].Width = 50;

            this.chartNums.ChartAreas[0].AxisX.Title = "Îñü Õ";
            this.chartNums.ChartAreas[0].AxisY.Title = "Îñü Y";

            chartNums.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewOutputData.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartNums.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenInputFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
