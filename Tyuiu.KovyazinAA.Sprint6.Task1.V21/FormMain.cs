using Tyuiu.KovyazinAA.Sprint6.Task1.V21.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBoxStartNum.Text);
            int end = Convert.ToInt32(textBoxEndNum.Text);
            string strLine;

            int len = ds.GetMassFunction(start, end).Length;

            double[] value = new double[len];

            value = ds.GetMassFunction(start,end);
            textBoxResult.Text = "";
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            textBoxResult.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
            for (int i = 0; i < len; i++)
            {
                strLine = String.Format("|{0,5:d}     |  {1, 5:f2}  |", start, value[i]);
                textBoxResult.AppendText((strLine + Environment.NewLine));
                start++;
            }
            textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}
