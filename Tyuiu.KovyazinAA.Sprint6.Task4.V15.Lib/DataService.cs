using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovyazinAA.Sprint6.Task4.V15.Lib
{
    public class DataService : ISprint6Task4V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] value;
            int len = stopValue - startValue + 1;
            value = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 * i != 0)
                {
                    double y = Math.Sin(i) + ((2 * i) / 3) - (Math.Cos(i) * 4 * i);
                    y = Math.Round(y, 2);
                    value[count] = y;
                }
                else
                {
                    value[count] = 0;
                }
                count++;
            }
            return value;
        }
    }
}
