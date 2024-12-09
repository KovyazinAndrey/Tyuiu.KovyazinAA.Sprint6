using Tyuiu.KovyazinAA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.KovyazinAA.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { 4, 32, -20, 27, 21 },
                                      { 17, 15, -1, -2, -1 },
                                      { -3, 18, 12, -10, 29 },
                                      { 7, -15, 2, -8, 12 },
                                      { -10, 25, 5, 27, 21 }};
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
