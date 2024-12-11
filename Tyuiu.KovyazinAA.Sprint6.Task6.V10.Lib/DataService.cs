using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KovyazinAA.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("w") || line.Contains("W")) 
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;
        }
    }
}
