using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovyazinAA.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] {'\r'}, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i,j] = Convert.ToInt32(line_r[j]);
                }
            }
            int RowsRes = arrayValues.GetUpperBound(0) + 1;
            int ColsRes = arrayValues.Length / RowsRes;

            int xCol = 7;

            for (int i = 0; i < RowsRes; i++)
            {
                for (int j = xCol; j <= xCol; j++)
                {
                    if (arrayValues[i, j] != 5)
                    {
                        arrayValues[i, j] = -1;
                    }
                }
            }
            return arrayValues;
        }
    }
}
