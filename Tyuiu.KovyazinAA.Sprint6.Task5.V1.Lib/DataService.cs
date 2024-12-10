using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovyazinAA.Sprint6.Task5.V1.Lib
{
    public class DataService : ISprint6Task5V1
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray.Where(val  => val > 0).ToArray();
            return numsArray;
        }
    }
}
