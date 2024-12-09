using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovyazinAA.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] ints = new int[] { matrix[0, 4], matrix[1, 4], matrix[2, 4], matrix[3, 4], matrix[4, 4] };
            Array.Sort(ints);
            for (int i = 0; i < ints.Length; i++)
            {
                matrix[i,4] = ints[i];
            }
            return matrix;
        }
    }
}
