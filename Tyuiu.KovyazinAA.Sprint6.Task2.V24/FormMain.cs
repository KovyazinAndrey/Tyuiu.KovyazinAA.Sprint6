using Tyuiu.KovyazinAA.Sprint6.Task2.V24.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task2.V24
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
            int start = Convert.ToInt32(textBoxStartNum.Text);
            int end = Convert.ToInt32(textBoxEndNum.Text);

            int len = ds.GetMassFunction(start, end).Length;

            double[] value = new double[len];

            value = ds.GetMassFunction(start, end);

            for (int i = 0; i < len; i++)
            {
                this.dataGridView1.Rows.Add(Convert.ToString(start), Convert.ToString(value[i]));
                start++;
            }

        }
    }
}
