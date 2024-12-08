using Tyuiu.KovyazinAA.Sprint6.Task0.V16.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int x = 3;
            double y = ds.Calculate(x);
            textBoxResult.Text = Convert.ToString(y);
        }
    }
}
