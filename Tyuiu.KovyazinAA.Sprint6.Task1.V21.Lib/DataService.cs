using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovyazinAA.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 - 2 * i != 0)
                {
                    y = (Math.Cos(i)) + ((Math.Sin(i)) / (2 - 2 * i)) - (4 * i);
                    y = Math.Round(y, 3);
                    res[count] = y;
                }
                else
                {
                    res[count] = 0;
                }
                count++;
            }
            return res;
        }
    }
}
